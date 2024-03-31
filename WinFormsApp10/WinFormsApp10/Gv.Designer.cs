namespace WinFormsApp10
{
    partial class Gv
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
            btncancel = new Button();
            btnsave = new Button();
            mtbngaysinh = new MaskedTextBox();
            rbtnu = new RadioButton();
            rbtnam = new RadioButton();
            txtemail = new TextBox();
            txtphone = new TextBox();
            txtname = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btncancel
            // 
            btncancel.Font = new Font("SimSun", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btncancel.Location = new Point(317, 430);
            btncancel.Name = "btncancel";
            btncancel.Size = new Size(112, 34);
            btncancel.TabIndex = 25;
            btncancel.Text = "Cancel";
            btncancel.UseVisualStyleBackColor = true;
            btncancel.Click += btncancel_Click;
            // 
            // btnsave
            // 
            btnsave.Font = new Font("SimSun", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnsave.Location = new Point(108, 430);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(112, 34);
            btnsave.TabIndex = 24;
            btnsave.Text = "Save";
            btnsave.UseVisualStyleBackColor = true;
            // 
            // mtbngaysinh
            // 
            mtbngaysinh.Location = new Point(136, 111);
            mtbngaysinh.Mask = "00/00/0000";
            mtbngaysinh.Name = "mtbngaysinh";
            mtbngaysinh.Size = new Size(284, 31);
            mtbngaysinh.TabIndex = 23;
            mtbngaysinh.ValidatingType = typeof(DateTime);
            // 
            // rbtnu
            // 
            rbtnu.AutoSize = true;
            rbtnu.Font = new Font("SimSun", 9F, FontStyle.Regular, GraphicsUnit.Point);
            rbtnu.ForeColor = SystemColors.ButtonFace;
            rbtnu.Location = new Point(317, 202);
            rbtnu.Name = "rbtnu";
            rbtnu.Size = new Size(87, 22);
            rbtnu.TabIndex = 22;
            rbtnu.TabStop = true;
            rbtnu.Text = "Famele";
            rbtnu.UseVisualStyleBackColor = true;
            // 
            // rbtnam
            // 
            rbtnam.AutoSize = true;
            rbtnam.Font = new Font("SimSun", 9F, FontStyle.Regular, GraphicsUnit.Point);
            rbtnam.ForeColor = SystemColors.ButtonFace;
            rbtnam.Location = new Point(136, 204);
            rbtnam.Name = "rbtnam";
            rbtnam.Size = new Size(69, 22);
            rbtnam.TabIndex = 21;
            rbtnam.TabStop = true;
            rbtnam.Text = "Male";
            rbtnam.UseVisualStyleBackColor = true;
            // 
            // txtemail
            // 
            txtemail.Location = new Point(136, 348);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(284, 31);
            txtemail.TabIndex = 20;
            // 
            // txtphone
            // 
            txtphone.Location = new Point(136, 274);
            txtphone.Name = "txtphone";
            txtphone.Size = new Size(284, 31);
            txtphone.TabIndex = 19;
            // 
            // txtname
            // 
            txtname.Location = new Point(136, 22);
            txtname.Name = "txtname";
            txtname.Size = new Size(284, 31);
            txtname.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("SimSun", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(14, 361);
            label5.Name = "label5";
            label5.Size = new Size(53, 18);
            label5.TabIndex = 17;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("SimSun", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(14, 274);
            label4.Name = "label4";
            label4.Size = new Size(53, 18);
            label4.TabIndex = 16;
            label4.Text = "Phone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SimSun", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(14, 206);
            label3.Name = "label3";
            label3.Size = new Size(35, 18);
            label3.TabIndex = 15;
            label3.Text = "Sex";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SimSun", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(14, 111);
            label2.Name = "label2";
            label2.Size = new Size(53, 18);
            label2.TabIndex = 14;
            label2.Text = "Birth";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(14, 30);
            label1.Name = "label1";
            label1.Size = new Size(44, 18);
            label1.TabIndex = 13;
            label1.Text = "Name";
            // 
            // Gv
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(458, 487);
            Controls.Add(btncancel);
            Controls.Add(btnsave);
            Controls.Add(mtbngaysinh);
            Controls.Add(rbtnu);
            Controls.Add(rbtnam);
            Controls.Add(txtemail);
            Controls.Add(txtphone);
            Controls.Add(txtname);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Gv";
            Text = "Gv";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btncancel;
        private Button btnsave;
        private MaskedTextBox mtbngaysinh;
        private RadioButton rbtnu;
        private RadioButton rbtnam;
        private TextBox txtemail;
        private TextBox txtphone;
        private TextBox txtname;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}