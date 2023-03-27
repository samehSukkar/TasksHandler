namespace TaskHandlerPro
{
    partial class mainForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.AddSolutionsButton = new Guna.UI2.WinForms.Guna2Button();
            this.tasksButton = new Guna.UI2.WinForms.Guna2Button();
            this.studentsButton = new Guna.UI2.WinForms.Guna2Button();
            this.backButton = new Guna.UI2.WinForms.Guna2Button();
            this.addSolutionsView1 = new TaskHandlerPro.userControls.AddSolutionsView();
            this.taskView1 = new TaskHandlerPro.TaskView();
            this.studentsView1 = new TaskHandlerPro.StudentsView();
            this.solutionView1 = new TaskHandlerPro.classes.SolutionView();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 131F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 131F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 131F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.AddSolutionsButton, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.tasksButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.studentsButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.backButton, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1039, 76);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // AddSolutionsButton
            // 
            this.AddSolutionsButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.AddSolutionsButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddSolutionsButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddSolutionsButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddSolutionsButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddSolutionsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddSolutionsButton.FillColor = System.Drawing.Color.CornflowerBlue;
            this.AddSolutionsButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSolutionsButton.ForeColor = System.Drawing.Color.White;
            this.AddSolutionsButton.Location = new System.Drawing.Point(393, 0);
            this.AddSolutionsButton.Margin = new System.Windows.Forms.Padding(0);
            this.AddSolutionsButton.Name = "AddSolutionsButton";
            this.AddSolutionsButton.Size = new System.Drawing.Size(140, 76);
            this.AddSolutionsButton.TabIndex = 4;
            this.AddSolutionsButton.Text = "Add solutions";
            this.AddSolutionsButton.Click += new System.EventHandler(this.AddSolutionsButton_Click);
            // 
            // tasksButton
            // 
            this.tasksButton.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.tasksButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.tasksButton.Checked = true;
            this.tasksButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.tasksButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.tasksButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.tasksButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.tasksButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tasksButton.FillColor = System.Drawing.Color.CornflowerBlue;
            this.tasksButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tasksButton.ForeColor = System.Drawing.Color.White;
            this.tasksButton.Location = new System.Drawing.Point(131, 0);
            this.tasksButton.Margin = new System.Windows.Forms.Padding(0);
            this.tasksButton.Name = "tasksButton";
            this.tasksButton.Size = new System.Drawing.Size(131, 76);
            this.tasksButton.TabIndex = 0;
            this.tasksButton.Text = "Tasks";
            this.tasksButton.Click += new System.EventHandler(this.TasksButton_Click);
            // 
            // studentsButton
            // 
            this.studentsButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.studentsButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.studentsButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.studentsButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.studentsButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.studentsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentsButton.FillColor = System.Drawing.Color.CornflowerBlue;
            this.studentsButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentsButton.ForeColor = System.Drawing.Color.White;
            this.studentsButton.Location = new System.Drawing.Point(262, 0);
            this.studentsButton.Margin = new System.Windows.Forms.Padding(0);
            this.studentsButton.Name = "studentsButton";
            this.studentsButton.Size = new System.Drawing.Size(131, 76);
            this.studentsButton.TabIndex = 1;
            this.studentsButton.Text = "Students";
            this.studentsButton.Click += new System.EventHandler(this.studentsButton_Click);
            // 
            // backButton
            // 
            this.backButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.backButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.backButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.backButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.backButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backButton.FillColor = System.Drawing.Color.CornflowerBlue;
            this.backButton.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(4, 4);
            this.backButton.Margin = new System.Windows.Forms.Padding(4);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(123, 68);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "<<";
            this.backButton.Visible = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // addSolutionsView1
            // 
            this.addSolutionsView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addSolutionsView1.Location = new System.Drawing.Point(0, 76);
            this.addSolutionsView1.Name = "addSolutionsView1";
            this.addSolutionsView1.Size = new System.Drawing.Size(1039, 552);
            this.addSolutionsView1.TabIndex = 4;
            // 
            // taskView1
            // 
            this.taskView1.BackColor = System.Drawing.Color.White;
            this.taskView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taskView1.Location = new System.Drawing.Point(0, 76);
            this.taskView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.taskView1.Name = "taskView1";
            this.taskView1.Size = new System.Drawing.Size(1039, 552);
            this.taskView1.TabIndex = 1;
            // 
            // studentsView1
            // 
            this.studentsView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentsView1.Location = new System.Drawing.Point(0, 76);
            this.studentsView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.studentsView1.Name = "studentsView1";
            this.studentsView1.Size = new System.Drawing.Size(1039, 552);
            this.studentsView1.TabIndex = 2;
            // 
            // solutionView1
            // 
            this.solutionView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.solutionView1.Location = new System.Drawing.Point(0, 76);
            this.solutionView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.solutionView1.Name = "solutionView1";
            this.solutionView1.Size = new System.Drawing.Size(1039, 552);
            this.solutionView1.TabIndex = 3;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1039, 628);
            this.Controls.Add(this.taskView1);
            this.Controls.Add(this.addSolutionsView1);
            this.Controls.Add(this.studentsView1);
            this.Controls.Add(this.solutionView1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "mainForm";
            this.Text = "mainForm";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private TaskView taskView1;
        private StudentsView studentsView1;
        private classes.SolutionView solutionView1;
        private Guna.UI2.WinForms.Guna2Button tasksButton;
        private Guna.UI2.WinForms.Guna2Button studentsButton;
        private Guna.UI2.WinForms.Guna2Button backButton;
        private Guna.UI2.WinForms.Guna2Button AddSolutionsButton;
        private userControls.AddSolutionsView addSolutionsView1;
    }
}