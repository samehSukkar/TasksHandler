namespace TaskHandlerPro.userControls
{
    partial class AddSolutionsView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.sectionComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.taskNoComboBox = new System.Windows.Forms.ComboBox();
            this.submit_Button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.sectionComboBox);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.taskNoComboBox);
            this.flowLayoutPanel1.Controls.Add(this.submit_Button);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(132, 498);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 57);
            this.button1.TabIndex = 0;
            this.button1.Text = "Select Folder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "section";
            // 
            // sectionComboBox
            // 
            this.sectionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sectionComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sectionComboBox.FormattingEnabled = true;
            this.sectionComboBox.Location = new System.Drawing.Point(4, 82);
            this.sectionComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sectionComboBox.Name = "sectionComboBox";
            this.sectionComboBox.Size = new System.Drawing.Size(120, 24);
            this.sectionComboBox.TabIndex = 6;
            this.sectionComboBox.SelectedIndexChanged += new System.EventHandler(this.sectionComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "task number";
            // 
            // taskNoComboBox
            // 
            this.taskNoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.taskNoComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.taskNoComboBox.FormattingEnabled = true;
            this.taskNoComboBox.Location = new System.Drawing.Point(4, 131);
            this.taskNoComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.taskNoComboBox.Name = "taskNoComboBox";
            this.taskNoComboBox.Size = new System.Drawing.Size(120, 24);
            this.taskNoComboBox.TabIndex = 7;
            // 
            // submit_Button
            // 
            this.submit_Button.Location = new System.Drawing.Point(3, 190);
            this.submit_Button.Margin = new System.Windows.Forms.Padding(3, 31, 3, 2);
            this.submit_Button.Name = "submit_Button";
            this.submit_Button.Size = new System.Drawing.Size(129, 57);
            this.submit_Button.TabIndex = 5;
            this.submit_Button.Text = "Submit";
            this.submit_Button.UseVisualStyleBackColor = true;
            this.submit_Button.Click += new System.EventHandler(this.submit_Button_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(132, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(785, 498);
            this.panel1.TabIndex = 10;
            // 
            // AddSolutionsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddSolutionsView";
            this.Size = new System.Drawing.Size(917, 498);
            this.Load += new System.EventHandler(this.AddSolutionsView_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button submit_Button;
        private System.Windows.Forms.ComboBox taskNoComboBox;
        private System.Windows.Forms.ComboBox sectionComboBox;
    }
}
