namespace Example4
{
    partial class ExtendedCounter
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
            this.btnMinuse = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.lblCounter = new System.Windows.Forms.Label();
            this.txtStep = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtStep)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMinuse
            // 
            this.btnMinuse.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinuse.Location = new System.Drawing.Point(515, 304);
            this.btnMinuse.Name = "btnMinuse";
            this.btnMinuse.Size = new System.Drawing.Size(156, 59);
            this.btnMinuse.TabIndex = 5;
            this.btnMinuse.Text = "-";
            this.btnMinuse.UseVisualStyleBackColor = true;
            this.btnMinuse.Click += new System.EventHandler(this.btnMinuse_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.Location = new System.Drawing.Point(130, 304);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(156, 59);
            this.btnPlus.TabIndex = 4;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // lblCounter
            // 
            this.lblCounter.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblCounter.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounter.Location = new System.Drawing.Point(343, 87);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(205, 98);
            this.lblCounter.TabIndex = 3;
            this.lblCounter.Text = "0";
            this.lblCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtStep
            // 
            this.txtStep.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStep.Location = new System.Drawing.Point(308, 331);
            this.txtStep.Name = "txtStep";
            this.txtStep.Size = new System.Drawing.Size(188, 37);
            this.txtStep.TabIndex = 6;
            this.txtStep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtStep.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(303, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "step";
            // 
            // ExtendedCounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStep);
            this.Controls.Add(this.btnMinuse);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.lblCounter);
            this.Name = "ExtendedCounter";
            this.Text = "ExtendedCounter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ExtendedCounter_FormClosing);
            this.Enter += new System.EventHandler(this.ExtendedCounter_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.txtStep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMinuse;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Label lblCounter;
        private System.Windows.Forms.NumericUpDown txtStep;
        private System.Windows.Forms.Label label1;
    }
}