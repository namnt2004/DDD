namespace WinFormsApp10
{
    partial class Form2
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
            pnlcontent = new Panel();
            menuStrip1 = new MenuStrip();
            changepassToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            managementToolStripMenuItem = new ToolStripMenuItem();
            studentToolStripMenuItem = new ToolStripMenuItem();
            teacherToolStripMenuItem = new ToolStripMenuItem();
            subjectToolStripMenuItem = new ToolStripMenuItem();
            classToolStripMenuItem = new ToolStripMenuItem();
            scoreToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            menuStrip2 = new MenuStrip();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // pnlcontent
            // 
            pnlcontent.BackColor = Color.Transparent;
            pnlcontent.Dock = DockStyle.Fill;
            pnlcontent.Location = new Point(0, 56);
            pnlcontent.Name = "pnlcontent";
            pnlcontent.Size = new Size(800, 394);
            pnlcontent.TabIndex = 5;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Location = new Point(0, 32);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // changepassToolStripMenuItem
            // 
            changepassToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            changepassToolStripMenuItem.Font = new Font("SimSun", 9F, FontStyle.Regular, GraphicsUnit.Point);
            changepassToolStripMenuItem.Name = "changepassToolStripMenuItem";
            changepassToolStripMenuItem.Size = new Size(78, 28);
            changepassToolStripMenuItem.Text = "System";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(142, 34);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click_1;
            // 
            // managementToolStripMenuItem
            // 
            managementToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { studentToolStripMenuItem, teacherToolStripMenuItem, subjectToolStripMenuItem, classToolStripMenuItem, scoreToolStripMenuItem });
            managementToolStripMenuItem.Font = new Font("SimSun", 9F, FontStyle.Regular, GraphicsUnit.Point);
            managementToolStripMenuItem.Name = "managementToolStripMenuItem";
            managementToolStripMenuItem.Size = new Size(114, 28);
            managementToolStripMenuItem.Text = "Management";
            // 
            // studentToolStripMenuItem
            // 
            studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            studentToolStripMenuItem.Size = new Size(270, 34);
            studentToolStripMenuItem.Text = "Student";
            studentToolStripMenuItem.Click += studentToolStripMenuItem_Click_1;
            // 
            // teacherToolStripMenuItem
            // 
            teacherToolStripMenuItem.Name = "teacherToolStripMenuItem";
            teacherToolStripMenuItem.Size = new Size(270, 34);
            teacherToolStripMenuItem.Text = "Teacher";
            teacherToolStripMenuItem.Click += teacherToolStripMenuItem_Click_1;
            // 
            // subjectToolStripMenuItem
            // 
            subjectToolStripMenuItem.Name = "subjectToolStripMenuItem";
            subjectToolStripMenuItem.Size = new Size(270, 34);
            subjectToolStripMenuItem.Text = "Subject";
            subjectToolStripMenuItem.Click += subjectToolStripMenuItem_Click_1;
            // 
            // classToolStripMenuItem
            // 
            classToolStripMenuItem.Name = "classToolStripMenuItem";
            classToolStripMenuItem.Size = new Size(270, 34);
            classToolStripMenuItem.Text = "Class";
            classToolStripMenuItem.Click += classToolStripMenuItem_Click_1;
            // 
            // scoreToolStripMenuItem
            // 
            scoreToolStripMenuItem.Name = "scoreToolStripMenuItem";
            scoreToolStripMenuItem.Size = new Size(270, 34);
            scoreToolStripMenuItem.Text = "Score";
            scoreToolStripMenuItem.Click += scoreToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Font = new Font("SimSun", 9F, FontStyle.Regular, GraphicsUnit.Point);
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(60, 28);
            helpToolStripMenuItem.Text = "Help";
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(24, 24);
            menuStrip2.Items.AddRange(new ToolStripItem[] { changepassToolStripMenuItem, managementToolStripMenuItem, helpToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(800, 32);
            menuStrip2.TabIndex = 4;
            menuStrip2.Text = "menuStrip2";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlcontent);
            Controls.Add(menuStrip1);
            Controls.Add(menuStrip2);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlcontent;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem changepassToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem managementToolStripMenuItem;
        private ToolStripMenuItem studentToolStripMenuItem;
        private ToolStripMenuItem teacherToolStripMenuItem;
        private ToolStripMenuItem subjectToolStripMenuItem;
        private ToolStripMenuItem classToolStripMenuItem;
        private ToolStripMenuItem scoreToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private MenuStrip menuStrip2;
    }
}