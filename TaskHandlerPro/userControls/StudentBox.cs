using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskHandlerPro.classes;

namespace TaskHandlerPro
{
    public partial class StudentBox : UserControl
    {
        
        Student student;
        public StudentBox()
        {
            InitializeComponent();
        }

        public StudentBox(Student s)
        {

            InitializeComponent();
            student = s;
            this.nameLabel.Text = student.FullName;
            this.secLabel.Text = student.Section.ToString();
            this.IDlabel.Text = student.Id.ToString();
          
        }

        private void solutionsButton_Click(object sender, EventArgs e)
        {
            List<Solution> lst = Solution.GetByStudentId(student.Id);
            //slst = lst;
            //mainForm.solutionsView.Visible = true;
            //mainForm.solutionsView.Show();
            //mainForm.tasksView.Hide();
            //mainForm.studentsView.Hide();
            //mainForm.solutionsView.LoadSolutions(lst);
            mainForm.displaySolutions(lst);
        }
    }
}
