
namespace QuickRamdisk
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sizeGroupBox = new System.Windows.Forms.GroupBox();
            this.sizeTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.sizeTrackBar = new System.Windows.Forms.TrackBar();
            this.sizeTextBox = new System.Windows.Forms.TextBox();
            this.fsGroupBox = new System.Windows.Forms.GroupBox();
            this.fsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.fsFat32RadioButton = new System.Windows.Forms.RadioButton();
            this.fsExfatRadioButton = new System.Windows.Forms.RadioButton();
            this.fsNtfsRadioButton = new System.Windows.Forms.RadioButton();
            this.fsNoneRadioButton = new System.Windows.Forms.RadioButton();
            this.mountpointGroupBox = new System.Windows.Forms.GroupBox();
            this.mountpointComboBox = new System.Windows.Forms.ComboBox();
            this.goButton = new System.Windows.Forms.Button();
            this.sizeGroupBox.SuspendLayout();
            this.sizeTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sizeTrackBar)).BeginInit();
            this.fsGroupBox.SuspendLayout();
            this.fsTableLayoutPanel.SuspendLayout();
            this.mountpointGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // sizeGroupBox
            // 
            this.sizeGroupBox.AutoSize = true;
            this.sizeGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sizeGroupBox.Controls.Add(this.sizeTableLayoutPanel);
            this.sizeGroupBox.Location = new System.Drawing.Point(12, 12);
            this.sizeGroupBox.Name = "sizeGroupBox";
            this.sizeGroupBox.Size = new System.Drawing.Size(400, 73);
            this.sizeGroupBox.TabIndex = 0;
            this.sizeGroupBox.TabStop = false;
            this.sizeGroupBox.Text = "Size (MB)";
            // 
            // sizeTableLayoutPanel
            // 
            this.sizeTableLayoutPanel.AutoSize = true;
            this.sizeTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sizeTableLayoutPanel.ColumnCount = 2;
            this.sizeTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.sizeTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.sizeTableLayoutPanel.Controls.Add(this.sizeTrackBar, 0, 0);
            this.sizeTableLayoutPanel.Controls.Add(this.sizeTextBox, 1, 0);
            this.sizeTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sizeTableLayoutPanel.Location = new System.Drawing.Point(3, 19);
            this.sizeTableLayoutPanel.Name = "sizeTableLayoutPanel";
            this.sizeTableLayoutPanel.RowCount = 1;
            this.sizeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.sizeTableLayoutPanel.Size = new System.Drawing.Size(394, 51);
            this.sizeTableLayoutPanel.TabIndex = 0;
            // 
            // sizeTrackBar
            // 
            this.sizeTrackBar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.sizeTrackBar.AutoSize = false;
            this.sizeTrackBar.Location = new System.Drawing.Point(3, 3);
            this.sizeTrackBar.Maximum = 8192;
            this.sizeTrackBar.Minimum = 32;
            this.sizeTrackBar.Name = "sizeTrackBar";
            this.sizeTrackBar.Size = new System.Drawing.Size(307, 45);
            this.sizeTrackBar.TabIndex = 1;
            this.sizeTrackBar.TickFrequency = 128;
            this.sizeTrackBar.Value = 4096;
            this.sizeTrackBar.Scroll += new System.EventHandler(this.sizeTrackBar_Scroll);
            // 
            // sizeTextBox
            // 
            this.sizeTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.sizeTextBox.Location = new System.Drawing.Point(316, 14);
            this.sizeTextBox.Name = "sizeTextBox";
            this.sizeTextBox.Size = new System.Drawing.Size(75, 23);
            this.sizeTextBox.TabIndex = 0;
            this.sizeTextBox.Text = "4G";
            this.sizeTextBox.TextChanged += new System.EventHandler(this.sizeTextBox_TextChanged);
            // 
            // fsGroupBox
            // 
            this.fsGroupBox.AutoSize = true;
            this.fsGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.fsGroupBox.Controls.Add(this.fsTableLayoutPanel);
            this.fsGroupBox.Location = new System.Drawing.Point(12, 91);
            this.fsGroupBox.Name = "fsGroupBox";
            this.fsGroupBox.Size = new System.Drawing.Size(128, 72);
            this.fsGroupBox.TabIndex = 1;
            this.fsGroupBox.TabStop = false;
            this.fsGroupBox.Text = "File system format";
            // 
            // fsTableLayoutPanel
            // 
            this.fsTableLayoutPanel.AutoSize = true;
            this.fsTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.fsTableLayoutPanel.ColumnCount = 2;
            this.fsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.fsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.fsTableLayoutPanel.Controls.Add(this.fsFat32RadioButton, 0, 0);
            this.fsTableLayoutPanel.Controls.Add(this.fsExfatRadioButton, 1, 0);
            this.fsTableLayoutPanel.Controls.Add(this.fsNtfsRadioButton, 0, 1);
            this.fsTableLayoutPanel.Controls.Add(this.fsNoneRadioButton, 1, 1);
            this.fsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fsTableLayoutPanel.Location = new System.Drawing.Point(3, 19);
            this.fsTableLayoutPanel.Name = "fsTableLayoutPanel";
            this.fsTableLayoutPanel.RowCount = 2;
            this.fsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.fsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.fsTableLayoutPanel.Size = new System.Drawing.Size(122, 50);
            this.fsTableLayoutPanel.TabIndex = 0;
            // 
            // fsFat32RadioButton
            // 
            this.fsFat32RadioButton.AutoSize = true;
            this.fsFat32RadioButton.Checked = true;
            this.fsFat32RadioButton.Location = new System.Drawing.Point(3, 3);
            this.fsFat32RadioButton.Name = "fsFat32RadioButton";
            this.fsFat32RadioButton.Size = new System.Drawing.Size(55, 19);
            this.fsFat32RadioButton.TabIndex = 0;
            this.fsFat32RadioButton.TabStop = true;
            this.fsFat32RadioButton.Text = "FAT32";
            this.fsFat32RadioButton.UseVisualStyleBackColor = true;
            // 
            // fsExfatRadioButton
            // 
            this.fsExfatRadioButton.AutoSize = true;
            this.fsExfatRadioButton.Location = new System.Drawing.Point(64, 3);
            this.fsExfatRadioButton.Name = "fsExfatRadioButton";
            this.fsExfatRadioButton.Size = new System.Drawing.Size(55, 19);
            this.fsExfatRadioButton.TabIndex = 1;
            this.fsExfatRadioButton.Text = "exFAT";
            this.fsExfatRadioButton.UseVisualStyleBackColor = true;
            // 
            // fsNtfsRadioButton
            // 
            this.fsNtfsRadioButton.AutoSize = true;
            this.fsNtfsRadioButton.Location = new System.Drawing.Point(3, 28);
            this.fsNtfsRadioButton.Name = "fsNtfsRadioButton";
            this.fsNtfsRadioButton.Size = new System.Drawing.Size(52, 19);
            this.fsNtfsRadioButton.TabIndex = 2;
            this.fsNtfsRadioButton.Text = "NTFS";
            this.fsNtfsRadioButton.UseVisualStyleBackColor = true;
            // 
            // fsNoneRadioButton
            // 
            this.fsNoneRadioButton.AutoSize = true;
            this.fsNoneRadioButton.Location = new System.Drawing.Point(64, 28);
            this.fsNoneRadioButton.Name = "fsNoneRadioButton";
            this.fsNoneRadioButton.Size = new System.Drawing.Size(54, 19);
            this.fsNoneRadioButton.TabIndex = 3;
            this.fsNoneRadioButton.Text = "None";
            this.fsNoneRadioButton.UseVisualStyleBackColor = true;
            // 
            // mountpointGroupBox
            // 
            this.mountpointGroupBox.AutoSize = true;
            this.mountpointGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mountpointGroupBox.Controls.Add(this.mountpointComboBox);
            this.mountpointGroupBox.Location = new System.Drawing.Point(146, 91);
            this.mountpointGroupBox.Name = "mountpointGroupBox";
            this.mountpointGroupBox.Size = new System.Drawing.Size(92, 68);
            this.mountpointGroupBox.TabIndex = 2;
            this.mountpointGroupBox.TabStop = false;
            this.mountpointGroupBox.Text = "Mountpoint";
            // 
            // mountpointComboBox
            // 
            this.mountpointComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mountpointComboBox.FormattingEnabled = true;
            this.mountpointComboBox.Location = new System.Drawing.Point(6, 23);
            this.mountpointComboBox.Name = "mountpointComboBox";
            this.mountpointComboBox.Size = new System.Drawing.Size(80, 23);
            this.mountpointComboBox.Sorted = true;
            this.mountpointComboBox.TabIndex = 0;
            // 
            // goButton
            // 
            this.goButton.Location = new System.Drawing.Point(331, 114);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(75, 45);
            this.goButton.TabIndex = 3;
            this.goButton.Text = "Go";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.goButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 174);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.mountpointGroupBox);
            this.Controls.Add(this.fsGroupBox);
            this.Controls.Add(this.sizeGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quick ramdisk";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.sizeGroupBox.ResumeLayout(false);
            this.sizeGroupBox.PerformLayout();
            this.sizeTableLayoutPanel.ResumeLayout(false);
            this.sizeTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sizeTrackBar)).EndInit();
            this.fsGroupBox.ResumeLayout(false);
            this.fsGroupBox.PerformLayout();
            this.fsTableLayoutPanel.ResumeLayout(false);
            this.fsTableLayoutPanel.PerformLayout();
            this.mountpointGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox sizeGroupBox;
        private System.Windows.Forms.TableLayoutPanel sizeTableLayoutPanel;
        private System.Windows.Forms.TrackBar sizeTrackBar;
        private System.Windows.Forms.GroupBox fsGroupBox;
        private System.Windows.Forms.TableLayoutPanel fsTableLayoutPanel;
        private System.Windows.Forms.RadioButton fsFat32RadioButton;
        private System.Windows.Forms.RadioButton fsExfatRadioButton;
        private System.Windows.Forms.RadioButton fsNtfsRadioButton;
        private System.Windows.Forms.RadioButton fsNoneRadioButton;
        private System.Windows.Forms.GroupBox mountpointGroupBox;
        private System.Windows.Forms.ComboBox mountpointComboBox;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.TextBox sizeTextBox;
    }
}