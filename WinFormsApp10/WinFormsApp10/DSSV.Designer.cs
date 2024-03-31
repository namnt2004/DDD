namespace WinFormsApp10
{
    partial class DSSV
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
            dgvdssv = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvdssv).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SimSun", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(295, 17);
            label2.Name = "label2";
            label2.Size = new Size(223, 33);
            label2.TabIndex = 12;
            label2.Text = "List Students";
            // 
            // btnadd
            // 
            btnadd.Anchor = AnchorStyles.Top;
            btnadd.Font = new Font("SimSun", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnadd.Location = new Point(475, 155);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(112, 34);
            btnadd.TabIndex = 11;
            btnadd.Text = "Add";
            btnadd.UseVisualStyleBackColor = true;
            btnadd.Click += btnadd_Click_1;
            // 
            // btnsearch
            // 
            btnsearch.Anchor = AnchorStyles.Top;
            btnsearch.Font = new Font("SimSun", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnsearch.Location = new Point(252, 155);
            btnsearch.Name = "btnsearch";
            btnsearch.Size = new Size(112, 34);
            btnsearch.TabIndex = 10;
            btnsearch.Text = "Search";
            btnsearch.UseVisualStyleBackColor = true;
            btnsearch.Click += btnsearch_Click_1;
            // 
            // txtsearch
            // 
            txtsearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtsearch.Location = new Point(192, 81);
            txtsearch.Name = "txtsearch";
            txtsearch.Size = new Size(460, 31);
            txtsearch.TabIndex = 9;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(60, 89);
            label1.Name = "label1";
            label1.Size = new Size(62, 18);
            label1.TabIndex = 8;
            label1.Text = "Search";
            // 
            // dgvdssv
            // 
            dgvdssv.AllowUserToAddRows = false;
            dgvdssv.AllowUserToDeleteRows = false;
            dgvdssv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvdssv.BackgroundColor = SystemColors.ActiveCaption;
            dgvdssv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdssv.Dock = DockStyle.Bottom;
            dgvdssv.Location = new Point(0, 214);
            dgvdssv.MultiSelect = false;
            dgvdssv.Name = "dgvdssv";
            dgvdssv.ReadOnly = true;
            dgvdssv.RowHeadersWidth = 62;
            dgvdssv.RowTemplate.Height = 33;
            dgvdssv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvdssv.Size = new Size(852, 289);
            dgvdssv.TabIndex = 7;
            dgvdssv.CellDoubleClick += dgvdssv_CellDoubleClick;
            // 
            // DSSV
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(852, 503);
            Controls.Add(label2);
            Controls.Add(btnadd);
            Controls.Add(btnsearch);
            Controls.Add(txtsearch);
            Controls.Add(label1);
            Controls.Add(dgvdssv);
            Name = "DSSV";
            Text = "DSSV";
            Load += DSSV_Load;
            ((System.ComponentModel.ISupportInitialize)dgvdssv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button btnadd;
        private Button btnsearch;
        private TextBox txtsearch;
        private Label label1;
        private DataGridView dgvdssv;
    }
}