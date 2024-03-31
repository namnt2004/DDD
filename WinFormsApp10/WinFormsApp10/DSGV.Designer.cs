namespace WinFormsApp10
{
    partial class DSGV
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
            button2 = new Button();
            btnsearch = new Button();
            txtsearch = new TextBox();
            label1 = new Label();
            dgvdsgv = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvdsgv).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SimSun", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(263, 9);
            label2.Name = "label2";
            label2.Size = new Size(223, 33);
            label2.TabIndex = 12;
            label2.Text = "List Teachers";
            label2.Click += label2_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top;
            button2.Font = new Font("SimSun", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(449, 129);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 11;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // btnsearch
            // 
            btnsearch.Anchor = AnchorStyles.Top;
            btnsearch.Font = new Font("SimSun", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnsearch.Location = new Point(226, 129);
            btnsearch.Name = "btnsearch";
            btnsearch.Size = new Size(112, 34);
            btnsearch.TabIndex = 10;
            btnsearch.Text = "Search";
            btnsearch.UseVisualStyleBackColor = true;
            btnsearch.Click += btnsearch_Click;
            // 
            // txtsearch
            // 
            txtsearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtsearch.Location = new Point(166, 55);
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
            label1.Location = new Point(34, 63);
            label1.Name = "label1";
            label1.Size = new Size(62, 18);
            label1.TabIndex = 8;
            label1.Text = "Search";
            // 
            // dgvdsgv
            // 
            dgvdsgv.AllowUserToAddRows = false;
            dgvdsgv.AllowUserToDeleteRows = false;
            dgvdsgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvdsgv.BackgroundColor = SystemColors.ActiveCaption;
            dgvdsgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdsgv.Dock = DockStyle.Bottom;
            dgvdsgv.Location = new Point(0, 178);
            dgvdsgv.MultiSelect = false;
            dgvdsgv.Name = "dgvdsgv";
            dgvdsgv.ReadOnly = true;
            dgvdsgv.RowHeadersWidth = 62;
            dgvdsgv.RowTemplate.Height = 33;
            dgvdsgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvdsgv.Size = new Size(800, 272);
            dgvdsgv.TabIndex = 7;
            dgvdsgv.CellContentClick += dgvdsgv_CellContentClick;
            dgvdsgv.CellDoubleClick += dgvdsgv_CellDoubleClick_1;
            // 
            // DSGV
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(btnsearch);
            Controls.Add(txtsearch);
            Controls.Add(label1);
            Controls.Add(dgvdsgv);
            Name = "DSGV";
            Text = "DSGV";
            Load += DSGV_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvdsgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button button2;
        private Button btnsearch;
        private TextBox txtsearch;
        private Label label1;
        private DataGridView dgvdsgv;
    }
}