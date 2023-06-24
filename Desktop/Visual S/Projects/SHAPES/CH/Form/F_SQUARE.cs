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
    public partial class F_SQUARE : Form
    {
        public F_SQUARE()
        {
            InitializeComponent();
        }

        private void b_square_Circumference_Click(object sender, EventArgs e)///محيط مربع
        {
            if(t_enter_side.Text != "")
            {
                t_show.Text = Shapes.Square_Circumference.GetPerimeter(Convert.ToDouble(t_enter_side.Text)).ToString();
            }
        }

        private void b_square_Space_Click(object sender, EventArgs e)///مساحة مربع
        {
            if (t_enter_side.Text != "")
            {
                t_show.Text = Shapes.Square_Space.CalculateSquareArea(Convert.ToDouble(t_enter_side.Text)).ToString().ToString();
            }
        }
    }
}
