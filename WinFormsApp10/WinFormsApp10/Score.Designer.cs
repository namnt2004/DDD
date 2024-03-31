namespace WinFormsApp10
{
    partial class Score
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
            btnsearch = new Button();
            txtsearch = new TextBox();
            label1 = new Label();
            dgvscore = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvscore).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SimSun", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(236, 9);
            label2.Name = "label2";
            label2.Size = new Size(255, 33);
            label2.TabIndex = 9;
            label2.Text = "Test Score List";
            // 
            // btnsearch
            // 
            btnsearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnsearch.Font = new Font("SimSun", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnsearch.Location = new Point(663, 58);
            btnsearch.Name = "btnsearch";
            btnsearch.Size = new Size(112, 34);
            btnsearch.TabIndex = 8;
            btnsearch.Text = "Search";
            btnsearch.UseVisualStyleBackColor = true;
            btnsearch.Click += btnsearch_Click_1;
            // 
            // txtsearch
            // 
            txtsearch.Anchor = AnchorStyles.Top;
            txtsearch.Location = new Point(122, 61);
            txtsearch.Name = "txtsearch";
            txtsearch.Size = new Size(501, 31);
            txtsearch.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(25, 67);
            label1.Name = "label1";
            label1.Size = new Size(62, 18);
            label1.TabIndex = 6;
            label1.Text = "Search";
            // 
            // dgvscore
            // 
            dgvscore.AllowUserToAddRows = false;
            dgvscore.AllowUserToDeleteRows = false;
            dgvscore.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvscore.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvscore.Dock = DockStyle.Bottom;
            dgvscore.Location = new Point(0, 138);
            dgvscore.MultiSelect = false;
            dgvscore.Name = "dgvscore";
            dgvscore.ReadOnly = true;
            dgvscore.RowHeadersWidth = 62;
            dgvscore.RowTemplate.Height = 33;
            dgvscore.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvscore.Size = new Size(800, 312);
            dgvscore.TabIndex = 5;
            // 
            // Score
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(btnsearch);
            Controls.Add(txtsearch);
            Controls.Add(label1);
            Controls.Add(dgvscore);
            Name = "Score";
            Text = "Score";
            Load += Score_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvscore).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button btnsearch;
        private TextBox txtsearch;
        private Label label1;
        private DataGridView dgvscore;
    }
}