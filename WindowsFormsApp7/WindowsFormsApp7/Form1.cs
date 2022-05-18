using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

            Random sıfre = new Random();
            int harf1 = sıfre.Next(65, 90);
            char mht1;
            mht1 = Convert.ToChar(harf1);
            int harf2 = sıfre.Next(97, 122);
            char mht2;
            mht2 = Convert.ToChar(harf2);
           
            int rakam;
            int rakam1;
          
           rakam = sıfre.Next(1, 9);
            rakam1 = sıfre.Next(1, 6);
            int ozelkrktr = sıfre.Next(98, 123);
            char ozelkrkt;
            ozelkrkt = Convert.ToChar(ozelkrktr);
           
            textBox1.Text = rakam.ToString() +  mht1 +  rakam1.ToString() +mht2+   rakam1.ToString()+mht1 + mht2 +  rakam.ToString() + ozelkrkt+rakam1.ToString();
            
            
            
        }
    }
}
