using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalTextEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // making the font BOLD
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.textBox1.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }
        // making the font ITALIC
        private void iToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Font = new Font("SuperFrench", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
        }
        // making the font UNDERLINED
        private void uToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Font = new Font("Constantia", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }
        // making the font RED
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.textBox1.ForeColor = Color.Red;
        }
        // making the font BLUE
        private void bToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.ForeColor = Color.Blue;
        }
        // making the font GREEN
        private void gToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.ForeColor = Color.Green;
        }
        // making the font BLACK
        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.ForeColor = Color.Black;
        }
        // making the background BLACK AND FORECOLOR WHITE
        private void bGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.BackColor = Color.Black;
            this.textBox1.ForeColor = Color.White;
        }
        // making back white and fore black
        private void backWhiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.BackColor = Color.White;
            this.textBox1.ForeColor = Color.Black;
        }
        // clearing everything
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
        }
        // making the font default
        private void defaultFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        }
    }
}
