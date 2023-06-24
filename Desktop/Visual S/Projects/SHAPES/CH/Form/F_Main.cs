using Guna.UI2.WinForms;
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
    public partial class F_Main : Form
    {
        #region Design
        bool but1 = false;
        bool but2 = false;
        bool but3 = false;
        bool but4 = false;
        bool but5 = false;
        bool but6 = false;
        int animated = 0;
        #endregion
        public F_Main()
        {
            InitializeComponent();
            timer1.Tick+= new EventHandler(timer1_Tick);
            b_circle.Click += new EventHandler(b_circle_Click);
            b_square.Click += new EventHandler(b_square_Click);
            b_rectangle.Click += new EventHandler(b_rectangle_Click);
            b_triangle.Click += new EventHandler(b_triangle_Click);
            b_pyramid.Click += new EventHandler(b_pyramid_Click);
            b_cone.Click += new EventHandler(b_cone_Click);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnl_load.Controls.Clear();
            F_CIRCLE circle = new F_CIRCLE();
            circle.TopLevel = false;
            pnl_load.Controls.Add(circle);
            circle.Dock = DockStyle.Fill;
            circle.Show();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (but1 == true)
            {
                pnl_scroll2.MinimumSize = l1.MaximumSize;
                if (pnl_scroll2.Size.Height >= animated)
                {
                    b_scroll.Height += 10;
                    pnl_scroll2.Height -= 10;
                }
                else
                {
                    b_scroll.Height -= 10;
                    pnl_scroll2.Height -= 10;
                }
                
                if (pnl_scroll2.Size == pnl_scroll2.MinimumSize)
                {   
                    timer1.Stop();
                    b_scroll.Height = 30;
                    but1 = false;
                    b_scroll.ShadowDecoration.Enabled = true;
                }
            }
            ////
            if (but2 == true)
            {
                if(animated == 0)
                {
                    pnl_scroll2.MaximumSize = l2.MaximumSize;
                    pnl_scroll2.Height += 10;
                    if (pnl_scroll2.Height == l2.MaximumSize.Height)
                    {
                        b_scroll.Height = 30;
                        b_scroll.ShadowDecoration.Enabled = true;
                        timer1.Stop();
                        but2 = false;
                    }
                }
                if(animated != 0)
                {
                    pnl_scroll2.MinimumSize = l2.MaximumSize;
                    if (pnl_scroll2.Size.Height >= animated)
                    {
                        b_scroll.Height += 5;
                        pnl_scroll2.Height -= 10;
                    }
                    else
                    {
                        b_scroll.Height -= 10;
                        pnl_scroll2.Height -= 5;
                    }
                    ///
                    if (pnl_scroll2.Height == l2.MaximumSize.Height)
                    {
                        b_scroll.Height = 30;
                        b_scroll.ShadowDecoration.Enabled = true;
                        timer1.Stop();
                        but2 = false;
                    }
                }
            }
            ////
            if (but3 == true)
            {
                if (animated == 0)
                {
                    pnl_scroll2.MaximumSize = l3.MaximumSize;
                    b_scroll.Height += 10;
                    pnl_scroll2.Height += 10;
                    ///
                    if (pnl_scroll2.Height == l3.MaximumSize.Height)
                    {
                        b_scroll.Height = 30;
                        b_scroll.ShadowDecoration.Enabled = true;
                        timer1.Stop();
                        but3 = false;
                    }
                }
                if (animated != 0)
                {
                    pnl_scroll2.MinimumSize = l3.MaximumSize;
                    if (pnl_scroll2.Height >= animated)
                    {
                        b_scroll.Height += 10;
                        pnl_scroll2.Height -= 10;
                    }
                    else
                    {
                        b_scroll.Height -= 10;
                        pnl_scroll2.Height -= 10;
                    }
                    ///
                    if (pnl_scroll2.Height == l3.MaximumSize.Height)
                    {
                        b_scroll.Height = 30;
                        b_scroll.ShadowDecoration.Enabled = true;
                        timer1.Stop();
                        but3 = false;
                    }
                }
            }
            ////
            if (but4 == true)
            {
                if (pnl_scroll2.Height > l4.MaximumSize.Height)
                {
                    pnl_scroll2.MinimumSize = l4.MaximumSize;
                    if (pnl_scroll2.Height >= animated)
                    {
                        b_scroll.Height += 10;
                        pnl_scroll2.Height -= 10;
                    }
                    else
                    {
                        b_scroll.Height -= 10;
                        pnl_scroll2.Height -= 10;
                    }
                    ///
                    if (pnl_scroll2.Height == l4.MaximumSize.Height)
                    {
                        b_scroll.Height = 30;
                        b_scroll.ShadowDecoration.Enabled = true;
                        timer1.Stop();
                        but4 = false;
                    }
                }
                if (pnl_scroll2.Height < l4.MaximumSize.Height)
                {
                    pnl_scroll2.MaximumSize = l4.MaximumSize;
                    if (pnl_scroll2.Size.Height >= animated)
                    {
                        b_scroll.Height -= 10;
                        pnl_scroll2.Height += 10;
                    }
                    else
                    {
                        b_scroll.Height += 10;
                        pnl_scroll2.Height += 10;
                    }
                    ///
                    if (pnl_scroll2.Height == l4.MaximumSize.Height)
                    {
                        b_scroll.Height = 30;
                        b_scroll.ShadowDecoration.Enabled = true;
                        timer1.Stop();
                        but4 = false;
                    }
                }
            }
            ////
            if (but5 == true)
            {
                if (animated == 0)
                {
                    pnl_scroll2.MaximumSize = l5.MaximumSize;

                    b_scroll.Height += 5;
                    pnl_scroll2.Height += 10;
                    ///
                    if (pnl_scroll2.Height == l5.MaximumSize.Height)
                    {
                        b_scroll.Height = 30;
                        b_scroll.ShadowDecoration.Enabled = true;
                        timer1.Stop();
                        but5 = false;
                    }
                }
                if (animated != 0)
                {
                    pnl_scroll2.MinimumSize = l5.MaximumSize;
                    if (pnl_scroll2.Size.Height >= animated)
                    {
                        b_scroll.Height += 10;
                        pnl_scroll2.Height -= 10;
                    }
                    else
                    {
                        b_scroll.Height -= 10;
                        pnl_scroll2.Height -= 10;
                    }
                    ///
                    if (pnl_scroll2.Height == l5.MaximumSize.Height)
                    {
                        b_scroll.Height = 30;
                        b_scroll.ShadowDecoration.Enabled = true;
                        timer1.Stop();
                        but5 = false;
                    }
                }
            }
            ////
            if (but6 == true)
            {
                if (animated == 0)
                {
                    pnl_scroll2.MaximumSize = l6.MaximumSize;
                    ///
                    b_scroll.Height += 5;
                    pnl_scroll2.Height += 10;
                    ///
                    if (pnl_scroll2.Height == l6.MaximumSize.Height)
                    {
                        b_scroll.Height = 30;
                        b_scroll.ShadowDecoration.Enabled = true;
                        timer1.Stop();
                        but6 = false;
                    }
                }
                if (animated != 0)
                {
                    pnl_scroll2.MinimumSize = l6.MaximumSize;
                    if (pnl_scroll2.Size.Height >= animated)
                    {
                        b_scroll.Height += 10;
                        pnl_scroll2.Height -= 10;
                    }
                    else
                    {
                        b_scroll.Height -= 10;
                        pnl_scroll2.Height -= 10;
                    }
                    ///
                    if (pnl_scroll2.Height == l6.MaximumSize.Height)
                    {
                        b_scroll.Height = 30;
                        b_scroll.ShadowDecoration.Enabled = true;
                        timer1.Stop();
                        but6 = false;
                    }
                }
            }
        }
        private void b_circle_Click(object sender, EventArgs e)
        {
            if(pnl_scroll2.Height == l1.MaximumSize.Height)
            {

            }
            else if(pnl_scroll2.Height <= l3.MaximumSize.Height)
            {
                but1 = true;
                b_scroll.ShadowDecoration.Enabled = false;
                timer1.Start();
                ///
                pnl_load.Controls.Clear();
                F_CIRCLE circle = new F_CIRCLE();
                circle.TopLevel = false;
                pnl_load.Controls.Add(circle);
                circle.Dock = DockStyle.Fill;
                circle.Show();
            }
            else if (pnl_scroll2.Height >= l4.MaximumSize.Height)
            {
                but1 = true;
                b_scroll.ShadowDecoration.Enabled = false;
                animated = pnl_scroll2.MaximumSize.Height / 2;
                timer1.Start();
                ///
                pnl_load.Controls.Clear();
                F_CIRCLE circle = new F_CIRCLE();
                circle.TopLevel = false;
                pnl_load.Controls.Add(circle);
                circle.Dock = DockStyle.Fill;
                circle.Show();
            }
        }
        private void b_square_Click(object sender, EventArgs e)
        {
            if (pnl_scroll2.Height == l2.MaximumSize.Height)
            {

            }
            else if (pnl_scroll2.Height == l1.MaximumSize.Height || pnl_scroll2.Height == l3.MaximumSize.Height)
            {
                but2 = true;
                b_scroll.ShadowDecoration.Enabled = false;
                timer1.Start();
            }
            else if (pnl_scroll2.Height >= l2.MaximumSize.Height)
            {
                but2 = true;
                b_scroll.ShadowDecoration.Enabled = false;
                animated = pnl_scroll2.MaximumSize.Height / 2;
                timer1.Start();
            }
            ///
            pnl_load.Controls.Clear();
            F_SQUARE square = new F_SQUARE();
            square.TopLevel = false;
            pnl_load.Controls.Add(square);
            square.Dock = DockStyle.Fill;
            square.Show();
        }
        private void b_rectangle_Click(object sender, EventArgs e)
        {
            if (pnl_scroll2.Height == l3.MaximumSize.Height)
            {

            }
            else if (pnl_scroll2.Height <= l2.MaximumSize.Height)
            {
                but3 = true;
                b_scroll.ShadowDecoration.Enabled = false;
                timer1.Start();
            }
            else if (pnl_scroll2.Height >= l4.MaximumSize.Height)
            {
                but3 = true;
                b_scroll.ShadowDecoration.Enabled = false;
                animated = pnl_scroll2.MaximumSize.Height / 2;
                timer1.Start();
            }                ///
            pnl_load.Controls.Clear();
            F_RECTANGLE rectangle = new F_RECTANGLE();
            rectangle.TopLevel = false;
            pnl_load.Controls.Add(rectangle);
            rectangle.Dock = DockStyle.Fill;
            rectangle.Show();
        }
        private void b_triangle_Click(object sender, EventArgs e)
        {
            if (pnl_scroll2.Height == l4.MaximumSize.Height)
            {

            }
            else if (pnl_scroll2.Height <= l2.MaximumSize.Height)
            {
                but4 = true;
                b_scroll.ShadowDecoration.Enabled = false;
                animated = pnl_scroll2.MaximumSize.Height / 2;
                timer1.Start();
            }
            else if (pnl_scroll2.Height == l3.MaximumSize.Height || pnl_scroll2.Height == l5.MaximumSize.Height)
            {
                but4 = true;
                b_scroll.ShadowDecoration.Enabled = false;
                timer1.Start();
            }
            else if (pnl_scroll2.Height >= l6.MaximumSize.Height)
            {
                but4 = true;
                b_scroll.ShadowDecoration.Enabled = false;
                animated = pnl_scroll2.MaximumSize.Height / 2;
                timer1.Start();
            }                ///
            pnl_load.Controls.Clear();
            F_TRIANGLE triangle = new F_TRIANGLE();
            triangle.TopLevel = false;
            pnl_load.Controls.Add(triangle);
            triangle.Dock = DockStyle.Fill;
            triangle.Show();
        }
        private void b_pyramid_Click(object sender, EventArgs e)
        {
            if (pnl_scroll2.Height == l5.MaximumSize.Height)
            {

            }
            else if(pnl_scroll2.Height == l4.MaximumSize.Height)
            {
                but5 = true;
                b_scroll.ShadowDecoration.Enabled = false;
                timer1.Start();
            }
            else if(pnl_scroll2.Height == l6.MaximumSize.Height)
            {
                but5 = true;
                b_scroll.ShadowDecoration.Enabled = false;
                timer1.Start();
            }
            else if (pnl_scroll2.Height <= l3.MaximumSize.Height)
            {
                but5 = true;
                b_scroll.ShadowDecoration.Enabled = false;
                animated = pnl_scroll2.MaximumSize.Height / 2;
                timer1.Start();
            }
            else if (pnl_scroll2.Height == l7.MaximumSize.Height)
            {
                but5 = true;
                b_scroll.ShadowDecoration.Enabled = false;
                animated = pnl_scroll2.MaximumSize.Height / 2;
                timer1.Start();
            }
            ///
            pnl_load.Controls.Clear();
            F_PYRAMID pyramid = new F_PYRAMID();
            pyramid.TopLevel = false;
            pnl_load.Controls.Add(pyramid);
            pyramid.Dock = DockStyle.Fill;
            pyramid.Show();
        }
        private void b_cone_Click(object sender, EventArgs e)
        {
            if (pnl_scroll2.Height == l6.MaximumSize.Height)
            {

            }
            else if (pnl_scroll2.Height <= l4.MaximumSize.Height)
            {
                but6 = true;
                b_scroll.ShadowDecoration.Enabled = false;
                animated = pnl_scroll2.MaximumSize.Height / 2;
                timer1.Start();
            }
            else if (pnl_scroll2.Height == l5.MaximumSize.Height)
            {
                but6 = true;
                b_scroll.ShadowDecoration.Enabled = false;
                timer1.Start();
            }
            else if (pnl_scroll2.Height == l7.MaximumSize.Height)
            {
                but6 = true;
                b_scroll.ShadowDecoration.Enabled = false;
                animated = pnl_scroll2.MaximumSize.Height / 2;
                timer1.Start();
            }                ///
            pnl_load.Controls.Clear();
            F_CONE cone = new F_CONE();
            cone.TopLevel = false;
            pnl_load.Controls.Add(cone);
            cone.Dock = DockStyle.Fill;
            cone.Show();
        }
    }
}
