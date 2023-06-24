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
    public partial class F_CONE : Form
    {
        public F_CONE()
        {
            InitializeComponent();
        }

        private void b_Circle_Space_Click(object sender, EventArgs e)
        {
            if (t_hight.Text != "" && t_enter_r.Text != "")
            {
                t_show1.Text = Shapes.Cone_TotalSpace.lateral_Area(Convert.ToDouble(t_enter_r.Text), Convert.ToDouble(t_hight.Text)).ToString();
                t_show2.Text = Shapes.Cone_TotalSpace.CalculateTotalSurfaceArea(Convert.ToDouble(t_enter_r.Text), Convert.ToDouble(t_hight.Text)).ToString();
            }
        }
    }
}
