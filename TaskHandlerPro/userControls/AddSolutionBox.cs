using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskHandlerPro.userControls
{
    
    public partial class AddSolutionBox : UserControl
    {
        
        static List<AddSolutionBox> boxesList =  new List<AddSolutionBox>();
        public static void setStudentList(int sec)
        {
            foreach(AddSolutionBox box in boxesList)
            {
                box.studentIdComboBox.Items.Clear();
                foreach(Student s in Student.loadStudents())
                {
                    if(s.Section == sec)
                    {
                        box.studentIdComboBox.Items.Add(s.Id);
                    }
                }
            }
        }

        Solution solution;

        public AddSolutionBox(Solution solution)
        {
            this.solution = solution;
           
            boxesList.Add(this);
            InitializeComponent();
        }
        public AddSolutionBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void AddSolutionBox_Load(object sender, EventArgs e)
        {
            SolutionName.Text = solution.Name;
            //studentIdComboBox.Items.Clear();
            //List<Student> studentsLst = Student.loadStudents();
            //foreach (Student s in studentsLst)
            //    studentIdComboBox.Items.Add(s.Id);
        }
        public void InsertSolution()
        {
            solution.TaskNo = Convert.ToInt32(studentIdComboBox.Text);
            Solution.Insert(this.solution);
        }
    }

}
