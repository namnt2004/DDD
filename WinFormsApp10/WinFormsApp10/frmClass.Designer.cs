namespace WinFormsApp10
{
    partial class frmClass
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
            label1 = new Label();
            btnadd = new Button();
            btnsearch = new Button();
            txtsearch = new TextBox();
            label2 = new Label();
            dgvclass = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvclass).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(305, 21);
            label1.Name = "label1";
            label1.Size = new Size(207, 33);
            label1.TabIndex = 21;
            label1.Text = "List Classes";
            // 
            // btnadd
            // 
            btnadd.Anchor = AnchorStyles.Top;
            btnadd.Font = new Font("SimSun", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnadd.Location = new Point(471, 146);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(112, 34);
            btnadd.TabIndex = 19;
            btnadd.Text = "Add";
            btnadd.UseVisualStyleBackColor = true;
            // 
            // btnsearch
            // 
            btnsearch.Anchor = AnchorStyles.Top;
            btnsearch.Font = new Font("SimSun", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnsearch.Location = new Point(248, 146);
            btnsearch.Name = "btnsearch";
            btnsearch.Size = new Size(112, 34);
            btnsearch.TabIndex = 18;
            btnsearch.Text = "Search";
            btnsearch.UseVisualStyleBackColor = true;
            btnsearch.Click += btnsearch_Click;
            // 
            // txtsearch
            // 
            txtsearch.Anchor = AnchorStyles.Top;
            txtsearch.Location = new Point(193, 85);
            txtsearch.Name = "txtsearch";
            txtsearch.Size = new Size(440, 31);
            txtsearch.TabIndex = 17;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("SimSun", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(56, 88);
            label2.Name = "label2";
            label2.Size = new Size(62, 18);
            label2.TabIndex = 16;
            label2.Text = "Search";
            // 
            // dgvclass
            // 
            dgvclass.AllowUserToAddRows = false;
            dgvclass.AllowUserToDeleteRows = false;
            dgvclass.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvclass.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvclass.Dock = DockStyle.Bottom;
            dgvclass.Location = new Point(0, 201);
            dgvclass.MultiSelect = false;
            dgvclass.Name = "dgvclass";
            dgvclass.ReadOnly = true;
            dgvclass.RowHeadersWidth = 62;
            dgvclass.RowTemplate.Height = 33;
            dgvclass.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvclass.Size = new Size(914, 249);
            dgvclass.TabIndex = 20;
            // 
            // frmClass
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(914, 450);
            Controls.Add(label1);
            Controls.Add(btnadd);
            Controls.Add(btnsearch);
            Controls.Add(txtsearch);
            Controls.Add(label2);
            Controls.Add(dgvclass);
            Name = "frmClass";
            Text = "frmClass";
            Load += frmClass_Load;
            ((System.ComponentModel.ISupportInitialize)dgvclass).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnadd;
        private Button btnsearch;
        private TextBox txtsearch;
        private Label label2;
        private DataGridView dgvclass;
    }
}