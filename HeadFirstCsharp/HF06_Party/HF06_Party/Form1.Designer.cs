namespace HF06_Party
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.healthyBox = new System.Windows.Forms.CheckBox();
            this.fancyBox = new System.Windows.Forms.CheckBox();
            this.costLabel = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.nudNumberOfPeople = new System.Windows.Forms.NumericUpDown();
            this.lblNumberOfPeople = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.birthdayCost = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tooLongLabel = new System.Windows.Forms.Label();
            this.cakeWriting = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFancyDecorationsBirthday = new System.Windows.Forms.CheckBox();
            this.nudNumberOfPeopleBirthday = new System.Windows.Forms.NumericUpDown();
            this.lblNumberOfPeopleBirthday = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfPeople)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfPeopleBirthday)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(567, 293);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.healthyBox);
            this.tabPage1.Controls.Add(this.fancyBox);
            this.tabPage1.Controls.Add(this.costLabel);
            this.tabPage1.Controls.Add(this.lblCost);
            this.tabPage1.Controls.Add(this.nudNumberOfPeople);
            this.tabPage1.Controls.Add(this.lblNumberOfPeople);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(559, 264);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dinner Party";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // healthyBox
            // 
            this.healthyBox.AutoSize = true;
            this.healthyBox.Location = new System.Drawing.Point(56, 157);
            this.healthyBox.Name = "healthyBox";
            this.healthyBox.Size = new System.Drawing.Size(158, 21);
            this.healthyBox.TabIndex = 11;
            this.healthyBox.Text = "Healthy Decorations";
            this.healthyBox.UseVisualStyleBackColor = true;
            this.healthyBox.CheckedChanged += new System.EventHandler(this.healthyBox_CheckedChanged);
            // 
            // fancyBox
            // 
            this.fancyBox.AutoSize = true;
            this.fancyBox.Checked = true;
            this.fancyBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fancyBox.Location = new System.Drawing.Point(56, 120);
            this.fancyBox.Name = "fancyBox";
            this.fancyBox.Size = new System.Drawing.Size(148, 21);
            this.fancyBox.TabIndex = 10;
            this.fancyBox.Text = "Fancy Decorations";
            this.fancyBox.UseVisualStyleBackColor = true;
            this.fancyBox.CheckedChanged += new System.EventHandler(this.fancyBox_CheckedChanged);
            // 
            // costLabel
            // 
            this.costLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.costLabel.Location = new System.Drawing.Point(130, 181);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(96, 29);
            this.costLabel.TabIndex = 9;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(53, 190);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(36, 17);
            this.lblCost.TabIndex = 8;
            this.lblCost.Text = "Cost";
            // 
            // nudNumberOfPeople
            // 
            this.nudNumberOfPeople.Location = new System.Drawing.Point(53, 78);
            this.nudNumberOfPeople.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudNumberOfPeople.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumberOfPeople.Name = "nudNumberOfPeople";
            this.nudNumberOfPeople.Size = new System.Drawing.Size(120, 22);
            this.nudNumberOfPeople.TabIndex = 7;
            this.nudNumberOfPeople.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudNumberOfPeople.ValueChanged += new System.EventHandler(this.nudNumberOfPeople_ValueChanged);
            // 
            // lblNumberOfPeople
            // 
            this.lblNumberOfPeople.AutoSize = true;
            this.lblNumberOfPeople.Location = new System.Drawing.Point(50, 44);
            this.lblNumberOfPeople.Name = "lblNumberOfPeople";
            this.lblNumberOfPeople.Size = new System.Drawing.Size(122, 17);
            this.lblNumberOfPeople.TabIndex = 6;
            this.lblNumberOfPeople.Text = "Number of People";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.birthdayCost);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.tooLongLabel);
            this.tabPage2.Controls.Add(this.cakeWriting);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.cbFancyDecorationsBirthday);
            this.tabPage2.Controls.Add(this.nudNumberOfPeopleBirthday);
            this.tabPage2.Controls.Add(this.lblNumberOfPeopleBirthday);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(559, 264);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Birthday Party";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // birthdayCost
            // 
            this.birthdayCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.birthdayCost.Location = new System.Drawing.Point(111, 214);
            this.birthdayCost.Name = "birthdayCost";
            this.birthdayCost.Size = new System.Drawing.Size(96, 29);
            this.birthdayCost.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Cost";
            // 
            // tooLongLabel
            // 
            this.tooLongLabel.AutoSize = true;
            this.tooLongLabel.BackColor = System.Drawing.Color.Red;
            this.tooLongLabel.Location = new System.Drawing.Point(137, 143);
            this.tooLongLabel.Name = "tooLongLabel";
            this.tooLongLabel.Size = new System.Drawing.Size(83, 17);
            this.tooLongLabel.TabIndex = 16;
            this.tooLongLabel.Text = "TOO LONG";
            // 
            // cakeWriting
            // 
            this.cakeWriting.Location = new System.Drawing.Point(34, 178);
            this.cakeWriting.Name = "cakeWriting";
            this.cakeWriting.Size = new System.Drawing.Size(151, 22);
            this.cakeWriting.TabIndex = 15;
            this.cakeWriting.Text = "Happy Birthday";
            this.cakeWriting.TextChanged += new System.EventHandler(this.cakeWriting_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Cake Writing";
            // 
            // cbFancyDecorationsBirthday
            // 
            this.cbFancyDecorationsBirthday.AutoSize = true;
            this.cbFancyDecorationsBirthday.Checked = true;
            this.cbFancyDecorationsBirthday.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbFancyDecorationsBirthday.Location = new System.Drawing.Point(37, 102);
            this.cbFancyDecorationsBirthday.Name = "cbFancyDecorationsBirthday";
            this.cbFancyDecorationsBirthday.Size = new System.Drawing.Size(148, 21);
            this.cbFancyDecorationsBirthday.TabIndex = 13;
            this.cbFancyDecorationsBirthday.Text = "Fancy Decorations";
            this.cbFancyDecorationsBirthday.UseVisualStyleBackColor = true;
            this.cbFancyDecorationsBirthday.CheckedChanged += new System.EventHandler(this.cbFancyDecorationsBirthday_CheckedChanged);
            // 
            // nudNumberOfPeopleBirthday
            // 
            this.nudNumberOfPeopleBirthday.Location = new System.Drawing.Point(34, 60);
            this.nudNumberOfPeopleBirthday.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudNumberOfPeopleBirthday.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumberOfPeopleBirthday.Name = "nudNumberOfPeopleBirthday";
            this.nudNumberOfPeopleBirthday.Size = new System.Drawing.Size(120, 22);
            this.nudNumberOfPeopleBirthday.TabIndex = 12;
            this.nudNumberOfPeopleBirthday.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudNumberOfPeopleBirthday.ValueChanged += new System.EventHandler(this.nudNumberOfPeopleBirthday_ValueChanged);
            // 
            // lblNumberOfPeopleBirthday
            // 
            this.lblNumberOfPeopleBirthday.AutoSize = true;
            this.lblNumberOfPeopleBirthday.Location = new System.Drawing.Point(31, 26);
            this.lblNumberOfPeopleBirthday.Name = "lblNumberOfPeopleBirthday";
            this.lblNumberOfPeopleBirthday.Size = new System.Drawing.Size(122, 17);
            this.lblNumberOfPeopleBirthday.TabIndex = 11;
            this.lblNumberOfPeopleBirthday.Text = "Number of People";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 293);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Party";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfPeople)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfPeopleBirthday)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox healthyBox;
        private System.Windows.Forms.CheckBox fancyBox;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.NumericUpDown nudNumberOfPeople;
        private System.Windows.Forms.Label lblNumberOfPeople;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label birthdayCost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label tooLongLabel;
        private System.Windows.Forms.TextBox cakeWriting;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbFancyDecorationsBirthday;
        private System.Windows.Forms.NumericUpDown nudNumberOfPeopleBirthday;
        private System.Windows.Forms.Label lblNumberOfPeopleBirthday;
    }
}

