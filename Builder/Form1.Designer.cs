namespace Builder
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
            this.cmbRAM = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbHDD = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTouch = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbKeyboard = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbMouse = new System.Windows.Forms.ComboBox();
            this.btnDesktop = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnLaptop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbRAM
            // 
            this.cmbRAM.FormattingEnabled = true;
            this.cmbRAM.Items.AddRange(new object[] {
            "8GB",
            "16GB",
            "32GB"});
            this.cmbRAM.Location = new System.Drawing.Point(57, 47);
            this.cmbRAM.Name = "cmbRAM";
            this.cmbRAM.Size = new System.Drawing.Size(121, 21);
            this.cmbRAM.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "RAM";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "HDD";
            // 
            // cmbHDD
            // 
            this.cmbHDD.FormattingEnabled = true;
            this.cmbHDD.Items.AddRange(new object[] {
            "500GB",
            "1TB"});
            this.cmbHDD.Location = new System.Drawing.Point(207, 47);
            this.cmbHDD.Name = "cmbHDD";
            this.cmbHDD.Size = new System.Drawing.Size(121, 21);
            this.cmbHDD.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(378, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "TouchScreen";
            // 
            // cmbTouch
            // 
            this.cmbTouch.FormattingEnabled = true;
            this.cmbTouch.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.cmbTouch.Location = new System.Drawing.Point(369, 47);
            this.cmbTouch.Name = "cmbTouch";
            this.cmbTouch.Size = new System.Drawing.Size(121, 21);
            this.cmbTouch.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Keyboard";
            // 
            // cmbKeyboard
            // 
            this.cmbKeyboard.FormattingEnabled = true;
            this.cmbKeyboard.Items.AddRange(new object[] {
            "Wireless",
            "Regular-USB"});
            this.cmbKeyboard.Location = new System.Drawing.Point(207, 116);
            this.cmbKeyboard.Name = "cmbKeyboard";
            this.cmbKeyboard.Size = new System.Drawing.Size(121, 21);
            this.cmbKeyboard.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Mouse";
            // 
            // cmbMouse
            // 
            this.cmbMouse.FormattingEnabled = true;
            this.cmbMouse.Items.AddRange(new object[] {
            "Wireless",
            "Regular-USB"});
            this.cmbMouse.Location = new System.Drawing.Point(57, 116);
            this.cmbMouse.Name = "cmbMouse";
            this.cmbMouse.Size = new System.Drawing.Size(121, 21);
            this.cmbMouse.TabIndex = 8;
            // 
            // btnDesktop
            // 
            this.btnDesktop.Location = new System.Drawing.Point(57, 182);
            this.btnDesktop.Name = "btnDesktop";
            this.btnDesktop.Size = new System.Drawing.Size(121, 32);
            this.btnDesktop.TabIndex = 10;
            this.btnDesktop.Text = "Build desktop";
            this.btnDesktop.UseVisualStyleBackColor = true;
            this.btnDesktop.Click += new System.EventHandler(this.btnDesktop_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(57, 245);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(433, 20);
            this.txtResult.TabIndex = 11;
            // 
            // btnLaptop
            // 
            this.btnLaptop.Location = new System.Drawing.Point(207, 182);
            this.btnLaptop.Name = "btnLaptop";
            this.btnLaptop.Size = new System.Drawing.Size(121, 32);
            this.btnLaptop.TabIndex = 12;
            this.btnLaptop.Text = "Build laptop";
            this.btnLaptop.UseVisualStyleBackColor = true;
            this.btnLaptop.Click += new System.EventHandler(this.btnLaptop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLaptop);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnDesktop);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbMouse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbKeyboard);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbTouch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbHDD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbRAM);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbRAM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbHDD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTouch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbKeyboard;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbMouse;
        private System.Windows.Forms.Button btnDesktop;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnLaptop;
    }
}

