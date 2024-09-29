namespace Example4
{
    partial class CounterApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CounterApp));
            this.mnuBar = new System.Windows.Forms.MenuStrip();
            this.mnuSimpleContainer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExtendedCounter = new System.Windows.Forms.ToolStripMenuItem();
            this.stsBar = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.mnuBar.SuspendLayout();
            this.stsBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuBar
            // 
            this.mnuBar.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.mnuBar.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mnuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSimpleContainer,
            this.mnuExtendedCounter});
            this.mnuBar.Location = new System.Drawing.Point(0, 0);
            this.mnuBar.Name = "mnuBar";
            this.mnuBar.Padding = new System.Windows.Forms.Padding(15, 4, 0, 4);
            this.mnuBar.Size = new System.Drawing.Size(1333, 37);
            this.mnuBar.TabIndex = 0;
            this.mnuBar.Text = "menuStrip1";
            // 
            // mnuSimpleContainer
            // 
            this.mnuSimpleContainer.Name = "mnuSimpleContainer";
            this.mnuSimpleContainer.Size = new System.Drawing.Size(150, 29);
            this.mnuSimpleContainer.Text = "&Simple Counter";
            this.mnuSimpleContainer.Click += new System.EventHandler(this.mnuSimpleContainer_Click);
            // 
            // mnuExtendedCounter
            // 
            this.mnuExtendedCounter.Name = "mnuExtendedCounter";
            this.mnuExtendedCounter.Size = new System.Drawing.Size(169, 29);
            this.mnuExtendedCounter.Text = "&Extended Counter";
            this.mnuExtendedCounter.Click += new System.EventHandler(this.mnuExtendedCounter_Click);
            // 
            // stsBar
            // 
            this.stsBar.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.stsBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.stsBar.Location = new System.Drawing.Point(0, 620);
            this.stsBar.Name = "stsBar";
            this.stsBar.Padding = new System.Windows.Forms.Padding(2, 0, 23, 0);
            this.stsBar.Size = new System.Drawing.Size(1333, 32);
            this.stsBar.TabIndex = 1;
            this.stsBar.Text = "stsBar";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(85, 25);
            this.lblStatus.Text = "Welcome";
            // 
            // CounterApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 652);
            this.Controls.Add(this.stsBar);
            this.Controls.Add(this.mnuBar);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuBar;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "CounterApp";
            this.Text = "CounterApp";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mnuBar.ResumeLayout(false);
            this.mnuBar.PerformLayout();
            this.stsBar.ResumeLayout(false);
            this.stsBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuBar;
        private System.Windows.Forms.ToolStripMenuItem mnuSimpleContainer;
        private System.Windows.Forms.ToolStripMenuItem mnuExtendedCounter;
        private System.Windows.Forms.StatusStrip stsBar;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
    }
}

