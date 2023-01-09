using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bunifufuuf
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            openButton.Visible = true;
            bunifuPanel5.Visible = false;
            this.Size = new Size(467, 862);
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            openButton.Visible = false;
            bunifuPanel5.Visible = true;
            this.Size = new Size(1400, 862);
        }
        

        private void bunifuDropdown1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {


        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuImageButton3_Click_1(object sender, EventArgs e)
        {
            bunifuPanel5.Visible = false;
            flowLayoutPanel2.Visible = false;
            openButton.Visible = false;
            bunifuButton5.Visible = false;
            bunifuTextBox1.Visible = false;
            collapseButton.Visible = false;
            maxButton.Visible = true;
            this.Size = new Size(350, 250);
        }

        private void bunifuButton5_Click(object sender, EventArgs e)
        {
            openButton.Visible = true;
            bunifuPanel5.Visible = false;
            this.Size = new Size(350, 862);
        }

        private void openButton_Click_1(object sender, EventArgs e)
        {
            openButton.Visible = false;
            bunifuPanel5.Visible = true;
            this.Size = new Size(1400, 862);
        }

        private void maxButton_Click(object sender, EventArgs e)
        {
            bunifuPanel5.Visible = true;
            flowLayoutPanel2.Visible = true;
            openButton.Visible = false;
            bunifuButton5.Visible = true;
            bunifuTextBox1.Visible = true;
            collapseButton.Visible = true;
            maxButton.Visible = false;
            this.Size = new Size(1400, 862);
        }
    }
}
