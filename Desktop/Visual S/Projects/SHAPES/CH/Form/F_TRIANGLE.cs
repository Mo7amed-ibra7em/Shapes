using Dll_Shape;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

 namespace SHAPES
{
    public partial class F_TRIANGLE : Form
    {
        public F_TRIANGLE()
        {
            InitializeComponent();
        }

        private void b_triangle_Circumference_Click(object sender, EventArgs e)
        {
            if(t_enter_a.Text != "" && t_enter_b.Text != "" && t_enter_c.Text != "")
            {
                t_show.Text = Shapes.Triangle_Circumference.GetPerimeter(Convert.ToDouble(t_enter_a.Text), Convert.ToDouble(t_enter_b.Text), Convert.ToDouble(t_enter_c.Text)).ToString();
            }
        }
        private void b_triangle_Space_Click(object sender, EventArgs e)
        {
            if (t_enter_a.Text != "" && t_enter_b.Text != "" && t_enter_c.Text != "")
            {
                t_show.Text = Shapes.Triangle_Space.GetPerimeter(Convert.ToDouble(t_enter_a.Text), Convert.ToDouble(t_enter_b.Text), Convert.ToDouble(t_enter_c.Text)).ToString();
            }
        }
    }
}
