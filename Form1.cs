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
    public partial class Form1 : Form
    {
        public Form1()
        {

            Properties.Settings.Default.ButtonKind = 1;
            InitializeComponent();
        }
        void Load1()
        {
            if (Properties.Settings.Default.ButtonKind == 1)
            {
                button11.BackColor = Color.DeepSkyBlue;
                button12.BackColor = Color.DarkGray;
                button13.BackColor = Color.DarkGray;

                button1.Text = Properties.Settings.Default.title1;
                button2.Text = Properties.Settings.Default.title2;
                button3.Text = Properties.Settings.Default.title3;
                button4.Text = Properties.Settings.Default.title4;
                button5.Text = Properties.Settings.Default.title5;
                button6.Text = Properties.Settings.Default.title6;
                button7.Text = Properties.Settings.Default.title7;
                button8.Text = Properties.Settings.Default.title8;
                button9.Text = Properties.Settings.Default.title9;
                button10.Text = Properties.Settings.Default.title10;
            }
            else if (Properties.Settings.Default.ButtonKind == 2)
            {
                button11.BackColor = Color.DarkGray;
                button12.BackColor = Color.DeepSkyBlue;
                button13.BackColor = Color.DarkGray;

                button1.Text = Properties.Settings.Default.title11;
                button2.Text = Properties.Settings.Default.title12;
                button3.Text = Properties.Settings.Default.title13;
                button4.Text = Properties.Settings.Default.title14;
                button5.Text = Properties.Settings.Default.title15;
                button6.Text = Properties.Settings.Default.title16;
                button7.Text = Properties.Settings.Default.title17;
                button8.Text = Properties.Settings.Default.title18;
                button9.Text = Properties.Settings.Default.title19;
                button10.Text = Properties.Settings.Default.title20;
            }
            else if (Properties.Settings.Default.ButtonKind == 3)
            {
                button11.BackColor = Color.DarkGray;
                button12.BackColor = Color.DarkGray;
                button13.BackColor = Color.DeepSkyBlue;

                button1.Text = Properties.Settings.Default.title21;
                button2.Text = Properties.Settings.Default.title22;
                button3.Text = Properties.Settings.Default.title23;
                button4.Text = Properties.Settings.Default.title24;
                button5.Text = Properties.Settings.Default.title25;
                button6.Text = Properties.Settings.Default.title26;
                button7.Text = Properties.Settings.Default.title27;
                button8.Text = Properties.Settings.Default.title28;
                button9.Text = Properties.Settings.Default.title29;
                button10.Text = Properties.Settings.Default.title30;
            }
            button11.Text = Properties.Settings.Default.TabName1;
            button12.Text = Properties.Settings.Default.TabName2;
            button13.Text = Properties.Settings.Default.TabName3;
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            Properties.Settings.Default.ButtonNumber = 1;
            if (e.Button.ToString() == "Left")
            {
                if (Properties.Settings.Default.ButtonKind == 1)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.contents1);
                }
                else if (Properties.Settings.Default.ButtonKind == 2)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.contents11);
                }
                else if (Properties.Settings.Default.ButtonKind == 3)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.contents21);
                }
            }
            else if (e.Button.ToString() == "Right")
            {
                Form2 f = new Form2();
                f.ShowDialog();
            }
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            Properties.Settings.Default.ButtonNumber = 2;
            if (e.Button.ToString() == "Left")
            {
                if (Properties.Settings.Default.ButtonKind == 1)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.contents2);
                }
                else if (Properties.Settings.Default.ButtonKind == 2)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.contents12);
                }
                else if (Properties.Settings.Default.ButtonKind == 3)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.contents22);
                }
            }
            else if (e.Button.ToString() == "Right")
            {
                Form2 f = new Form2();
                f.ShowDialog();
            }
        }

        private void button3_MouseDown(object sender, MouseEventArgs e)
        {
            Properties.Settings.Default.ButtonNumber = 3;
            if (e.Button.ToString() == "Left")
            {
                if (Properties.Settings.Default.ButtonKind == 1)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.contents3);
                }
                else if (Properties.Settings.Default.ButtonKind == 2)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.contents13);
                }
                else if (Properties.Settings.Default.ButtonKind == 3)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.contents23);
                }
            }
            else if (e.Button.ToString() == "Right")
            {
                Form2 f = new Form2();
                f.ShowDialog();
            }
        }

        private void button4_MouseDown(object sender, MouseEventArgs e)
        {
            Properties.Settings.Default.ButtonNumber = 4;
            if (e.Button.ToString() == "Left")
            {
                if (Properties.Settings.Default.ButtonKind == 1)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.contents4);
                }
                else if (Properties.Settings.Default.ButtonKind == 2)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.contents14);
                }
                else if (Properties.Settings.Default.ButtonKind == 3)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.contents24);
                }
            }
            else if (e.Button.ToString() == "Right")
            {
                Form2 f = new Form2();
                f.ShowDialog();
            }
        }

        private void button5_MouseDown(object sender, MouseEventArgs e)
        {
            Properties.Settings.Default.ButtonNumber = 5;
            if (e.Button.ToString() == "Left")
            {
                if (Properties.Settings.Default.ButtonKind == 1)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.contents5);
                }
                else if (Properties.Settings.Default.ButtonKind == 2)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.contents15);
                }
                else if (Properties.Settings.Default.ButtonKind == 3)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.contents25);
                }
            }
            else if (e.Button.ToString() == "Right")
            {
                Form2 f = new Form2();
                f.ShowDialog();
            }
        }

        private void button6_MouseDown(object sender, MouseEventArgs e)
        {
            Properties.Settings.Default.ButtonNumber = 6;
            if (e.Button.ToString() == "Left")
            {
                if (Properties.Settings.Default.ButtonKind == 1)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.contents6);
                }
                else if (Properties.Settings.Default.ButtonKind == 2)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.contents16);
                }
                else if (Properties.Settings.Default.ButtonKind == 3)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.contents26);
                }
            }
            else if (e.Button.ToString() == "Right")
            {
                Form2 f = new Form2();
                f.ShowDialog();
            }
        }

        private void button7_MouseDown(object sender, MouseEventArgs e)
        {
            Properties.Settings.Default.ButtonNumber = 7;
            if (e.Button.ToString() == "Left")
            {
                if (Properties.Settings.Default.ButtonKind == 1)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.contents7);
                }
                else if (Properties.Settings.Default.ButtonKind == 2)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.contents17);
                }
                else if (Properties.Settings.Default.ButtonKind == 3)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.contents27);
                }
            }
            else if (e.Button.ToString() == "Right")
            {
                Form2 f = new Form2();
                f.ShowDialog();
            }
        }

        private void button8_MouseDown(object sender, MouseEventArgs e)
        {
            Properties.Settings.Default.ButtonNumber = 8;
            if (e.Button.ToString() == "Left")
            {
                if (Properties.Settings.Default.ButtonKind == 1)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.contents8);
                }
                else if (Properties.Settings.Default.ButtonKind == 2)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.contents18);
                }
                else if (Properties.Settings.Default.ButtonKind == 3)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.contents28);
                }
            }
            else if (e.Button.ToString() == "Right")
            {
                Form2 f = new Form2();
                f.ShowDialog();
            }
        }

        private void button9_MouseDown(object sender, MouseEventArgs e)
        {
            Properties.Settings.Default.ButtonNumber = 9;
            if (e.Button.ToString() == "Left")
            {
                if (Properties.Settings.Default.ButtonKind == 1)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.contents9);
                }
                else if (Properties.Settings.Default.ButtonKind == 2)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.contents19);
                }
                else if (Properties.Settings.Default.ButtonKind == 3)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.contents29);
                }
            }
            else if (e.Button.ToString() == "Right")
            {
                Form2 f = new Form2();
                f.ShowDialog();
            }
        }

        private void button10_MouseDown(object sender, MouseEventArgs e)
        {
            Properties.Settings.Default.ButtonNumber = 10;
            if (e.Button.ToString() == "Left")
            {
                if (Properties.Settings.Default.ButtonKind == 1)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.contents10);
                }
                else if (Properties.Settings.Default.ButtonKind == 2)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.contents20);
                }
                else if (Properties.Settings.Default.ButtonKind == 3)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.contents30);
                }
            }
            else if (e.Button.ToString() == "Right")
            {
                Form2 f = new Form2();
                f.ShowDialog();
            }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            Load1();
        }

        private void button11_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button.ToString() == "Left")
            {
                Properties.Settings.Default.ButtonKind = 1;
                Load1();
            }
            else if (e.Button.ToString() == "Right")
            {
                Form3 f = new Form3();
                f.ShowDialog();
            }
        }

        private void button12_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button.ToString() == "Left")
            {
                Properties.Settings.Default.ButtonKind = 2;
                Load1();
            }
            else if (e.Button.ToString() == "Right")
            {
                Form3 f = new Form3();
                f.ShowDialog();
            }
        }

        private void button13_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button.ToString() == "Left")
            {
                Properties.Settings.Default.ButtonKind = 3;
                Load1();
            }
            else if (e.Button.ToString() == "Right")
            {
                Form3 f = new Form3();
                f.ShowDialog();
            }
        }
    }   

}
