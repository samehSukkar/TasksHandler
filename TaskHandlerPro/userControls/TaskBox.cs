using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskHandlerPro
{
    public partial class TaskBox : UserControl
    {
        Task task;
        public TaskBox()
        {
            InitializeComponent();
        }
        public TaskBox(Task t)
        {
            
            InitializeComponent();
            task = t;
            this.taskName.Text = task.Title;
            this.taskNum.Text = task.Num.ToString();
            this.taskSec.Text = task.Section.ToString();

        }
        private void taskName_Click(object sender, EventArgs e)
        {

        }

        private void taskNum_Click(object sender, EventArgs e)
        {

        }

        private void TaskBox_Load(object sender, EventArgs e)
        {

        }

        private void openButton_Click(object sender, EventArgs e)
        {
            List<Solution> lst = Solution.GetByTaskNo(task.Num);
            //mainForm.solutionsView.Visible = true;
            //mainForm.solutionsView.Show();
            //mainForm.tasksView.Hide();
            //mainForm.studentsView.Hide();
            //mainForm.solutionsView.LoadSolutions(lst);
            mainForm.displaySolutions(lst);
        }
    }
}
