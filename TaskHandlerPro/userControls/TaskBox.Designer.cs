namespace TaskHandlerPro
{
    partial class TaskBox
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
            this.taskName = new System.Windows.Forms.Label();
            this.openButton = new System.Windows.Forms.Button();
            this.taskNum = new System.Windows.Forms.Label();
            this.taskSec = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // taskName
            // 
            this.taskName.AutoSize = true;
            this.taskName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskName.ForeColor = System.Drawing.Color.Black;
            this.taskName.Location = new System.Drawing.Point(132, 8);
            this.taskName.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.taskName.Name = "taskName";
            this.taskName.Size = new System.Drawing.Size(43, 17);
            this.taskName.TabIndex = 2;
            this.taskName.Text = "Task";
            this.taskName.Click += new System.EventHandler(this.taskName_Click);
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(445, 8);
            this.openButton.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(94, 20);
            this.openButton.TabIndex = 3;
            this.openButton.Text = "solutions";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // taskNum
            // 
            this.taskNum.AutoSize = true;
            this.taskNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskNum.ForeColor = System.Drawing.Color.Black;
            this.taskNum.Location = new System.Drawing.Point(8, 8);
            this.taskNum.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.taskNum.Name = "taskNum";
            this.taskNum.Size = new System.Drawing.Size(38, 17);
            this.taskNum.TabIndex = 2;
            this.taskNum.Text = "num";
            this.taskNum.Click += new System.EventHandler(this.taskNum_Click);
            // 
            // taskSec
            // 
            this.taskSec.AutoSize = true;
            this.taskSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskSec.ForeColor = System.Drawing.Color.Black;
            this.taskSec.Location = new System.Drawing.Point(70, 8);
            this.taskSec.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.taskSec.Name = "taskSec";
            this.taskSec.Size = new System.Drawing.Size(35, 17);
            this.taskSec.TabIndex = 2;
            this.taskSec.Text = "Sec";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.taskNum, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.openButton, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.taskSec, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.taskName, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(626, 69);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // TaskBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TaskBox";
            this.Size = new System.Drawing.Size(626, 69);
            this.Load += new System.EventHandler(this.TaskBox_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label taskName;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Label taskNum;
        private System.Windows.Forms.Label taskSec;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
