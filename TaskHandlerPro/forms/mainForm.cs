using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using TaskHandlerPro.classes;
using TaskHandlerPro.userControls;

namespace TaskHandlerPro
{
    public partial class mainForm : Form
    {
        private static SolutionView solutionsView;
        private static TaskView tasksView;
        private static StudentsView studentsView;
        private static Guna2Button BackButton;
        public string previous;
        public mainForm()
        {
            InitializeComponent();
            solutionsView = solutionView1;
            tasksView = taskView1;
            studentsView = studentsView1;
            BackButton = backButton;
           
        }

        private void TasksButton_Click(object sender, EventArgs e)
        {
            displayTasks();
            previous = "tasks";
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            taskView1.LoadTasks();
            taskView1.Show();
            studentsView1.Hide();
            solutionsView.Hide();

        }

        private void taskView1_Load(object sender, EventArgs e)
        {
            taskView1.LoadTasks();
            previous = "tasks";
        }


        private void studentsButton_Click(object sender, EventArgs e)
        {
            displayStudents();
            previous = "students";

        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public static void displaySolutions(List<Solution> lst)
        {
            BackButton.Visible = true;
            mainForm.solutionsView.Visible = true;
            mainForm.solutionsView.Show();
            mainForm.tasksView.Hide();
            mainForm.studentsView.Hide();
            mainForm.solutionsView.LoadSolutions(lst);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (previous == "tasks")
                displayTasks();
            else if (previous == "students")
                displayStudents();

        }

        private void displayStudents()
        {
            addSolutionsView1.Hide();
            solutionsView.Hide();
            studentsView1.LoadStudents();
            studentsView1.Show();
            studentsView1.BringToFront();
            taskView1.Hide();
            backButton.Visible = false;
        }
        private void displayTasks()
        {
            taskView1.LoadTasks();
            taskView1.Show();
            taskView1.BringToFront();
            studentsView1.Hide();
            solutionsView.Hide();
            addSolutionsView1.Hide();

            backButton.Visible = false;
        }

      
        private void AddSolutionsButton_Click(object sender, EventArgs e)
        {

            addSolutionsView1.Show();
            addSolutionsView1.BringToFront();
            studentsView1.Hide();
            solutionsView.Hide();
            taskView1.Hide();

            backButton.Visible = false;
        }
    }
}