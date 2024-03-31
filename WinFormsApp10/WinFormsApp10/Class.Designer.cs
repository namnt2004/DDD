namespace WinFormsApp10
{
    partial class Class
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
            btnadd = new Button();
            cbbteacher = new ComboBox();
            label2 = new Label();
            cbbsubject = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btncancel
            // 
            btncancel.Font = new Font("SimSun", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btncancel.Location = new Point(495, 169);
            btncancel.Name = "btncancel";
            btncancel.Size = new Size(112, 34);
            btncancel.TabIndex = 11;
            btncancel.Text = "Cancel";
            btncancel.UseVisualStyleBackColor = true;
            btncancel.Click += btncancel_Click_1;
            // 
            // btnadd
            // 
            btnadd.Font = new Font("SimSun", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnadd.Location = new Point(163, 169);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(112, 34);
            btnadd.TabIndex = 10;
            btnadd.Text = "Add";
            btnadd.UseVisualStyleBackColor = true;
            // 
            // cbbteacher
            // 
            cbbteacher.FormattingEnabled = true;
            cbbteacher.Location = new Point(151, 94);
            cbbteacher.Name = "cbbteacher";
            cbbteacher.Size = new Size(524, 33);
            cbbteacher.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SimSun", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(47, 102);
            label2.Name = "label2";
            label2.Size = new Size(71, 18);
            label2.TabIndex = 8;
            label2.Text = "Teacher";
            // 
            // cbbsubject
            // 
            cbbsubject.FormattingEnabled = true;
            cbbsubject.Location = new Point(151, 14);
            cbbsubject.Name = "cbbsubject";
            cbbsubject.Size = new Size(524, 33);
            cbbsubject.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(47, 22);
            label1.Name = "label1";
            label1.Size = new Size(71, 18);
            label1.TabIndex = 6;
            label1.Text = "Subject";
            // 
            // Class
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(832, 216);
            Controls.Add(btncancel);
            Controls.Add(btnadd);
            Controls.Add(cbbteacher);
            Controls.Add(label2);
            Controls.Add(cbbsubject);
            Controls.Add(label1);
            Name = "Class";
            Text = "Class";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btncancel;
        private Button btnadd;
        private ComboBox cbbteacher;
        private Label label2;
        private ComboBox cbbsubject;
        private Label label1;
    }
}