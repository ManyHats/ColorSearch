namespace ColorSearch
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.FolderPathBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.HexColorBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.ColorPicker = new System.Windows.Forms.Button();
            this.BrowseFolder = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.ResultBox = new System.Windows.Forms.ListView();
            this.ThreshholdSlider = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.RamUsage = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ThreshholdSlider)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FolderPathBox
            // 
            this.FolderPathBox.Location = new System.Drawing.Point(47, 6);
            this.FolderPathBox.Name = "FolderPathBox";
            this.FolderPathBox.Size = new System.Drawing.Size(148, 20);
            this.FolderPathBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Path:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hex:";
            // 
            // HexColorBox
            // 
            this.HexColorBox.Enabled = false;
            this.HexColorBox.Location = new System.Drawing.Point(47, 32);
            this.HexColorBox.Name = "HexColorBox";
            this.HexColorBox.Size = new System.Drawing.Size(67, 20);
            this.HexColorBox.TabIndex = 4;
            // 
            // SearchButton
            // 
            this.SearchButton.Enabled = false;
            this.SearchButton.Location = new System.Drawing.Point(201, 32);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 20);
            this.SearchButton.TabIndex = 5;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 450);
            this.progressBar1.MaximumSize = new System.Drawing.Size(547, 23);
            this.progressBar1.MinimumSize = new System.Drawing.Size(547, 23);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(547, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 6;
            // 
            // ColorPicker
            // 
            this.ColorPicker.Location = new System.Drawing.Point(120, 32);
            this.ColorPicker.Name = "ColorPicker";
            this.ColorPicker.Size = new System.Drawing.Size(75, 20);
            this.ColorPicker.TabIndex = 7;
            this.ColorPicker.Text = "Color Picker";
            this.ColorPicker.UseVisualStyleBackColor = true;
            this.ColorPicker.Click += new System.EventHandler(this.ColorPicker_Click);
            // 
            // BrowseFolder
            // 
            this.BrowseFolder.Location = new System.Drawing.Point(201, 6);
            this.BrowseFolder.Name = "BrowseFolder";
            this.BrowseFolder.Size = new System.Drawing.Size(75, 20);
            this.BrowseFolder.TabIndex = 8;
            this.BrowseFolder.Text = "Browse";
            this.BrowseFolder.UseVisualStyleBackColor = true;
            this.BrowseFolder.Click += new System.EventHandler(this.BrowseFolder_Click);
            // 
            // ResultBox
            // 
            this.ResultBox.GridLines = true;
            this.ResultBox.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ResultBox.HideSelection = false;
            this.ResultBox.Location = new System.Drawing.Point(12, 58);
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.Size = new System.Drawing.Size(547, 386);
            this.ResultBox.TabIndex = 9;
            this.ResultBox.UseCompatibleStateImageBehavior = false;
            // 
            // ThreshholdSlider
            // 
            this.ThreshholdSlider.Location = new System.Drawing.Point(455, 7);
            this.ThreshholdSlider.Maximum = 150;
            this.ThreshholdSlider.Minimum = 10;
            this.ThreshholdSlider.Name = "ThreshholdSlider";
            this.ThreshholdSlider.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ThreshholdSlider.Size = new System.Drawing.Size(104, 45);
            this.ThreshholdSlider.TabIndex = 10;
            this.ThreshholdSlider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.ThreshholdSlider.Value = 150;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(392, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Threshold:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RamUsage});
            this.statusStrip1.Location = new System.Drawing.Point(0, 486);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(571, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // RamUsage
            // 
            this.RamUsage.Name = "RamUsage";
            this.RamUsage.Size = new System.Drawing.Size(143, 17);
            this.RamUsage.Text = "RamUsage: Probably Tons";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 508);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ThreshholdSlider);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.BrowseFolder);
            this.Controls.Add(this.ColorPicker);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.HexColorBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FolderPathBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "ColorSearch";
            ((System.ComponentModel.ISupportInitialize)(this.ThreshholdSlider)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox FolderPathBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox HexColorBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button ColorPicker;
        private System.Windows.Forms.Button BrowseFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ListView ResultBox;
        private System.Windows.Forms.TrackBar ThreshholdSlider;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel RamUsage;
    }
}

