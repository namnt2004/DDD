namespace WinFormsApp10
{
    partial class Subject
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
            txttenmh = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btncancel
            // 
            btncancel.Font = new Font("SimSun", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btncancel.Location = new Point(774, 57);
            btncancel.Name = "btncancel";
            btncancel.Size = new Size(112, 34);
            btncancel.TabIndex = 7;
            btncancel.Text = "Cancel";
            btncancel.UseVisualStyleBackColor = true;
            btncancel.Click += btncancel_Click_1;
            // 
            // btnsave
            // 
            btnsave.Font = new Font("SimSun", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnsave.Location = new Point(588, 57);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(112, 34);
            btnsave.TabIndex = 6;
            btnsave.Text = "Save";
            btnsave.UseVisualStyleBackColor = true;
            btnsave.Click += btnsave_Click_1;
            // 
            // txttenmh
            // 
            txttenmh.Location = new Point(185, 60);
            txttenmh.Name = "txttenmh";
            txttenmh.Size = new Size(340, 31);
            txttenmh.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(48, 66);
            label1.Name = "label1";
            label1.Size = new Size(62, 18);
            label1.TabIndex = 4;
            label1.Text = "Search";
            // 
            // Subject
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(935, 149);
            Controls.Add(btncancel);
            Controls.Add(btnsave);
            Controls.Add(txttenmh);
            Controls.Add(label1);
            Name = "Subject";
            Text = "Subject";
            Load += Subject_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btncancel;
        private Button btnsave;
        private TextBox txttenmh;
        private Label label1;
    }
}