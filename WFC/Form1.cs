using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WFC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null) return;
            pictureBox1.Image = SynTex.Generate((Bitmap)pictureBox1.Image,method: comboBox1.Text, K: (int)numericUpDown1.Value, N: (int)numericUpDown2.Value, M: (int)numericUpDown3.Value, polish: (int)numericUpDown4.Value, t: (double)numericUpDown5.Value, OW:(int)(pictureBox1.Image.Width*numericUpDown6.Value),OH:(int)(pictureBox1.Image.Height * numericUpDown6.Value));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            pictureBox1.Image = Bitmap.FromFile(openFileDialog1.FileName);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            if (pictureBox1.Image == null) return;
            pictureBox1.Image.Save(saveFileDialog1.FileName);
        }
    }
}
