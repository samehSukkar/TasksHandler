namespace TaskHandlerPro
{
    partial class StudentBox
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
            this.solutionsButton = new System.Windows.Forms.Button();
            this.IDlabel = new System.Windows.Forms.Label();
            this.secLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // solutionsButton
            // 
            this.solutionsButton.Location = new System.Drawing.Point(445, 8);
            this.solutionsButton.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.solutionsButton.Name = "solutionsButton";
            this.solutionsButton.Size = new System.Drawing.Size(94, 20);
            this.solutionsButton.TabIndex = 7;
            this.solutionsButton.Text = "solutions";
            this.solutionsButton.UseVisualStyleBackColor = true;
            this.solutionsButton.Click += new System.EventHandler(this.solutionsButton_Click);
            // 
            // IDlabel
            // 
            this.IDlabel.AutoSize = true;
            this.IDlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDlabel.ForeColor = System.Drawing.Color.Black;
            this.IDlabel.Location = new System.Drawing.Point(70, 8);
            this.IDlabel.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(23, 17);
            this.IDlabel.TabIndex = 4;
            this.IDlabel.Text = "ID";
            this.IDlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // secLabel
            // 
            this.secLabel.AutoSize = true;
            this.secLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secLabel.ForeColor = System.Drawing.Color.Black;
            this.secLabel.Location = new System.Drawing.Point(8, 8);
            this.secLabel.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.secLabel.Name = "secLabel";
            this.secLabel.Size = new System.Drawing.Size(33, 17);
            this.secLabel.TabIndex = 5;
            this.secLabel.Text = "sec";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.Black;
            this.nameLabel.Location = new System.Drawing.Point(195, 8);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(47, 17);
            this.nameLabel.TabIndex = 6;
            this.nameLabel.Text = "name";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.solutionsButton, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.nameLabel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.IDlabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.secLabel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(626, 72);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // StudentBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.Name = "StudentBox";
            this.Size = new System.Drawing.Size(626, 69);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button solutionsButton;
        private System.Windows.Forms.Label IDlabel;
        private System.Windows.Forms.Label secLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
