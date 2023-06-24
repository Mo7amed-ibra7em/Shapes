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
    public partial class F_RECTANGLE : Form
    {
        public F_RECTANGLE()
        {
            InitializeComponent();
        }

        private void b_rectangle_Space_Click(object sender, EventArgs e)///مساحة مستطيل
        {
            if (t_enter_hieght.Text != "" && t_enter_width.Text != "")
            {
                t_show.Text = Shapes.Rectangle_Space.GetArea(Convert.ToDouble(t_enter_hieght.Text), Convert.ToDouble(t_enter_width.Text)).ToString();
            }
        }

        private void b_rectangle_Circumference_Click(object sender, EventArgs e)///محيط مستطيل
        {
            if (t_enter_hieght.Text != "" && t_enter_width.Text != "")
            {
                t_show.Text = Shapes.Rectangle_Circumference.GetPerimeter(Convert.ToDouble(t_enter_hieght.Text), Convert.ToDouble(t_enter_width.Text)).ToString();
            }
        }
    }
}
