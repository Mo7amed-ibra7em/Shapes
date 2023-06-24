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
    public partial class F_PYRAMID : Form
    {
        public F_PYRAMID()
        {
            InitializeComponent();
        }

        private void b_Circle_Space_Click(object sender, EventArgs e)
        {
            if (t_hight.Text != "" && t_enter_abc.Text != "")
            {
                t_show1.Text = Shapes.Pyramid_TotalSpace.GetPerimeter(Convert.ToDouble(t_enter_abc.Text), Convert.ToDouble(t_hight.Text)).ToString();
                t_show2.Text = Shapes.Pyramid_TotalSpace.MessageGetPerimeter(Convert.ToDouble(t_enter_abc.Text), Convert.ToDouble(t_hight.Text)).ToString();
            }
        }

        private void F_PYRAMID_Load(object sender, EventArgs e)
        {

        }
    }
}
