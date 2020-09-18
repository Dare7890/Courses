namespace HF03_TalkerTester
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
            this.lblSay = new System.Windows.Forms.Label();
            this.lblTimes = new System.Windows.Forms.Label();
            this.tbText = new System.Windows.Forms.TextBox();
            this.nudTimes = new System.Windows.Forms.NumericUpDown();
            this.btnSpeak = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSay
            // 
            this.lblSay.AutoSize = true;
            this.lblSay.Location = new System.Drawing.Point(43, 47);
            this.lblSay.Name = "lblSay";
            this.lblSay.Size = new System.Drawing.Size(62, 17);
            this.lblSay.TabIndex = 0;
            this.lblSay.Text = "Say this:";
            // 
            // lblTimes
            // 
            this.lblTimes.AutoSize = true;
            this.lblTimes.Location = new System.Drawing.Point(43, 100);
            this.lblTimes.Name = "lblTimes";
            this.lblTimes.Size = new System.Drawing.Size(73, 17);
            this.lblTimes.TabIndex = 1;
            this.lblTimes.Text = "# of times:";
            // 
            // tbText
            // 
            this.tbText.Location = new System.Drawing.Point(178, 44);
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(238, 22);
            this.tbText.TabIndex = 2;
            this.tbText.Text = "Hello!";
            // 
            // nudTimes
            // 
            this.nudTimes.Location = new System.Drawing.Point(178, 98);
            this.nudTimes.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudTimes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTimes.Name = "nudTimes";
            this.nudTimes.Size = new System.Drawing.Size(90, 22);
            this.nudTimes.TabIndex = 3;
            this.nudTimes.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // btnSpeak
            // 
            this.btnSpeak.Location = new System.Drawing.Point(178, 144);
            this.btnSpeak.Name = "btnSpeak";
            this.btnSpeak.Size = new System.Drawing.Size(162, 23);
            this.btnSpeak.TabIndex = 4;
            this.btnSpeak.Text = "Speak to me!";
            this.btnSpeak.UseVisualStyleBackColor = true;
            this.btnSpeak.Click += new System.EventHandler(this.btnSpeak_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 188);
            this.Controls.Add(this.btnSpeak);
            this.Controls.Add(this.nudTimes);
            this.Controls.Add(this.tbText);
            this.Controls.Add(this.lblTimes);
            this.Controls.Add(this.lblSay);
            this.Name = "Form1";
            this.Text = "Talker Tester";
            ((System.ComponentModel.ISupportInitialize)(this.nudTimes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSay;
        private System.Windows.Forms.Label lblTimes;
        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.NumericUpDown nudTimes;
        private System.Windows.Forms.Button btnSpeak;
    }
}

