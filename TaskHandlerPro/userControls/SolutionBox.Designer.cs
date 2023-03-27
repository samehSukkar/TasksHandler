namespace TaskHandlerPro
{
    partial class SolutionBox
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.openButton = new System.Windows.Forms.Button();
            this.runButton = new System.Windows.Forms.Button();
            this.taskName = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.taskNo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.numericUpDown1.Location = new System.Drawing.Point(519, 17);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(59, 24);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // openButton
            // 
            this.openButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.openButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.openButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.openButton.FlatAppearance.BorderSize = 0;
            this.openButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openButton.ForeColor = System.Drawing.Color.Cornsilk;
            this.openButton.Location = new System.Drawing.Point(454, 17);
            this.openButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(61, 23);
            this.openButton.TabIndex = 2;
            this.openButton.Text = "Open";
            this.openButton.UseMnemonic = false;
            this.openButton.UseVisualStyleBackColor = false;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // runButton
            // 
            this.runButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.runButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.runButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.runButton.FlatAppearance.BorderSize = 0;
            this.runButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.runButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runButton.ForeColor = System.Drawing.Color.Cornsilk;
            this.runButton.Location = new System.Drawing.Point(374, 17);
            this.runButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(76, 23);
            this.runButton.TabIndex = 1;
            this.runButton.Text = "Run";
            this.runButton.UseMnemonic = false;
            this.runButton.UseVisualStyleBackColor = false;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // taskName
            // 
            this.taskName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.taskName.AutoSize = true;
            this.taskName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskName.ForeColor = System.Drawing.Color.White;
            this.taskName.Location = new System.Drawing.Point(92, 20);
            this.taskName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.taskName.Name = "taskName";
            this.taskName.Size = new System.Drawing.Size(84, 17);
            this.taskName.TabIndex = 0;
            this.taskName.Text = "TaskName";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.4F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.12F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.8F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.4F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.08F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.2F));
            this.tableLayoutPanel1.Controls.Add(this.taskNo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.openButton, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown1, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.runButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.taskName, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(626, 69);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // taskNo
            // 
            this.taskNo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.taskNo.AutoSize = true;
            this.taskNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskNo.ForeColor = System.Drawing.Color.White;
            this.taskNo.Location = new System.Drawing.Point(2, 19);
            this.taskNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.taskNo.Name = "taskNo";
            this.taskNo.Size = new System.Drawing.Size(69, 20);
            this.taskNo.TabIndex = 5;
            this.taskNo.Text = "TaskNo";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(582, 17);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // SolutionBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.Name = "SolutionBox";
            this.Size = new System.Drawing.Size(626, 69);
            this.Load += new System.EventHandler(this.SolutionBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.Label taskName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label taskNo;
        private System.Windows.Forms.Button button1;
    }
}
