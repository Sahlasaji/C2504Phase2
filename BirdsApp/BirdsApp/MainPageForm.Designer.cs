﻿namespace BirdsApp
{
    partial class MainPageForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuPeacock = new System.Windows.Forms.ToolStripMenuItem();
            this.duckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPeacock,
            this.duckToolStripMenuItem,
            this.crowToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuPeacock
            // 
            this.mnuPeacock.Name = "mnuPeacock";
            this.mnuPeacock.Size = new System.Drawing.Size(93, 29);
            this.mnuPeacock.Text = "peacock";
            this.mnuPeacock.Click += new System.EventHandler(this.mnuPeacock_Click);
            // 
            // duckToolStripMenuItem
            // 
            this.duckToolStripMenuItem.Name = "duckToolStripMenuItem";
            this.duckToolStripMenuItem.Size = new System.Drawing.Size(66, 29);
            this.duckToolStripMenuItem.Text = "duck";
            this.duckToolStripMenuItem.Click += new System.EventHandler(this.duckToolStripMenuItem_Click);
            // 
            // crowToolStripMenuItem
            // 
            this.crowToolStripMenuItem.Name = "crowToolStripMenuItem";
            this.crowToolStripMenuItem.Size = new System.Drawing.Size(66, 29);
            this.crowToolStripMenuItem.Text = "crow";
            this.crowToolStripMenuItem.Click += new System.EventHandler(this.crowToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // MainPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainPageForm";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuPeacock;
        private System.Windows.Forms.ToolStripMenuItem duckToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crowToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

