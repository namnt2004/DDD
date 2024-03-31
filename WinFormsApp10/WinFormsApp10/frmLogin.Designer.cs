namespace WinFormsApp10
{
    partial class frmLogin
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
            btnexit = new Button();
            btnlogin = new Button();
            txtpass = new TextBox();
            txtusername = new TextBox();
            cbbtype = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnexit
            // 
            btnexit.Font = new Font("SimSun", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnexit.Location = new Point(249, 270);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(112, 34);
            btnexit.TabIndex = 15;
            btnexit.Text = "Exit";
            btnexit.UseVisualStyleBackColor = true;
            btnexit.Click += btnexit_Click_1;
            // 
            // btnlogin
            // 
            btnlogin.Font = new Font("SimSun", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnlogin.Location = new Point(39, 270);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(112, 34);
            btnlogin.TabIndex = 14;
            btnlogin.Text = "Login";
            btnlogin.UseVisualStyleBackColor = true;
            btnlogin.Click += btnlogin_Click_1;
            // 
            // txtpass
            // 
            txtpass.Location = new Point(162, 179);
            txtpass.Name = "txtpass";
            txtpass.PasswordChar = '*';
            txtpass.Size = new Size(182, 31);
            txtpass.TabIndex = 13;
            // 
            // txtusername
            // 
            txtusername.Location = new Point(162, 109);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(182, 31);
            txtusername.TabIndex = 12;
            // 
            // cbbtype
            // 
            cbbtype.FormattingEnabled = true;
            cbbtype.Items.AddRange(new object[] { "Administrators", "Teacher", "Student" });
            cbbtype.Location = new Point(162, 42);
            cbbtype.Name = "cbbtype";
            cbbtype.Size = new Size(182, 33);
            cbbtype.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SimSun", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(23, 179);
            label3.Name = "label3";
            label3.Size = new Size(80, 18);
            label3.TabIndex = 10;
            label3.Text = "PassWord";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SimSun", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(23, 109);
            label2.Name = "label2";
            label2.Size = new Size(89, 18);
            label2.TabIndex = 9;
            label2.Text = "User Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(12, 50);
            label1.Name = "label1";
            label1.Size = new Size(125, 18);
            label1.TabIndex = 8;
            label1.Text = "Account Type:";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(377, 347);
            Controls.Add(btnexit);
            Controls.Add(btnlogin);
            Controls.Add(txtpass);
            Controls.Add(txtusername);
            Controls.Add(cbbtype);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmLogin";
            Text = "frmLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnexit;
        private Button btnlogin;
        private TextBox txtpass;
        private TextBox txtusername;
        private ComboBox cbbtype;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}