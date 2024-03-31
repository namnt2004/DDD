namespace WinFormsApp10
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btncancel = new Button();
            btnsave = new Button();
            rbtfamele = new RadioButton();
            rbtmale = new RadioButton();
            txtphone = new TextBox();
            txtemail = new TextBox();
            txtname = new TextBox();
            mtbbirth = new MaskedTextBox();
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
            btncancel.Location = new Point(347, 460);
            btncancel.Name = "btncancel";
            btncancel.Size = new Size(112, 34);
            btncancel.TabIndex = 26;
            btncancel.Text = "Cancel";
            btncancel.UseVisualStyleBackColor = true;
            btncancel.Click += btncancel_Click;
            // 
            // btnsave
            // 
            btnsave.Font = new Font("SimSun", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnsave.Location = new Point(132, 460);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(112, 34);
            btnsave.TabIndex = 25;
            btnsave.Text = "Save";
            btnsave.UseVisualStyleBackColor = true;
            btnsave.Click += btnsave_Click;
            // 
            // rbtfamele
            // 
            rbtfamele.AutoSize = true;
            rbtfamele.Font = new Font("SimSun", 9F, FontStyle.Regular, GraphicsUnit.Point);
            rbtfamele.ForeColor = SystemColors.ButtonFace;
            rbtfamele.Location = new Point(338, 194);
            rbtfamele.Name = "rbtfamele";
            rbtfamele.Size = new Size(87, 22);
            rbtfamele.TabIndex = 24;
            rbtfamele.TabStop = true;
            rbtfamele.Text = "Famele";
            rbtfamele.UseVisualStyleBackColor = true;
            // 
            // rbtmale
            // 
            rbtmale.AutoSize = true;
            rbtmale.Font = new Font("SimSun", 9F, FontStyle.Regular, GraphicsUnit.Point);
            rbtmale.ForeColor = SystemColors.ButtonFace;
            rbtmale.Location = new Point(175, 194);
            rbtmale.Name = "rbtmale";
            rbtmale.Size = new Size(69, 22);
            rbtmale.TabIndex = 23;
            rbtmale.TabStop = true;
            rbtmale.Text = "Male";
            rbtmale.UseVisualStyleBackColor = true;
            // 
            // txtphone
            // 
            txtphone.Location = new Point(189, 357);
            txtphone.Name = "txtphone";
            txtphone.Size = new Size(223, 31);
            txtphone.TabIndex = 22;
            // 
            // txtemail
            // 
            txtemail.Location = new Point(189, 267);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(223, 31);
            txtemail.TabIndex = 21;
            // 
            // txtname
            // 
            txtname.Location = new Point(189, 26);
            txtname.Name = "txtname";
            txtname.Size = new Size(223, 31);
            txtname.TabIndex = 20;
            // 
            // mtbbirth
            // 
            mtbbirth.Location = new Point(189, 106);
            mtbbirth.Mask = "00/00/0000";
            mtbbirth.Name = "mtbbirth";
            mtbbirth.Size = new Size(223, 31);
            mtbbirth.TabIndex = 19;
            mtbbirth.ValidatingType = typeof(DateTime);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("SimSun", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(50, 357);
            label5.Name = "label5";
            label5.Size = new Size(53, 18);
            label5.TabIndex = 18;
            label5.Text = "Phone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("SimSun", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(50, 270);
            label4.Name = "label4";
            label4.Size = new Size(53, 18);
            label4.TabIndex = 17;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SimSun", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(56, 194);
            label3.Name = "label3";
            label3.Size = new Size(35, 18);
            label3.TabIndex = 16;
            label3.Text = "Sex";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SimSun", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(56, 106);
            label2.Name = "label2";
            label2.Size = new Size(53, 18);
            label2.TabIndex = 15;
            label2.Text = "Birth";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(60, 34);
            label1.Name = "label1";
            label1.Size = new Size(44, 18);
            label1.TabIndex = 14;
            label1.Text = "Name";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(551, 543);
            Controls.Add(btncancel);
            Controls.Add(btnsave);
            Controls.Add(rbtfamele);
            Controls.Add(rbtmale);
            Controls.Add(txtphone);
            Controls.Add(txtemail);
            Controls.Add(txtname);
            Controls.Add(mtbbirth);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "frmStudent";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btncancel;
        private Button btnsave;
        private RadioButton rbtfamele;
        private RadioButton rbtmale;
        private TextBox txtphone;
        private TextBox txtemail;
        private TextBox txtname;
        private MaskedTextBox mtbbirth;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}