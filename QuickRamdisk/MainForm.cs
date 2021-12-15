using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace QuickRamdisk
{
    public partial class MainForm : Form
    {
        private static readonly Regex TextValidationRegex = new Regex(@"^(\d+)(?:(\.\d+)?([MG]))?$", RegexOptions.IgnoreCase);

        private bool IgnoreChanges = false;
        private int MaximumMegs = 4096;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ulong totalMegs = (new ComputerInfo()).AvailablePhysicalMemory / (1024 * 1024);
            this.sizeTrackBar.Maximum = (int)totalMegs;
            this.MaximumMegs = (int)totalMegs;

            HashSet<char> letters = new HashSet<char>(Enumerable.Range('A', 'Z' - 'A' + 1).Select(x => (char)x));
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            char lastLetter = '\0';

            for (int i = 0; i < allDrives.Length; i++)
            {
                char letter = Char.ToUpper(allDrives[i].Name[0]);

                if (i == allDrives.Length - 1)
                {
                    lastLetter = letter;
                }

                letters.Remove(letter);
            }

            this.mountpointComboBox.Items.AddRange(letters.Select(x => x + ":").ToArray());
            this.mountpointComboBox.Text = (lastLetter == 'Z' ? '#' : (char)(lastLetter + 1)) + ":";
        }
        
        private void sizeTrackBar_Scroll(object sender, EventArgs e)
        {
            this.UpdateLinkedControls(sender, this.sizeTrackBar.Value);
        }

        private static int? ValidateSizeText(string text)
        {
            Match match = TextValidationRegex.Match(text);
            if (!match.Success)
            {
                return null;
            }

            double bigPart = Convert.ToInt32(match.Groups[1].Value);
            int multiplier = 1;

            if (match.Groups[3].Success)
            {
                multiplier = match.Groups[3].Value.ToUpper()[0] switch
                {
                    'M' => 1,
                    'G' => 1024,
                    _ => throw new ArgumentOutOfRangeException()
                };

                if (match.Groups[2].Success)
                {
                    bigPart += Convert.ToDouble(match.Groups[2].Value);
                }
            }

            return (int)(bigPart * multiplier);
        }

        private void sizeTextBox_TextChanged(object sender, EventArgs e)
        {
            int? parsedSize = ValidateSizeText(sizeTextBox.Text);
            bool validSize = parsedSize != null && parsedSize >= 32 && parsedSize <= this.MaximumMegs;

            sizeTextBox.BackColor = validSize ? Color.White : Color.PaleVioletRed;
            if (!validSize)
            {
                return;
            }

            this.UpdateLinkedControls(sender, (int)parsedSize);
        }

        private void UpdateLinkedControls(object sender, int value)
        {
            if (this.IgnoreChanges)
            {
                return;
            }

            this.IgnoreChanges = true;

            this.UpdateAvailableFilesystems(value);

            if (sender == this.sizeTextBox)
            {
                this.sizeTrackBar.Value = value;
            }
            else
            {
                this.sizeTextBox.Text = value.ToString() + "M";
            }

            this.IgnoreChanges = false;
        }

        private void UpdateAvailableFilesystems(int mbs)
        {
            this.fsFat32RadioButton.Enabled = mbs >= 64 && mbs <= 32 * 1024;
            if (this.fsFat32RadioButton.Checked && !this.fsFat32RadioButton.Enabled)
            {
                this.fsExfatRadioButton.Checked = true;
            }
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(this.mountpointComboBox.Text, "^[A-Z#]:$"))
            {
                MessageBox.Show("Invalid mountpoint", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<string> arguments = new List<string>();

            arguments.Add("-a");
            arguments.Add("-t");
            arguments.Add("vm");

            arguments.Add("-s");
            arguments.Add(ValidateSizeText(this.sizeTextBox.Text).Value + "M");

            if (!this.fsNoneRadioButton.Checked)
            {
                arguments.Add("-p");
                string formatParameters = "/FS:";
                if (this.fsFat32RadioButton.Checked)
                {
                    formatParameters += "FAT32";
                }
                else if (this.fsExfatRadioButton.Checked)
                {
                    formatParameters += "exFAT";
                }
                else if (this.fsNtfsRadioButton.Checked)
                {
                    formatParameters += "NTFS";
                }
                formatParameters += " /Q /Y";
                arguments.Add(formatParameters);
            }

            arguments.Add("-o");
            arguments.Add("rw,rem,hd");

            arguments.Add("-m");
            arguments.Add(this.mountpointComboBox.Text);

            Process.Start("imdisk", arguments).WaitForExit();
            this.Close();
        }
    }
}
