using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TaskHandlerPro.userControls
{
    public partial class AddSolutionsView : UserControl
    {
        public AddSolutionsView()
        {
            InitializeComponent();

        }

        public void AddSolution(Solution solution)
        {
            AddSolutionBox solutionBox = new AddSolutionBox(solution);
            solutionBox.Dock = DockStyle.Top;
            panel1.Controls.Add(solutionBox);
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string mainPath = folderBrowserDialog1.SelectedPath;
                DirectoryInfo mainFolder = new DirectoryInfo(mainPath);

                foreach (DirectoryInfo d in mainFolder.GetDirectories())
                {
                    Solution solution = new Solution(d);
                    solution.TaskNo = Int32.Parse(taskNoComboBox.Text);
                    AddSolution(solution);
                }
            }
        }

        private void submit_Button_Click(object sender, EventArgs e)
        {
            foreach(AddSolutionBox sBox in panel1.Controls)
            {
                sBox.InsertSolution();
            }
            panel1.Controls.Clear();
        }

        private void AddSolutionsView_Load(object sender, EventArgs e)
        {
            taskNoComboBox.Items.Clear();
            List<int> tasksLst = Task.LoadTaskNums();
            foreach (int num in tasksLst)
                taskNoComboBox.Items.Add(num);

            sectionComboBox.Items.Clear();
            List<int> sectionsLst = Student.loadSections();
            foreach (int sec in sectionsLst)
                sectionComboBox.Items.Add(sec);
        }

        private void sectionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddSolutionBox.setStudentList((int)sectionComboBox.SelectedItem);
        }
    }
}
