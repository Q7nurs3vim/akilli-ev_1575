using System.Collections.Generic;
using System.Windows.Forms;

namespace akıllı_ev_1575
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                listBox1.Items.Add("Lambalar Açık");
            }
            else
            {
                listBox1.Items.Add("Lambalar Kapalı");
            }
            if (checkBox2.Checked == true)
            {
                listBox1.Items.Add("Kombi Açık");
            }
            else
            {
                listBox1.Items.Add("Kombi Kapalı");
            }
            

        }
    }
}