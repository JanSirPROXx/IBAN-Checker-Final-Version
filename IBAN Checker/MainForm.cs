using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
//Using BigInt
//using BigMath;
using System.Numerics;


//Credits to Jan and Josua
namespace IBAN_Checker
{
    public partial class MainForm : Form
    {

        string IBAN;

        public object IBAN_U { get; private set; }

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IBAN = textBox1.Text;

            string[] IBAN_L = IBAN.Split(' ');
            //Für die Prüfziffer
            string Pruef1 = IBAN_L[0].Insert(2, " ");
            string[] Pruef2 = Pruef1.Split(' ');
            string Pruefziffer = Pruef2[1];
            string CH_ding = Pruef2[0];
            

            string IBAN_N = IBAN_L[1] + IBAN_L[2] + IBAN_L[3] + IBAN_L[4] + IBAN[5] + CH_ding + "00"; 

            //MessageBox.Show(IBAN_N);


            
            //Replace Others
            IBAN_N = IBAN_N.Replace(" ", "");

            //Replace Chars
            IBAN_N = IBAN_N.Replace("A", "10");
            IBAN_N = IBAN_N.Replace("B", "11");
            IBAN_N = IBAN_N.Replace("C", "12");
            IBAN_N = IBAN_N.Replace("D", "13");
            IBAN_N = IBAN_N.Replace("E", "14");
            IBAN_N = IBAN_N.Replace("F", "15");
            IBAN_N = IBAN_N.Replace("G", "16");
            IBAN_N = IBAN_N.Replace("H", "17");
            IBAN_N = IBAN_N.Replace("I", "18");
            IBAN_N = IBAN_N.Replace("J", "19");
            IBAN_N = IBAN_N.Replace("K", "20");
            IBAN_N = IBAN_N.Replace("L", "21");
            IBAN_N = IBAN_N.Replace("M", "22");
            IBAN_N = IBAN_N.Replace("N", "23");
            IBAN_N = IBAN_N.Replace("O", "24");
            IBAN_N = IBAN_N.Replace("P", "25");
            IBAN_N = IBAN_N.Replace("Q", "26");
            IBAN_N = IBAN_N.Replace("R", "27");
            IBAN_N = IBAN_N.Replace("S", "28");
            IBAN_N = IBAN_N.Replace("T", "29");
            IBAN_N = IBAN_N.Replace("U", "30");
            IBAN_N = IBAN_N.Replace("V", "31");
            IBAN_N = IBAN_N.Replace("W", "32");
            IBAN_N = IBAN_N.Replace("X", "33");
            IBAN_N = IBAN_N.Replace("Y", "34");
            IBAN_N = IBAN_N.Replace("Z", "35");
            //...


            textBox2.Text = IBAN_N;

            
            int PrfZ = int.Parse(Pruefziffer);
            BigInteger IBAN_Big1 = BigInteger.Parse(IBAN_N);
            BigInteger IBAN_Big2 = IBAN_Big1 % 97;
            BigInteger IBAN_Big = 98 - IBAN_Big2;

            //Load Date to GUI
            label_pruef.Text = Pruefziffer;
            if(PrfZ == IBAN_Big)
            {
                label_checked.ForeColor = Color.Green;
                label_checked.Text = "Valid";
            }
            else
            {
                label_checked.ForeColor = Color.Red;
                label_checked.Text = "Invalid";
            }
            
            
 

            
            
            //textBox2.Text = IBAN_B.ToString();

        }
    }
}
