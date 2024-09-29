namespace Example2Project
{
    partial class FrmEditor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditor));
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtEditor = new System.Windows.Forms.TextBox();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnBlue = new System.Windows.Forms.Button();
            this.btnRed = new System.Windows.Forms.Button();
            this.btnGreen = new System.Windows.Forms.Button();
            this.btnColour = new System.Windows.Forms.Button();
            this.dlgColor = new System.Windows.Forms.ColorDialog();
            this.staPage = new System.Windows.Forms.StatusStrip();
            this.staColor = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnForeColor = new System.Windows.Forms.Button();
            this.staForeColor = new System.Windows.Forms.ToolStripStatusLabel();
            this.mnuBar = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuColor = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRedBg = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBlueBg = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGreenBg = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBg = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFg = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditor = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuRed2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBlue2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGreen2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFont = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuAlignLeft = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAlignCenter = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAlignRight = new System.Windows.Forms.ToolStripMenuItem();
            this.dlgFont = new System.Windows.Forms.FontDialog();
            this.mnuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.dlgSave = new System.Windows.Forms.SaveFileDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toLeft = new System.Windows.Forms.ToolStripButton();
            this.toCenter = new System.Windows.Forms.ToolStripButton();
            this.toRight = new System.Windows.Forms.ToolStripButton();
            this.pnlBottom.SuspendLayout();
            this.staPage.SuspendLayout();
            this.mnuBar.SuspendLayout();
            this.mnuEditor.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.SystemColors.Info;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 66);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1074, 72);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "EditorApp";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEditor
            // 
            this.txtEditor.BackColor = System.Drawing.Color.PaleGreen;
            this.txtEditor.ContextMenuStrip = this.mnuEditor;
            this.txtEditor.Location = new System.Drawing.Point(236, 121);
            this.txtEditor.Multiline = true;
            this.txtEditor.Name = "txtEditor";
            this.txtEditor.Size = new System.Drawing.Size(591, 276);
            this.txtEditor.TabIndex = 1;
            this.txtEditor.Text = "I am Sahla\r\nIntern of C#\r\nQuest Global";
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btnForeColor);
            this.pnlBottom.Controls.Add(this.label2);
            this.pnlBottom.Controls.Add(this.label1);
            this.pnlBottom.Controls.Add(this.btnColour);
            this.pnlBottom.Controls.Add(this.btnGreen);
            this.pnlBottom.Controls.Add(this.btnRed);
            this.pnlBottom.Controls.Add(this.btnBlue);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 420);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1074, 101);
            this.pnlBottom.TabIndex = 2;
            // 
            // btnBlue
            // 
            this.btnBlue.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnBlue.Location = new System.Drawing.Point(189, 42);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(133, 40);
            this.btnBlue.TabIndex = 0;
            this.btnBlue.Text = "Blue";
            this.btnBlue.UseVisualStyleBackColor = false;
            this.btnBlue.Click += new System.EventHandler(this.btnBlue_Click);
            // 
            // btnRed
            // 
            this.btnRed.BackColor = System.Drawing.Color.IndianRed;
            this.btnRed.Location = new System.Drawing.Point(25, 42);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(133, 40);
            this.btnRed.TabIndex = 0;
            this.btnRed.Text = "Red";
            this.btnRed.UseVisualStyleBackColor = false;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // btnGreen
            // 
            this.btnGreen.BackColor = System.Drawing.Color.PaleGreen;
            this.btnGreen.Location = new System.Drawing.Point(337, 48);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(133, 40);
            this.btnGreen.TabIndex = 0;
            this.btnGreen.Text = "Green";
            this.btnGreen.UseVisualStyleBackColor = false;
            this.btnGreen.Click += new System.EventHandler(this.btnGreen_Click);
            // 
            // btnColour
            // 
            this.btnColour.Location = new System.Drawing.Point(513, 48);
            this.btnColour.Name = "btnColour";
            this.btnColour.Size = new System.Drawing.Size(116, 42);
            this.btnColour.TabIndex = 1;
            this.btnColour.Text = "...";
            this.btnColour.UseVisualStyleBackColor = true;
            this.btnColour.Click += new System.EventHandler(this.btnColour_Click);
            // 
            // staPage
            // 
            this.staPage.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.staPage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.staColor,
            this.staForeColor});
            this.staPage.Location = new System.Drawing.Point(0, 521);
            this.staPage.Name = "staPage";
            this.staPage.Size = new System.Drawing.Size(1074, 32);
            this.staPage.TabIndex = 3;
            // 
            // staColor
            // 
            this.staColor.Name = "staColor";
            this.staColor.Size = new System.Drawing.Size(90, 25);
            this.staColor.Text = "indianRed";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Background";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(625, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Foreground";
            // 
            // btnForeColor
            // 
            this.btnForeColor.Location = new System.Drawing.Point(693, 51);
            this.btnForeColor.Name = "btnForeColor";
            this.btnForeColor.Size = new System.Drawing.Size(166, 36);
            this.btnForeColor.TabIndex = 3;
            this.btnForeColor.Text = "Pick Color";
            this.btnForeColor.UseVisualStyleBackColor = true;
            this.btnForeColor.Click += new System.EventHandler(this.btnForeColor_Click);
            // 
            // staForeColor
            // 
            this.staForeColor.Name = "staForeColor";
            this.staForeColor.Size = new System.Drawing.Size(113, 25);
            this.staForeColor.Text = "staForeColor";
            // 
            // mnuBar
            // 
            this.mnuBar.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.mnuBar.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mnuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuColor,
            this.mnuFormat});
            this.mnuBar.Location = new System.Drawing.Point(0, 0);
            this.mnuBar.Name = "mnuBar";
            this.mnuBar.Size = new System.Drawing.Size(1074, 33);
            this.mnuBar.TabIndex = 4;
            this.mnuBar.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator3,
            this.mnuOpen,
            this.mnuSave});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(54, 29);
            this.mnuFile.Text = "File";
            // 
            // mnuColor
            // 
            this.mnuColor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRedBg,
            this.mnuBlueBg,
            this.mnuGreenBg,
            this.mnuBg,
            this.toolStripSeparator1,
            this.mnuFg});
            this.mnuColor.Name = "mnuColor";
            this.mnuColor.Size = new System.Drawing.Size(71, 29);
            this.mnuColor.Text = "Color";
            // 
            // mnuRedBg
            // 
            this.mnuRedBg.Name = "mnuRedBg";
            this.mnuRedBg.Size = new System.Drawing.Size(308, 34);
            this.mnuRedBg.Text = "Red Background Color";
            this.mnuRedBg.Click += new System.EventHandler(this.mnuRedBg_Click);
            // 
            // mnuBlueBg
            // 
            this.mnuBlueBg.Name = "mnuBlueBg";
            this.mnuBlueBg.Size = new System.Drawing.Size(308, 34);
            this.mnuBlueBg.Text = "Blue Background Color";
            this.mnuBlueBg.Click += new System.EventHandler(this.mnuBlueBg_Click);
            // 
            // mnuGreenBg
            // 
            this.mnuGreenBg.Name = "mnuGreenBg";
            this.mnuGreenBg.Size = new System.Drawing.Size(308, 34);
            this.mnuGreenBg.Text = "Green Background Color";
            this.mnuGreenBg.Click += new System.EventHandler(this.mnuGreenBg_Click);
            // 
            // mnuBg
            // 
            this.mnuBg.Name = "mnuBg";
            this.mnuBg.Size = new System.Drawing.Size(308, 34);
            this.mnuBg.Text = "Other Background Color";
            this.mnuBg.Click += new System.EventHandler(this.mnuBg_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(305, 6);
            // 
            // mnuFg
            // 
            this.mnuFg.Name = "mnuFg";
            this.mnuFg.Size = new System.Drawing.Size(308, 34);
            this.mnuFg.Text = "Foreground Color..";
            this.mnuFg.Click += new System.EventHandler(this.mnuFg_Click);
            // 
            // mnuEditor
            // 
            this.mnuEditor.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mnuEditor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRed2,
            this.mnuBlue2,
            this.mnuGreen2});
            this.mnuEditor.Name = "mnuEditor";
            this.mnuEditor.Size = new System.Drawing.Size(279, 100);
            // 
            // mnuRed2
            // 
            this.mnuRed2.Name = "mnuRed2";
            this.mnuRed2.Size = new System.Drawing.Size(278, 32);
            this.mnuRed2.Text = "Red Background Color";
            this.mnuRed2.Click += new System.EventHandler(this.mnuRed2_Click);
            // 
            // mnuBlue2
            // 
            this.mnuBlue2.Name = "mnuBlue2";
            this.mnuBlue2.Size = new System.Drawing.Size(278, 32);
            this.mnuBlue2.Text = "Blue Background Color";
            this.mnuBlue2.Click += new System.EventHandler(this.mnuBlue2_Click);
            // 
            // mnuGreen2
            // 
            this.mnuGreen2.Name = "mnuGreen2";
            this.mnuGreen2.Size = new System.Drawing.Size(278, 32);
            this.mnuGreen2.Text = "Green Background Color";
            this.mnuGreen2.Click += new System.EventHandler(this.mnuGreen2_Click);
            // 
            // mnuFormat
            // 
            this.mnuFormat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFont,
            this.toolStripSeparator2,
            this.mnuAlignLeft,
            this.mnuAlignCenter,
            this.mnuAlignRight});
            this.mnuFormat.Name = "mnuFormat";
            this.mnuFormat.Size = new System.Drawing.Size(85, 29);
            this.mnuFormat.Text = "Format";
            // 
            // mnuFont
            // 
            this.mnuFont.Name = "mnuFont";
            this.mnuFont.Size = new System.Drawing.Size(270, 34);
            this.mnuFont.Text = "Font..";
            this.mnuFont.Click += new System.EventHandler(this.mnuFont_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(267, 6);
            // 
            // mnuAlignLeft
            // 
            this.mnuAlignLeft.Image = ((System.Drawing.Image)(resources.GetObject("mnuAlignLeft.Image")));
            this.mnuAlignLeft.Name = "mnuAlignLeft";
            this.mnuAlignLeft.Size = new System.Drawing.Size(270, 34);
            this.mnuAlignLeft.Text = "Align Left";
            this.mnuAlignLeft.Click += new System.EventHandler(this.mnuAlignLeft_Click);
            // 
            // mnuAlignCenter
            // 
            this.mnuAlignCenter.Image = ((System.Drawing.Image)(resources.GetObject("mnuAlignCenter.Image")));
            this.mnuAlignCenter.Name = "mnuAlignCenter";
            this.mnuAlignCenter.Size = new System.Drawing.Size(270, 34);
            this.mnuAlignCenter.Text = "Align Center";
            this.mnuAlignCenter.Click += new System.EventHandler(this.mnuAlignCenter_Click);
            // 
            // mnuAlignRight
            // 
            this.mnuAlignRight.Image = ((System.Drawing.Image)(resources.GetObject("mnuAlignRight.Image")));
            this.mnuAlignRight.Name = "mnuAlignRight";
            this.mnuAlignRight.Size = new System.Drawing.Size(270, 34);
            this.mnuAlignRight.Text = "Align Right";
            this.mnuAlignRight.Click += new System.EventHandler(this.mnuAlignRight_Click);
            // 
            // mnuOpen
            // 
            this.mnuOpen.Name = "mnuOpen";
            this.mnuOpen.Size = new System.Drawing.Size(270, 34);
            this.mnuOpen.Text = "Open..";
            this.mnuOpen.Click += new System.EventHandler(this.mnuOpen_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(267, 6);
            // 
            // mnuSave
            // 
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.Size = new System.Drawing.Size(270, 34);
            this.mnuSave.Text = "Save...";
            this.mnuSave.Click += new System.EventHandler(this.mnuSave_Click);
            // 
            // dlgOpen
            // 
            this.dlgOpen.FileName = "mytext";
            this.dlgOpen.Filter = "Text File(*.txt)|JSON File(*.json)";
            // 
            // dlgSave
            // 
            this.dlgSave.FileName = "mytext1.txt";
            this.dlgSave.Filter = "Text File(*.txt)|JSON File(*.json)";
            this.dlgSave.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toLeft,
            this.toCenter,
            this.toRight});
            this.toolStrip1.Location = new System.Drawing.Point(0, 33);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1074, 33);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toLeft
            // 
            this.toLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toLeft.Image = ((System.Drawing.Image)(resources.GetObject("toLeft.Image")));
            this.toLeft.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toLeft.Name = "toLeft";
            this.toLeft.Size = new System.Drawing.Size(34, 28);
            this.toLeft.Text = "toolStripButton1";
            this.toLeft.Click += new System.EventHandler(this.toLeft_Click);
            // 
            // toCenter
            // 
            this.toCenter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toCenter.Image = ((System.Drawing.Image)(resources.GetObject("toCenter.Image")));
            this.toCenter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toCenter.Name = "toCenter";
            this.toCenter.Size = new System.Drawing.Size(34, 28);
            this.toCenter.Text = "toolStripButton2";
            this.toCenter.Click += new System.EventHandler(this.toCenter_Click);
            // 
            // toRight
            // 
            this.toRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toRight.Image = ((System.Drawing.Image)(resources.GetObject("toRight.Image")));
            this.toRight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toRight.Name = "toRight";
            this.toRight.Size = new System.Drawing.Size(34, 28);
            this.toRight.Text = "toolStripButton3";
            this.toRight.Click += new System.EventHandler(this.toRight_Click);
            // 
            // FrmEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 553);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.staPage);
            this.Controls.Add(this.txtEditor);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.mnuBar);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.mnuBar;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FrmEditor";
            this.Text = "EditorApp";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.staPage.ResumeLayout(false);
            this.staPage.PerformLayout();
            this.mnuBar.ResumeLayout(false);
            this.mnuBar.PerformLayout();
            this.mnuEditor.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtEditor;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btnGreen;
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.Button btnColour;
        private System.Windows.Forms.ColorDialog dlgColor;
        private System.Windows.Forms.StatusStrip staPage;
        private System.Windows.Forms.ToolStripStatusLabel staColor;
        private System.Windows.Forms.Button btnForeColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripStatusLabel staForeColor;
        private System.Windows.Forms.MenuStrip mnuBar;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuColor;
        private System.Windows.Forms.ToolStripMenuItem mnuRedBg;
        private System.Windows.Forms.ToolStripMenuItem mnuBlueBg;
        private System.Windows.Forms.ToolStripMenuItem mnuGreenBg;
        private System.Windows.Forms.ToolStripMenuItem mnuBg;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuFg;
        private System.Windows.Forms.ContextMenuStrip mnuEditor;
        private System.Windows.Forms.ToolStripMenuItem mnuRed2;
        private System.Windows.Forms.ToolStripMenuItem mnuBlue2;
        private System.Windows.Forms.ToolStripMenuItem mnuGreen2;
        private System.Windows.Forms.ToolStripMenuItem mnuFormat;
        private System.Windows.Forms.ToolStripMenuItem mnuFont;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnuAlignLeft;
        private System.Windows.Forms.ToolStripMenuItem mnuAlignCenter;
        private System.Windows.Forms.ToolStripMenuItem mnuAlignRight;
        private System.Windows.Forms.FontDialog dlgFont;
        private System.Windows.Forms.ToolStripMenuItem mnuOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem mnuSave;
        private System.Windows.Forms.OpenFileDialog dlgOpen;
        private System.Windows.Forms.SaveFileDialog dlgSave;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toLeft;
        private System.Windows.Forms.ToolStripButton toCenter;
        private System.Windows.Forms.ToolStripButton toRight;
    }
}

