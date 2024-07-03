using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;
using static System.Windows.Forms.LinkLabel;

namespace Space_warrrrr
{
    public partial class Form2 : Form
    {

        public static PictureBox data;
        public static PictureBox datab;
        public static int sath = 1;
        public static string userpath;
        public static bool usercheck = true;
        int usersum = 0;
        public static bool checkbox1;
        int cheked = 1;
        int cheked2 = 1;
        string check;
        bool checkk = true;
        bool checklog = false;


        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cheked == 1)
            {
                data = pictureBox1;
            }

            if (cheked == 2)
            {
                data = pictureBox2;
            }

            if (cheked == 3)
            {
                data = pictureBox3;
            }

            else


            {
                data = pictureBox3;
            }


            if (cheked2 == 1)
            {
                datab = pictureBox4;
            }

            if (cheked2 == 2)
            {
                datab = pictureBox21;
            }

            else


            {
                datab = pictureBox4;
            }

            if (usercheck)
            {
                userpath = Environment.CurrentDirectory + user1.Text + ".txt";
            }

            this.Hide();

            new Form1().ShowDialog();

            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkbox1 = true;

            }

            else
            {
                checkbox1 = false;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cheked++;

            if (cheked >= 4)
            {
                cheked = 1;
            }

            if (cheked == 1)
            {
                pictureBox1.BringToFront();
                pictureBox1.BringToFront();
            }

            if (cheked == 2)
            {
                pictureBox2.BringToFront();
                pictureBox2.BringToFront();
            }

            if (cheked == 3)
            {
                pictureBox3.BringToFront();
                pictureBox3.BringToFront();
            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            cheked--;

            if (cheked <= 0)
            {
                cheked = 3;
            }

            if (cheked == 1)
            {
                pictureBox1.BringToFront();
                pictureBox1.BringToFront();
            }

            if (cheked == 2)
            {
                pictureBox2.BringToFront();
                pictureBox2.BringToFront();
            }

            if (cheked == 3)
            {
                pictureBox3.BringToFront();
                pictureBox3.BringToFront();
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            cheked2++;

            if (cheked2 >= 3)
            {
                cheked2 = 1;
            }

            if (cheked2 == 1)
            {
                pictureBox4.BringToFront();
            }

            if (cheked2 == 2)
            {
                pictureBox21.BringToFront();
            }


        }

        private void button5_Click(object sender, EventArgs e)
        {
            cheked2--;

            if (cheked2 <= 0)
            {
                cheked2 = 2;
            }

            if (cheked2 == 1)
            {
                pictureBox4.BringToFront();
            }

            if (cheked2 == 2)
            {
                pictureBox21.BringToFront();
            }



        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            if (domainUpDown1.Text == "Hard")
            {
                sath = 3;
            }

            if (domainUpDown1.Text == "Medium")
            {
                sath = 2;
            }

            if (domainUpDown1.Text == "Easy")
            {
                sath = 1;
            }


        }

        private void user(object sender, EventArgs e)
        {

            if (usersum % 2 == 0)
            {
                timer1.Enabled = true;
            }

            else
            {
                timer2.Enabled = true;
            }



        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            foreach (Control A in this.Controls)
            {

                if (A.Tag == "us")
                {

                    if (userlable.Location.X >= 437)
                    {
                        A.Location = new Point(A.Location.X - 7, A.Location.Y);

                    }

                    else
                    {
                        usersum++;
                        timer1.Enabled = false;
                        break;
                    }

                }


            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            foreach (Control A in this.Controls)
            {

                if (A.Tag == "us")
                {

                    if (userlable.Location.X <= 590)
                    {
                        A.Location = new Point(A.Location.X + 7, A.Location.Y);

                    }

                    else
                    {
                        usersum++;
                        timer2.Enabled = false;
                        break;
                    }

                }

            }

        }

        private void revaiv(object sender, EventArgs e)
        {
            if (usercheck)
            {

                userpath = Environment.CurrentDirectory + user1.Text + ".txt";

                string textfile = userpath;

                string[] lines = File.ReadAllLines(textfile);

                Form1.score = Convert.ToInt32(lines[0]);
                Form1.armorsum = Convert.ToInt32(lines[1]);
                Form1.armor = Convert.ToInt32(lines[2]);
                Form1.armorpbw = Convert.ToInt32(lines[3]);
                Form1.bulletboost = Convert.ToInt32(lines[4]);

            }

        }

        private void Logout_Click(object sender, EventArgs e)
        {

            usercheck = false;

            button6.Hide();
            Logout.Hide();
            button6.Visible = false;
            Logout.Visible = false;

            user1.Text = "";

            Login.Show();
            signup.Show();
            Login.Visible = true;
            signup.Visible = true;

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            usercheck = false;

            button6.Hide();
            Logout.Hide();
            button6.Visible = false;
            Logout.Visible = false;

            user1.Text = "";

            panel.Hide();
            username.Hide();
            password.Hide();
            Loginok.Hide();
            signupok.Hide();
            Error.Hide();

        }

        private void signup_Click(object sender, EventArgs e)
        {



            check = Environment.CurrentDirectory + "chek.txt";

            string[] lines = File.ReadAllLines(check);

            foreach (string line in lines)
            {
                if (username.Text == line || password.Text == line)
                {
                    checkk = false;
                    break;
                }

            }

            if (checkk)
            {
                string pass = Environment.CurrentDirectory + username.Text + "pass.txt";

                using (StreamWriter writer = new StreamWriter(pass))
                {
                    writer.WriteLine(password.Text);
                }

                check = Environment.CurrentDirectory + "chek.txt";

                using (StreamWriter writer = new StreamWriter(check, true))
                {
                    writer.WriteLine(password.Text);
                    writer.WriteLine(username.Text);

                }

                user1.Text = username.Text;

                Login.Visible = false;
                signup.Visible = false;
                Login.Hide();
                signup.Hide();

                button6.Show();
                Logout.Show();
                button6.Visible = true;
                Logout.Visible = true;

                password.Hide();
                username.Hide();
                Error.Hide();
                panel.Hide();
                signupok.Hide();
                Loginok.Hide();

                usercheck = true;

            }

            else
            {
                Error.Text = "please try again";
            }



        }

        private void Login_Click(object sender, EventArgs e)
        {
            password.Show();
            username.Show();
            Error.Show();
            panel.Show();
            Loginok.Show();

        }

        private void signup_Click_1(object sender, EventArgs e)
        {
            password.Show();
            username.Show();
            Error.Show();
            panel.Show();
            signupok.Show();

        }

        private void Loginok_Click(object sender, EventArgs e)
        {

            check = Environment.CurrentDirectory + "chek.txt";
            string[] lines = File.ReadAllLines(check);

            foreach (string line in lines)
            {
                if (username.Text == line)
                {
                    checklog = true;
                    break;
                }

            }

            if (checklog)
            {
                string pass = Environment.CurrentDirectory + username.Text + "pass.txt";
                string[] liness = File.ReadAllLines(pass);

                if (liness[0] == password.Text)
                {

                    user1.Text = username.Text;

                    Login.Visible = false;
                    signup.Visible = false;
                    Login.Hide();
                    signup.Hide();

                    button6.Show();
                    Logout.Show();
                    button6.Visible = true;
                    Logout.Visible = true;

                    password.Hide();
                    username.Hide();
                    Error.Hide();
                    panel.Hide();
                    signupok.Hide();
                    Loginok.Hide();

                    usercheck = true;

                }

                else
                {
                    Error.Text = "password is wrong";
                }

            }

            else
            {
                Error.Text = "please try again";
            }

        }



    }
}
