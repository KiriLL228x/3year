using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RJD
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void FilterBtn_Click(object sender, EventArgs e)
        {
           if(FilterPanel.Height < 143)
            {
                FilterPanel.Height = 143;
            }
           else
            {
                FilterPanel.Height = FilterBtn.Size.Height;
            }
        }

        private void Poezd_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            PoezdForm PoezdForm = new PoezdForm(pb.Tag.ToString());
            PoezdForm.ShowDialog();
        }
    }
}
