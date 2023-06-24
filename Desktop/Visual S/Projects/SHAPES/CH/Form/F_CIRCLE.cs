using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dll_Shape;

namespace SHAPES
{
    public partial class F_CIRCLE : Form
    {
        public F_CIRCLE()
        {
            InitializeComponent();
        }

        private void b_Circle_Space_Click(object sender, EventArgs e)///مساحة الدائرة
        {
            if (t_enter_r.Text != "")
            {
                t_show.Text = Shapes.Circle_Space.GetArea(Convert.ToDouble(t_enter_r.Text)).ToString();

            }
        }
        private void b_Circle_Circumference_Click(object sender, EventArgs e)///محيط الدائرة
        {
            if (t_enter_r.Text != "")
            {
                t_show.Text = Shapes.Circle_Circumference.GetCircumference(Convert.ToDouble(t_enter_r.Text)).ToString();
            }
        }
    }
}
