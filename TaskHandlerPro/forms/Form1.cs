using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskHandlerPro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Student> students = Student.loadStudents();
        List<Task> tasks = Task.loadTasks();
        
        private void openFolderButton_Click(object sender, EventArgs e)
        {
           
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    string mainPath = folderBrowserDialog1.SelectedPath;
                    DirectoryInfo mainFolder = new DirectoryInfo(mainPath);

                    foreach (DirectoryInfo d in mainFolder.GetDirectories())
                    {
                        Solution solution = new Solution(d);
                        AddSolution(solution);
                    }
                }
        }
       

        private void AddSolution(Solution solution)
        {
            SolutionBox sbox = new SolutionBox(solution);
            sbox.Dock = DockStyle.Top;
            panel1.Controls.Add(sbox);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.HorizontalScroll.Maximum = 0;
            panel1.AutoScroll = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
          
            foreach (Solution sol in Solution.GetByTaskNo(2))
            {
                AddSolution(sol);
            }

        }
    }
}
