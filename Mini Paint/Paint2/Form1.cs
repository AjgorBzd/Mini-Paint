using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;

namespace Paint2
{
    public partial class MiniPaint : Form
    {
        public ComponentResourceManager langhandler;
        bool brush = false;
        private Bitmap drawArea;
        int x,y;
        bool move = false;
        private Graphics g;
        bool rect = false, elip = false;
        Point draw;
        bool langg = false; // false = english, true = polish
        
        Pen p;
        public MiniPaint()
        {
            this.langhandler = new ComponentResourceManager(this.GetType());
            InitializeComponent();
            Chosen_color.BackColor = Color.Black;
            drawArea = new Bitmap(Canvas.Size.Width, Canvas.Size.Height);
            Canvas.Image = drawArea;
            g = Canvas.CreateGraphics();
            CultureInfo.CurrentUICulture = new CultureInfo("en");
            
            //g.Clear(Color.Red);
            p = new Pen(Color.Black, 2);
           foreach (KnownColor color in Enum.GetValues(typeof(KnownColor)))
            {
                Button bb = new Button();
                bb.BackColor = Color.FromKnownColor(color);
                bb.Size = new(25, 25);
                bb.Click += new EventHandler(button_Click);
                bb.Name = color.ToString();
                FlowPanel.Controls.Add(bb);
            }
            FlowPanel.AutoScroll = true;
            FlowPanel.WrapContents = false;
            English.Checked = true;   
            Thiccness.SelectedIndex = 1;
            
        }
        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            p.Color = Color.FromName(button.Name);
            Chosen_color.BackColor = p.Color;

        }
        


        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            move= true;
            x = e.X;
            y = e.Y;
            draw = e.Location;

        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (move && brush)
                {
                    using (Graphics pplz = Graphics.FromImage(drawArea))
                    {
                        pplz.DrawLine(p, new Point(x, y), e.Location);
                    }
                    x = e.X;
                    y = e.Y;
                    //Canvas.Refresh();
                }
                if(move&&rect)
                {
                    Bitmap tmp = new Bitmap(drawArea, Canvas.Size.Width, Canvas.Size.Height);
                    Canvas.Image = tmp;
                    using (Graphics pplz = Graphics.FromImage(tmp))
                        pplz.DrawRectangle(p, Math.Min(e.X, x), Math.Min(e.Y, y), Math.Abs(e.X - x), Math.Abs(e.Y - y));
                }
                if(move&&elip)
                {
                    Bitmap tmp = new Bitmap(drawArea, Canvas.Size.Width, Canvas.Size.Height);
                    Canvas.Image = tmp;
                    using (Graphics pplz = Graphics.FromImage(tmp))
                        pplz.DrawEllipse(p, Math.Min(e.X, x), Math.Min(e.Y, y), Math.Abs(e.X - x), Math.Abs(e.Y - y));
                }
                Canvas.Refresh();
            }
            if(e.Button==MouseButtons.Right)
            {
                move = false;
            }
            //Canvas.Invalidate();
        }

        private void Canvas_MouseUp(object sender, MouseEventArgs e)
        {
            Canvas.Image = drawArea;
           if(e.Button==MouseButtons.Left)
            {

               if(move)
                {
                    if (rect)
                    {
                        using (Graphics rys = Graphics.FromImage(drawArea))
                        {
                            rys.DrawRectangle(p, Math.Min(e.X, x), Math.Min(e.Y, y), Math.Abs(e.X - draw.X), Math.Abs(e.Y - draw.Y));
                        }
                        Canvas.Refresh();
                    }
                    else if (elip)
                    {
                        using (Graphics rys = Graphics.FromImage(drawArea))
                            rys.DrawEllipse(p, x, y, e.X - x, e.Y - y);
                    }
                }
                Canvas.Refresh();
                move = false;
            }
           if(e.Button==MouseButtons.Right)
            {
                move = false;
            }
        }

        private void Canvas_SizeChanged(object sender, EventArgs e)
        {
            Bitmap tmp = new Bitmap(Canvas.Size.Width, Canvas.Size.Height);
            using (Graphics g2 = Graphics.FromImage(tmp))
            {
                g2.DrawImage(drawArea, new Point(0, 0));
            }
            drawArea = tmp;
            Canvas.Image = drawArea;
            Canvas.Refresh();



            //Canvas.Refresh();
            //Canvas.Invalidate();
            //Canvas.Image = tmp;
            //label1.Text = String.Format("{0} {1}", Canvas.Size.Width, Canvas.Size.Height);
        }

        private void Tools_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Rectangle_Click(object sender, EventArgs e)
        {
            if (rect) 
            {
                rect = false;
                Rectangle.Checked = false;
            }
            else
            {
                Ellipse.Checked = false;
                Brush.Checked = false;
                Rectangle.Checked = true;
                rect = true;
                brush = false;
                elip = false;
            }
        }

        private void Ellipse_Click(object sender, EventArgs e)
        {
            if (elip)
            {
                elip = false;
                Ellipse.Checked = false;
            }

            else
            {
                Ellipse.Checked = true;
                Brush.Checked = false;
                Rectangle.Checked = false;
                elip = true;
                brush = false;
                rect = false;
            }
        }

        private void Thiccness_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToolStripComboBox comboBox = (ToolStripComboBox)sender;
            int radius = Convert.ToInt32(comboBox.SelectedItem);
            p.Width = radius;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Save Image...";
            save.Filter = "bmp files (*.bmp)|*.bmp; jpeg files (*.jpeg)|*.jpeg; png files (*.png)|*.png";
            if (save.ShowDialog() == DialogResult.OK)
            {
                drawArea.Save(save.FileName);
            }
        }

        private void Load_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog load = new OpenFileDialog())
            {
                load.Title = "Open Image...";
                load.Filter = "bmp files (*.bmp)|*.bmp; jpeg files (*.jpeg)|*.jpeg; png files (*.png)|*.png";

                if (load.ShowDialog() == DialogResult.OK)
                {
                    drawArea = new Bitmap(load.FileName);
                    int width_difference = drawArea.Width - Canvas.Width;
                    int height_difference = drawArea.Height - Canvas.Height;
                    Size = new Size(Size.Width + width_difference, Size.Height + height_difference);
                    Canvas.Image = drawArea;
                }
            }
        }

        private void English_Click(object sender, EventArgs e)
        {
            English.Checked = true;
            Polish.Checked = false;
            
        }

        private void Polish_Click(object sender, EventArgs e)
        {
            English.Checked = false;
            Polish.Checked = true;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            using (Graphics pplz = Graphics.FromImage(drawArea))
                pplz.Clear(Color.White);
            Canvas.Refresh();
        }

        private void Brush_Click(object sender, EventArgs e)
        {
            if (brush)
            {
                brush = false;
                Brush.Checked = false;
            }
            else
            {
                Brush.Checked = true;
                Rectangle.Checked = false;
                Ellipse.Checked = false;
                brush = true;
                rect = false;
                elip = false;
            }
            
        }
    }
}
