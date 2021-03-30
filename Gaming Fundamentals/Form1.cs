using DocumentFormat.OpenXml.Drawing.Diagrams;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gaming_Fundamentals
{
    enum Direction
    {
        Left, Right, Up, Down
    } 
    public partial class Form1 : Form
    {
        int x_position, y_position;
        int my_height, my_width;
        int min_height = 50, min_width = 50;
        int max_height = 160, max_width = 380;
        Boolean size_is_expanding = true;
        Boolean arrow_keys_active = true;
        string animation_mode = "none of these";  // move or size or spin or none_of_these to stop all animations
        Direction my_direction;
        Image img;

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (arrow_keys_active)
            {
                if(e.KeyCode == Keys.Left)
                {
                    my_direction = Direction.Left;
                }
                else if (e.KeyCode == Keys.Right)
                {
                    my_direction = Direction.Right;
                }
                else if (e.KeyCode == Keys.Up)
                {
                    my_direction = Direction.Up;
                }
                else if (e.KeyCode == Keys.Down)
                {
                    my_direction = Direction.Down;
                }
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left && arrow_keys_active == false)
            {
                pictureBox1.Left = e.X;
                pictureBox1.Top = e.Y;
            }
        }

        

        private void ChangeImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }

        private void ResizeImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Height = 150;
            pictureBox1.Width = 250;
            pictureBox1.Top = 150;
            pictureBox1.Left = 250;
            animation_mode = "size";
        }

        private void RotateImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Height = 150;
            pictureBox1.Width = 250;
            pictureBox1.Top = 150;
            pictureBox1.Left = 250;
            animation_mode = "spin";
        }

        private void ArrowKeysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            arrow_keys_active = true;
            pictureBox1.Height = 150;
            pictureBox1.Width = 250;
            pictureBox1.Top = 150;
            pictureBox1.Left = 250;
            animation_mode = "move";
        }

        private void LeftMouseButtonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            arrow_keys_active = false;
            pictureBox1.Height = 150;
            pictureBox1.Width = 250;
            pictureBox1.Top = 150;
            pictureBox1.Left = 250;
            animation_mode = "move";
        }

        private void DoubleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoubleBuffered = true;
        }

        private void SingleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoubleBuffered = false;
        }

        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            animation_mode = "none_of_these";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(animation_mode == "size")
            {
                if(my_height < max_height && my_width < max_width && size_is_expanding)
                {
                    my_height = my_height + 10;
                    my_width = my_width + 10;
                }
                else if(my_height == max_height && my_width < max_width && size_is_expanding)
                {
                    my_width += 10;
                }
                else if(my_width == max_width && my_height == max_height)
                {
                    my_height -= 10;
                    my_width -= 10;
                    size_is_expanding = false;
                }
                else if(my_height > min_height && my_width > min_width)
                {
                    my_width -= 10;
                    my_height -= 10;
                }
                else if(my_width > min_width)
                {
                    my_width -= 10;
                }
                else if(my_height == min_height && my_width == min_width)
                {
                    my_height += 10;
                    my_width += 10;
                    size_is_expanding = true;
                }

                pictureBox1.Height = my_height;
                pictureBox1.Width = my_width;
            }

            else if(animation_mode == "move" && arrow_keys_active == true)
            {
                if(my_direction == Direction.Right)
                {
                    x_position += 10;
                }
                else if (my_direction == Direction.Left)
                {
                    x_position -= 10;
                }
                else if (my_direction == Direction.Up)
                {
                    y_position += 10;
                }
                else if (my_direction == Direction.Down)
                {
                    y_position -= 10;
                }

                pictureBox1.Left = x_position;
                pictureBox1.Top = y_position;
            }
            else if(animation_mode == "spin")
            {
                img.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pictureBox1.Image = img;
            }
            Invalidate();
        }

        public Form1()
        {
            InitializeComponent();
            pictureBox1.Height = 150;
            pictureBox1.Width = 250;
            pictureBox1.Top = 150;
            pictureBox1.Left = 250;
            my_direction = Direction.Right;
            img = pictureBox1.Image;
        }


    }
}
