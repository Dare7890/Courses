namespace HF12_Finalizer
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
            this.btnCln1 = new System.Windows.Forms.Button();
            this.btnCln2 = new System.Windows.Forms.Button();
            this.btnGC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCln1
            // 
            this.btnCln1.Location = new System.Drawing.Point(35, 25);
            this.btnCln1.Name = "btnCln1";
            this.btnCln1.Size = new System.Drawing.Size(75, 23);
            this.btnCln1.TabIndex = 0;
            this.btnCln1.Text = "Clone #1";
            this.btnCln1.UseVisualStyleBackColor = true;
            this.btnCln1.Click += new System.EventHandler(this.btnCln1_Click);
            // 
            // btnCln2
            // 
            this.btnCln2.Location = new System.Drawing.Point(143, 25);
            this.btnCln2.Name = "btnCln2";
            this.btnCln2.Size = new System.Drawing.Size(75, 23);
            this.btnCln2.TabIndex = 1;
            this.btnCln2.Text = "Clone #2";
            this.btnCln2.UseVisualStyleBackColor = true;
            this.btnCln2.Click += new System.EventHandler(this.btnCln2_Click);
            // 
            // btnGC
            // 
            this.btnGC.Location = new System.Drawing.Point(247, 25);
            this.btnGC.Name = "btnGC";
            this.btnGC.Size = new System.Drawing.Size(75, 23);
            this.btnGC.TabIndex = 2;
            this.btnGC.Text = "GC";
            this.btnGC.UseVisualStyleBackColor = true;
            this.btnGC.Click += new System.EventHandler(this.btnGC_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 80);
            this.Controls.Add(this.btnGC);
            this.Controls.Add(this.btnCln2);
            this.Controls.Add(this.btnCln1);
            this.Name = "Form1";
            this.Text = "Clones";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCln1;
        private System.Windows.Forms.Button btnCln2;
        private System.Windows.Forms.Button btnGC;
    }
}

