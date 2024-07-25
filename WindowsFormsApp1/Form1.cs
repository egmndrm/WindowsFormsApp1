using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        double net;
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tDogru = Convert.ToInt16(txbTurkceDogru.Text);
            int tYanlis = Convert.ToInt16(txbTurkceYanlis.Text);
            int mDogru = Convert.ToInt16(txbMatDogru.Text);
            int mYanlis = Convert.ToInt16(txbMatYanlis.Text);
            txbTurkceNet.Text= Convert.ToString(tDogru - (tYanlis / 4));
            txbMatematikNet.Text = Convert.ToString(mDogru - (mYanlis / 4));  
            


        }
    }
}
