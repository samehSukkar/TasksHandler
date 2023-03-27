using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskHandlerPro.classes
{
    public partial class SolutionView : UserControl
    {
        public SolutionView()
        {
            InitializeComponent();
        }
       
        public void LoadSolutions(List<Solution> solutionLst)
        {
            panel1.Controls.Clear();
            foreach(Solution s in solutionLst)
            {
                SolutionBox solutionBox = new SolutionBox(s);
                solutionBox.Dock = DockStyle.Top;
                panel1.Controls.Add(solutionBox);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
