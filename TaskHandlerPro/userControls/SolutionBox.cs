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

namespace TaskHandlerPro
{
    public partial class SolutionBox : UserControl
    {

        Solution solution;
        public SolutionBox(Solution solution)
        {
            this.solution = solution;
            InitializeComponent();
        }
        public SolutionBox()
        {         
            InitializeComponent();
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            solution.RunExe();
        }

        private void SolutionBox_Load(object sender, EventArgs e)
        {
            taskName.Text = solution.Name; 
            taskNo.Text = solution.TaskNo.ToString();
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            solution.OpenSLN();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }

  
}
