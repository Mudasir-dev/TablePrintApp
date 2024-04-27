using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TablePrintApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int table = Convert.ToInt32(textBox1.Text);
            int start = Convert.ToInt32(textBox2.Text);
            int end= Convert.ToInt32(textBox3.Text);

            string result;

            for (int i = start; i <= end; i++)
            {
                result = table+"x"+ i+ "="+(table*i)+"\t"+"\n";
                txtResult.AppendText(result);
                
            }
            

        }
        private void txtTable_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
