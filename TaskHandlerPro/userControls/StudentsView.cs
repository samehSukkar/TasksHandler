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
    public partial class StudentsView : UserControl
    {
        public StudentsView()
        {
            InitializeComponent();
        }



        public void LoadStudents()
        {
            panel1.Controls.Clear();
            List<Student> Slist = Student.loadStudents();
            StudentBox sbox; ;
            foreach (Student s in Slist)
            {
                sbox = new StudentBox(s);
                sbox.Dock = DockStyle.Top;
                panel1.Controls.Add(sbox);
            }
        }

      
       
    }
}
