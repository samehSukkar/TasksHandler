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
    public partial class TaskView : UserControl
    {
        public TaskView()
        {
            InitializeComponent();
        }

       
        public void LoadTasks()
        {
            panel1.Controls.Clear();
            List<Task> Tlist = Task.loadTasks();
            foreach (Task t in Tlist)
            {
                TaskBox tbox = new TaskBox(t);
                tbox.Dock = DockStyle.Top;

                //Button b = (Button)tbox.Controls.Find("openButton", true)[0];
                //mainForm m = (mainForm)(this.Parent);

                //b.Click += (e, s) => {


                //    m.showSolutions(e, s);

                //};


                panel1.Controls.Add(tbox);

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
