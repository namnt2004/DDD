namespace WinFormsApp10
{
    partial class DSMH
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
            label2 = new Label();
            btnadd = new Button();
            btnsearch = new Button();
            txtsearch = new TextBox();
            label1 = new Label();
            dgvDSMH = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDSMH).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SimSun", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(289, 12);
            label2.Name = "label2";
            label2.Size = new Size(180, 28);
            label2.TabIndex = 14;
            label2.Text = "List Subject";
            // 
            // btnadd
            // 
            btnadd.Font = new Font("SimSun", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnadd.Location = new Point(477, 138);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(112, 34);
            btnadd.TabIndex = 13;
            btnadd.Text = "Add";
            btnadd.UseVisualStyleBackColor = true;
            btnadd.Click += btnadd_Click_1;
            // 
            // btnsearch
            // 
            btnsearch.Font = new Font("SimSun", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnsearch.Location = new Point(203, 138);
            btnsearch.Name = "btnsearch";
            btnsearch.Size = new Size(112, 34);
            btnsearch.TabIndex = 12;
            btnsearch.Text = "Search";
            btnsearch.UseVisualStyleBackColor = true;
            btnsearch.Click += btnsearch_Click_1;
            // 
            // txtsearch
            // 
            txtsearch.Location = new Point(165, 66);
            txtsearch.Name = "txtsearch";
            txtsearch.Size = new Size(496, 31);
            txtsearch.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(71, 74);
            label1.Name = "label1";
            label1.Size = new Size(62, 18);
            label1.TabIndex = 10;
            label1.Text = "Search";
            // 
            // dgvDSMH
            // 
            dgvDSMH.AllowUserToAddRows = false;
            dgvDSMH.AllowUserToDeleteRows = false;
            dgvDSMH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDSMH.BackgroundColor = SystemColors.ActiveCaption;
            dgvDSMH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDSMH.Dock = DockStyle.Bottom;
            dgvDSMH.Location = new Point(0, 192);
            dgvDSMH.Name = "dgvDSMH";
            dgvDSMH.ReadOnly = true;
            dgvDSMH.RowHeadersWidth = 62;
            dgvDSMH.RowTemplate.Height = 33;
            dgvDSMH.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDSMH.Size = new Size(800, 258);
            dgvDSMH.TabIndex = 9;
            dgvDSMH.CellDoubleClick += dgvDSMH_CellDoubleClick_1;
            // 
            // DSMH
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(btnadd);
            Controls.Add(btnsearch);
            Controls.Add(txtsearch);
            Controls.Add(label1);
            Controls.Add(dgvDSMH);
            Name = "DSMH";
            Text = "DSMH";
            Load += DSMH_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvDSMH).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button btnadd;
        private Button btnsearch;
        private TextBox txtsearch;
        private Label label1;
        private DataGridView dgvDSMH;
    }
}