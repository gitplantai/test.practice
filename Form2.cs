using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1_コピペ_
{
    public partial class Form2 : Form
    {
        int buttonKind;
        int buttonNumber;
        public Form2()
        {
            InitializeComponent();
            Load1();
        }
        void Load1()
        {
            if (Properties.Settings.Default.ButtonKind == 1)
            {
                if (Properties.Settings.Default.ButtonNumber == 1)
                {
                    textBox1.Text = Properties.Settings.Default.title1;
                    textBox2.Text = Properties.Settings.Default.contents1;
                }
                else if (Properties.Settings.Default.ButtonNumber == 2)
                {
                    textBox1.Text = Properties.Settings.Default.title2;
                    textBox2.Text = Properties.Settings.Default.contents2;
                }
                else if (Properties.Settings.Default.ButtonNumber == 3)
                {
                    textBox1.Text = Properties.Settings.Default.title3;
                    textBox2.Text = Properties.Settings.Default.contents3;
                }
                else if (Properties.Settings.Default.ButtonNumber == 4)
                {
                    textBox1.Text = Properties.Settings.Default.title4;
                    textBox2.Text = Properties.Settings.Default.contents4;
                }
                else if (Properties.Settings.Default.ButtonNumber == 5)
                {
                    textBox1.Text = Properties.Settings.Default.title5;
                    textBox2.Text = Properties.Settings.Default.contents5;
                }
                else if (Properties.Settings.Default.ButtonNumber == 6)
                {
                    textBox1.Text = Properties.Settings.Default.title6;
                    textBox2.Text = Properties.Settings.Default.contents6;
                }
                else if (Properties.Settings.Default.ButtonNumber == 7)
                {
                    textBox1.Text = Properties.Settings.Default.title7;
                    textBox2.Text = Properties.Settings.Default.contents7;
                }
                else if (Properties.Settings.Default.ButtonNumber == 8)
                {
                    textBox1.Text = Properties.Settings.Default.title8;
                    textBox2.Text = Properties.Settings.Default.contents8;
                }
                else if (Properties.Settings.Default.ButtonNumber == 9)
                {
                    textBox1.Text = Properties.Settings.Default.title9;
                    textBox2.Text = Properties.Settings.Default.contents9;
                }
                else if (Properties.Settings.Default.ButtonNumber == 10)
                {
                    textBox1.Text = Properties.Settings.Default.title10;
                    textBox2.Text = Properties.Settings.Default.contents10;
                }
            }
            else if (Properties.Settings.Default.ButtonKind == 2)
            {
                if (Properties.Settings.Default.ButtonNumber == 1)
                {
                    textBox1.Text = Properties.Settings.Default.title11;
                    textBox2.Text = Properties.Settings.Default.contents11;
                }
                else if (Properties.Settings.Default.ButtonNumber == 2)
                {
                    textBox1.Text = Properties.Settings.Default.title12;
                    textBox2.Text = Properties.Settings.Default.contents12;
                }
                else if (Properties.Settings.Default.ButtonNumber == 3)
                {
                    textBox1.Text = Properties.Settings.Default.title13;
                    textBox2.Text = Properties.Settings.Default.contents13;
                }
                else if (Properties.Settings.Default.ButtonNumber == 4)
                {
                    textBox1.Text = Properties.Settings.Default.title14;
                    textBox2.Text = Properties.Settings.Default.contents14;
                }
                else if (Properties.Settings.Default.ButtonNumber == 5)
                {
                    textBox1.Text = Properties.Settings.Default.title15;
                    textBox2.Text = Properties.Settings.Default.contents15;
                }
                else if (Properties.Settings.Default.ButtonNumber == 6)
                {
                    textBox1.Text = Properties.Settings.Default.title16;
                    textBox2.Text = Properties.Settings.Default.contents16;
                }
                else if (Properties.Settings.Default.ButtonNumber == 7)
                {
                    textBox1.Text = Properties.Settings.Default.title17;
                    textBox2.Text = Properties.Settings.Default.contents17;
                }
                else if (Properties.Settings.Default.ButtonNumber == 8)
                {
                    textBox1.Text = Properties.Settings.Default.title18;
                    textBox2.Text = Properties.Settings.Default.contents18;
                }
                else if (Properties.Settings.Default.ButtonNumber == 9)
                {
                    textBox1.Text = Properties.Settings.Default.title19;
                    textBox2.Text = Properties.Settings.Default.contents19;
                }
                else if (Properties.Settings.Default.ButtonNumber == 10)
                {
                    textBox1.Text = Properties.Settings.Default.title20;
                    textBox2.Text = Properties.Settings.Default.contents20;
                }
            }
            else if (Properties.Settings.Default.ButtonKind == 3)
            {
                if (Properties.Settings.Default.ButtonNumber == 1)
                {
                    textBox1.Text = Properties.Settings.Default.title21;
                    textBox2.Text = Properties.Settings.Default.contents21;
                }
                else if (Properties.Settings.Default.ButtonNumber == 2)
                {
                    textBox1.Text = Properties.Settings.Default.title22;
                    textBox2.Text = Properties.Settings.Default.contents22;
                }
                else if (Properties.Settings.Default.ButtonNumber == 3)
                {
                    textBox1.Text = Properties.Settings.Default.title23;
                    textBox2.Text = Properties.Settings.Default.contents23;
                }
                else if (Properties.Settings.Default.ButtonNumber == 4)
                {
                    textBox1.Text = Properties.Settings.Default.title24;
                    textBox2.Text = Properties.Settings.Default.contents24;
                }
                else if (Properties.Settings.Default.ButtonNumber == 5)
                {
                    textBox1.Text = Properties.Settings.Default.title25;
                    textBox2.Text = Properties.Settings.Default.contents25;
                }
                else if (Properties.Settings.Default.ButtonNumber == 6)
                {
                    textBox1.Text = Properties.Settings.Default.title26;
                    textBox2.Text = Properties.Settings.Default.contents26;
                }
                else if (Properties.Settings.Default.ButtonNumber == 7)
                {
                    textBox1.Text = Properties.Settings.Default.title27;
                    textBox2.Text = Properties.Settings.Default.contents27;
                }
                else if (Properties.Settings.Default.ButtonNumber == 8)
                {
                    textBox1.Text = Properties.Settings.Default.title28;
                    textBox2.Text = Properties.Settings.Default.contents28;
                }
                else if (Properties.Settings.Default.ButtonNumber == 9)
                {
                    textBox1.Text = Properties.Settings.Default.title29;
                    textBox2.Text = Properties.Settings.Default.contents29;
                }
                else if (Properties.Settings.Default.ButtonNumber == 10)
                {
                    textBox1.Text = Properties.Settings.Default.title30;
                    textBox2.Text = Properties.Settings.Default.contents30;
                }
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            buttonKind = Properties.Settings.Default.ButtonKind;
            buttonNumber = Properties.Settings.Default.ButtonNumber;

            if (buttonKind == 1)
            {
                if (buttonNumber == 1)
                {
                    Properties.Settings.Default.title1 = textBox1.Text;
                    Properties.Settings.Default.contents1 = textBox2.Text;
                }
                else if (buttonNumber == 2)
                {
                    Properties.Settings.Default.title2 = textBox1.Text;
                    Properties.Settings.Default.contents2 = textBox2.Text;
                }
                else if (buttonNumber == 3)
                {
                    Properties.Settings.Default.title3 = textBox1.Text;
                    Properties.Settings.Default.contents3 = textBox2.Text;
                }
                else if (buttonNumber == 4)
                {
                    Properties.Settings.Default.title4 = textBox1.Text;
                    Properties.Settings.Default.contents4 = textBox2.Text;
                }
                else if (buttonNumber == 5)
                {
                    Properties.Settings.Default.title5 = textBox1.Text;
                    Properties.Settings.Default.contents5 = textBox2.Text;
                }
                else if (buttonNumber == 6)
                {
                    Properties.Settings.Default.title6 = textBox1.Text;
                    Properties.Settings.Default.contents6 = textBox2.Text;
                }
                else if (buttonNumber == 7)
                {
                    Properties.Settings.Default.title7 = textBox1.Text;
                    Properties.Settings.Default.contents7 = textBox2.Text;
                }
                else if (buttonNumber == 8)
                {
                    Properties.Settings.Default.title8 = textBox1.Text;
                    Properties.Settings.Default.contents8 = textBox2.Text;
                }
                else if (buttonNumber == 9)
                {
                    Properties.Settings.Default.title9 = textBox1.Text;
                    Properties.Settings.Default.contents9 = textBox2.Text;
                }
                else if (buttonNumber == 10)
                {
                    Properties.Settings.Default.title10 = textBox1.Text;
                    Properties.Settings.Default.contents10 = textBox2.Text;
                }
            }
            else if (buttonKind == 2)
            {
                if (buttonNumber == 1)
                {
                    Properties.Settings.Default.title11 = textBox1.Text;
                    Properties.Settings.Default.contents11 = textBox2.Text;
                }
                else if (buttonNumber == 2)
                {
                    Properties.Settings.Default.title12 = textBox1.Text;
                    Properties.Settings.Default.contents12 = textBox2.Text;
                }
                else if (buttonNumber == 3)
                {
                    Properties.Settings.Default.title13 = textBox1.Text;
                    Properties.Settings.Default.contents13 = textBox2.Text;
                }
                else if (buttonNumber == 4)
                {
                    Properties.Settings.Default.title14 = textBox1.Text;
                    Properties.Settings.Default.contents14 = textBox2.Text;
                }
                else if (buttonNumber == 5)
                {
                    Properties.Settings.Default.title15 = textBox1.Text;
                    Properties.Settings.Default.contents15 = textBox2.Text;
                }
                else if (buttonNumber == 6)
                {
                    Properties.Settings.Default.title16 = textBox1.Text;
                    Properties.Settings.Default.contents16 = textBox2.Text;
                }
                else if (buttonNumber == 7)
                {
                    Properties.Settings.Default.title17 = textBox1.Text;
                    Properties.Settings.Default.contents17 = textBox2.Text;
                }
                else if (buttonNumber == 8)
                {
                    Properties.Settings.Default.title18 = textBox1.Text;
                    Properties.Settings.Default.contents18 = textBox2.Text;
                }
                else if (buttonNumber == 9)
                {
                    Properties.Settings.Default.title19 = textBox1.Text;
                    Properties.Settings.Default.contents19 = textBox2.Text;
                }
                else if (buttonNumber == 10)
                {
                    Properties.Settings.Default.title20 = textBox1.Text;
                    Properties.Settings.Default.contents20 = textBox2.Text;
                }
            }
            else if (buttonKind == 3)
            {
                if (buttonNumber == 1)
                {
                    Properties.Settings.Default.title21 = textBox1.Text;
                    Properties.Settings.Default.contents21 = textBox2.Text;
                }
                else if (buttonNumber == 2)
                {
                    Properties.Settings.Default.title22 = textBox1.Text;
                    Properties.Settings.Default.contents22 = textBox2.Text;
                }
                else if (buttonNumber == 3)
                {
                    Properties.Settings.Default.title23 = textBox1.Text;
                    Properties.Settings.Default.contents23 = textBox2.Text;
                }
                else if (buttonNumber == 4)
                {
                    Properties.Settings.Default.title24 = textBox1.Text;
                    Properties.Settings.Default.contents24 = textBox2.Text;
                }
                else if (buttonNumber == 5)
                {
                    Properties.Settings.Default.title25 = textBox1.Text;
                    Properties.Settings.Default.contents25 = textBox2.Text;
                }
                else if (buttonNumber == 6)
                {
                    Properties.Settings.Default.title26 = textBox1.Text;
                    Properties.Settings.Default.contents26 = textBox2.Text;
                }
                else if (buttonNumber == 7)
                {
                    Properties.Settings.Default.title27 = textBox1.Text;
                    Properties.Settings.Default.contents27 = textBox2.Text;
                }
                else if (buttonNumber == 8)
                {
                    Properties.Settings.Default.title28 = textBox1.Text;
                    Properties.Settings.Default.contents28 = textBox2.Text;
                }
                else if (buttonNumber == 9)
                {
                    Properties.Settings.Default.title29 = textBox1.Text;
                    Properties.Settings.Default.contents29 = textBox2.Text;
                }
                else if (buttonNumber == 10)
                {
                    Properties.Settings.Default.title30 = textBox1.Text;
                    Properties.Settings.Default.contents30 = textBox2.Text;
                }
            }
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}