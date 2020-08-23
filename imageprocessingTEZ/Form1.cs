using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using AForge;
using AForge.Imaging;
using AForge.Imaging.ColorReduction;
using AForge.Imaging.ComplexFilters;
using AForge.Imaging.Filters;

namespace imageprocessingTEZ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        System.Drawing.Graphics formGraphics;
        bool isDown = false;
        int initialX;
        int initialY;
        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {

            
            if (openFileDialog1.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                pictureBox1.Image = (Bitmap)System.Drawing.Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void grayScaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GrayscaleBT709 gray= new GrayscaleBT709();
            pictureBox2.Image=gray.Apply((Bitmap)pictureBox1.Image);
            pictureBox5.Image = gray.Apply((Bitmap)pictureBox4.Image);


        }

        private void histogramYapmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistogramEqualization histogram = new HistogramEqualization();
            pictureBox3.Image = histogram.Apply((Bitmap)pictureBox2.Image);
            pictureBox6.Image = histogram.Apply((Bitmap)pictureBox5.Image);
        }

        private void resimİşlemeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void arkaplanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pictureBox4.Image = (Bitmap)System.Drawing.Image.FromFile(openFileDialog2.FileName);
                pictureBox10.Image = (Bitmap)System.Drawing.Image.FromFile(openFileDialog2.FileName);
            }
        }

        private void imageSubstractToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // filtre oluşturduk
            Difference filter = new Difference((Bitmap)pictureBox6.Image);
            // uyguladık
            Bitmap cikarim = filter.Apply((Bitmap)pictureBox3.Image);
            pictureBox7.Image = cikarim;


            

                       

        }

        private void otsuÇıkarımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Threshold filter = new Threshold(100);
            // apply the filter
           Bitmap otsu =   filter.Apply((Bitmap)pictureBox7.Image);
           pictureBox8.Image = otsu;
        }

        private void morphologyBoşlukDoldurmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // create filter
            Closing filter = new Closing();
            // apply the filter
            Bitmap morf = filter.Apply((Bitmap)pictureBox8.Image);
            pictureBox9.Image = morf;
        }

        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        
        {
            
           
        }

        private void pictureBox4_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void pictureBox4_MouseUp(object sender, MouseEventArgs e)
        {

            
        }

        private void pictureBox10_MouseUp(object sender, MouseEventArgs e)
        {
            String strpos = "X kordinatı " + initialX.ToString() + " Y kordinatı " + initialY.ToString();
            isDown = false;
            MessageBox.Show(strpos, "Yeni Park Alanı Kaydedildi.", MessageBoxButtons.OK);
        }

        private void pictureBox10_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDown == true)
            {
                this.Refresh();
                Brush Green = new SolidBrush(Color.Green);
                Pen drwaPen = new Pen(Green, 7);
                int width = e.X - initialX, height = e.Y - initialY;
                //if (Math.Sign (width) == -1) width = width 
                //Rectangle rect = new Rectangle(initialPt.X, initialPt.Y, Cursor.Position.X - initialPt.X, Cursor.Position.Y - initialPt.Y);
                Rectangle rect = new Rectangle(initialX, initialY, width * Math.Sign(width), height * Math.Sign(height));

                Graphics graf = pictureBox10.CreateGraphics();




                graf.DrawRectangle(drwaPen, rect);
            }
        }

        private void pictureBox10_MouseDown(object sender, MouseEventArgs e)
        {
            isDown = true;
            initialX = e.X;
            initialY = e.Y;
        }
    }
}
