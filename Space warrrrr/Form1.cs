
using System.Windows.Forms;

namespace Space_warrrrr
{
    public partial class Form1 : Form
    {
        

        Random hurtrandom = new Random();
        int label1sum;
        int label2sum;
        public static int armorsum = 3;
        int j2armorsum = 3;
        bool f = true;
        bool j2f = true;
        bool g = true;
        bool j2g = true;
        bool chek = false;
        bool j2chek = false;
        bool Enterchek = false;
        public static int armor = 3;
        int j2armor = 3;
        public static int score = 0;
        int rn = 100;
        int sum = 1;
        int sum2 = 1;
        int j2sum = 1;
        int j2sum2 = 1;
        int pbwsum = 1;
        public static int armorpbw = 1;
        bool levelup = false;
        bool j2levelup = false;
        bool checkbox1;
        public static int bulletboost = 1;
        int move = 12;
        int giantarmor = 1000;
        bool Autopilot = false;

        bool giantmove = false;


        bool bullet1 = false;
        bool bullet2 = false;
        bool bullet3 = false;
        bool bullet4 = false;
        bool bullet5 = false;
        bool bullet6 = false;
        bool bullet7 = false;
        bool bullet8 = false;
        bool bullet9 = false;
        bool bullet10 = false;
        bool bullet11 = false;
        bool bullet12 = false;
        bool bullet13 = false;
        bool bullet1t = false;
        bool bullet2t = false;
        bool bullet3t = false;
        bool bullet4t = false;
        bool bullet5t = false;
        bool bullet6t = false;
        bool bullet7t = false;
        bool bullet8t = false;
        bool bullet9t = false;
        bool bullet10t = false;
        bool bullet11t = false;
        bool bullet12t = false;
        bool bullet13t = false;
        bool j2bullet1 = false;
        bool j2bullet2 = false;
        bool j2bullet3 = false;
        bool j2bullet4 = false;
        bool j2bullet5 = false;
        bool j2bullet6 = false;
        bool j2bullet7 = false;
        bool j2bullet8 = false;
        bool j2bullet9 = false;
        bool j2bullet10 = false;
        bool j2bullet11 = false;
        bool j2bullet12 = false;
        bool j2bullet13 = false;
        bool j2bullet1t = false;
        bool j2bullet2t = false;
        bool j2bullet3t = false;
        bool j2bullet4t = false;
        bool j2bullet5t = false;
        bool j2bullet6t = false;
        bool j2bullet7t = false;
        bool j2bullet8t = false;
        bool j2bullet9t = false;
        bool j2bullet10t = false;
        bool j2bullet11t = false;
        bool j2bullet12t = false;
        bool j2bullet13t = false;

        bool cheettest = false;
        bool auto = true;

        Image originalImage;

        string armortable = Environment.CurrentDirectory + "\\armortable.txt";

        PictureBox[] pb = new PictureBox[14];
        PictureBox[] pb2 = new PictureBox[14];
        PictureBox[] jet2pb = new PictureBox[14];
        PictureBox[] jet2pb2 = new PictureBox[14];
        PictureBox[] pbw = new PictureBox[4];
        PictureBox[] armorbox = new PictureBox[3];
        PictureBox[] j2armorbox = new PictureBox[3];
        PictureBox[] star = new PictureBox[35];
        PictureBox[] gianbullet = new PictureBox[6];
        int[] pbwarmor = { 1, 1, 1, 1 };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            checkbox1 = Form2.checkbox1;
            pictureBox1.Image = Form2.data.Image;
            pictureBox01.Image = Form2.data.Image;


            if (Form2.sath == 2)
            {

                armorpbw = 3;

                giantarmor = 150;
                pbwarmor[0] = 2;
                pbwarmor[1] = 2;
                pbwarmor[2] = 2;
                pbwarmor[3] = 2;
            }

            if (Form2.sath == 3)
            {
                armorpbw = 4;
                giantarmor = 200;
                pbwarmor[0] = 3;
                pbwarmor[1] = 3;
                pbwarmor[2] = 3;
                pbwarmor[3] = 3;
            }


            gianbullet[0] = giantbullet1;
            gianbullet[1] = giantbullet2;
            gianbullet[2] = giantbullet3;
            gianbullet[3] = giantbullet4;
            gianbullet[4] = giantbullet5;
            gianbullet[5] = giantbullet6;


            pictureBox8.Image = Form2.datab.Image;
            pictureBox9.Image = Form2.datab.Image;
            pictureBox10.Image = Form2.datab.Image;
            pictureBox11.Image = Form2.datab.Image;
            pictureBox12.Image = Form2.datab.Image;
            pictureBox13.Image = Form2.datab.Image;
            pictureBox14.Image = Form2.datab.Image;
            pictureBox15.Image = Form2.datab.Image;
            pictureBox16.Image = Form2.datab.Image;
            pictureBox17.Image = Form2.datab.Image;
            pictureBox18.Image = Form2.datab.Image;
            pictureBox19.Image = Form2.datab.Image;
            pictureBox20.Image = Form2.datab.Image;
            pictureBox21.Image = Form2.datab.Image;
            pictureBox6.Image = Form2.datab.Image;
            pictureBox7.Image = Form2.datab.Image;
            pictureBox22.Image = Form2.datab.Image;
            pictureBox23.Image = Form2.datab.Image;
            pictureBox24.Image = Form2.datab.Image;
            pictureBox25.Image = Form2.datab.Image;
            pictureBox26.Image = Form2.datab.Image;
            pictureBox27.Image = Form2.datab.Image;
            pictureBox28.Image = Form2.datab.Image;
            pictureBox29.Image = Form2.datab.Image;
            pictureBox30.Image = Form2.datab.Image;
            pictureBox31.Image = Form2.datab.Image;
            pictureBox32.Image = Form2.datab.Image;
            pictureBox33.Image = Form2.datab.Image;


            ///////////////////////////////////////


            label2.Text = File.ReadAllText(armortable);

            originalImage = pictureBox1.Image;
            float angle = 180f;
            pictureBox2.Image = RotateImage(pictureBox2.Image, angle);
            pictureBox3.Image = RotateImage(pictureBox3.Image, angle);
            pictureBox4.Image = RotateImage(pictureBox4.Image, angle);
            pictureBox5.Image = RotateImage(pictureBox5.Image, angle);


            ////////////////////////////////////////////////////////

            pb[0] = pictureBox8;
            pb[1] = pictureBox9;
            pb[2] = pictureBox10;
            pb[3] = pictureBox11;
            pb[4] = pictureBox12;
            pb[5] = pictureBox13;
            pb[6] = pictureBox14;
            pb[7] = pictureBox15;
            pb[8] = pictureBox16;
            pb[9] = pictureBox17;
            pb[10] = pictureBox18;
            pb[11] = pictureBox19;
            pb[12] = pictureBox20;
            pb[13] = pictureBox21;
            ///////////////////////////////////////////////////////

            pb2[0] = pictureBox6;
            pb2[1] = pictureBox7;
            pb2[2] = pictureBox22;
            pb2[3] = pictureBox23;
            pb2[4] = pictureBox24;
            pb2[5] = pictureBox25;
            pb2[6] = pictureBox26;
            pb2[7] = pictureBox27;
            pb2[8] = pictureBox28;
            pb2[9] = pictureBox29;
            pb2[10] = pictureBox30;
            pb2[11] = pictureBox31;
            pb2[12] = pictureBox32;
            pb2[13] = pictureBox33;

            //////////////////////////////////////////////////////

            pbw[0] = pictureBox2;
            pbw[1] = pictureBox3;
            pbw[2] = pictureBox4;
            pbw[3] = pictureBox5;

            /////////////////////////////////////////////////////

            armorbox[0] = armorbox1;
            armorbox[1] = armorbox2;
            armorbox[2] = armorbox3;
            j2armorbox[0] = armorbox01;
            j2armorbox[1] = armorbox02;
            j2armorbox[2] = armorbox03;

            //////////////////////////////////////////////////

            star[0] = star1;
            star[1] = star2;
            star[2] = star3;
            star[3] = star4;
            star[4] = star5;
            star[5] = star6;
            star[6] = star7;
            star[7] = star8;
            star[8] = star9;
            star[9] = star10;
            star[10] = star11;
            star[11] = star12;
            star[12] = star13;
            star[13] = star14;
            star[14] = star15;
            star[15] = star16;
            star[16] = star17;
            star[17] = star18;
            star[18] = star19;
            star[19] = star20;
            star[20] = star21;
            star[21] = star22;
            star[22] = star23;
            star[23] = star24;
            star[24] = star25;
            star[25] = star26;
            star[26] = star27;
            star[27] = star28;
            star[28] = star29;
            star[29] = star30;
            star[30] = star31;
            star[31] = star32;
            star[32] = star33;
            star[33] = star34;
            star[34] = star35;

            /////////////////////////////////////////////////////////

            for (int i = 0; i <= 34; i++)
            {
                star[i].Hide();
            }

            ////////////////////////////////////////////////////////////

            jet2pb[0] = pictureBox34;
            jet2pb[1] = pictureBox35;
            jet2pb[2] = pictureBox36;
            jet2pb[3] = pictureBox37;
            jet2pb[4] = pictureBox38;
            jet2pb[5] = pictureBox39;
            jet2pb[6] = pictureBox40;
            jet2pb[7] = pictureBox41;
            jet2pb[8] = pictureBox42;
            jet2pb[9] = pictureBox43;
            jet2pb[10] = pictureBox44;
            jet2pb[11] = pictureBox45;
            jet2pb[12] = pictureBox46;
            jet2pb[13] = pictureBox47;

            ///////////////////////////////////////////////////////

            jet2pb2[0] = pictureBox48;
            jet2pb2[1] = pictureBox49;
            jet2pb2[2] = pictureBox50;
            jet2pb2[3] = pictureBox51;
            jet2pb2[4] = pictureBox52;
            jet2pb2[5] = pictureBox53;
            jet2pb2[6] = pictureBox54;
            jet2pb2[7] = pictureBox55;
            jet2pb2[8] = pictureBox56;
            jet2pb2[9] = pictureBox57;
            jet2pb2[10] = pictureBox58;
            jet2pb2[11] = pictureBox59;
            jet2pb2[12] = pictureBox60;
            jet2pb2[13] = pictureBox61;

            //////////////////////////////////////////////////////

            if (checkbox1)
            {
                pictureBox01.Location = new Point(127, 354);

                for (int i = 0; i <= 13; i++)
                {
                    jet2pb[i].Location = new Point(144, 376);
                    jet2pb2[i].Location = new Point(161, 376);
                }

            }

            else
            {
                pictureBox01.Location = new Point(-80, 354);

                for (int i = 0; i <= 13; i++)
                {
                    jet2pb[i].Location = new Point(-63, 376);
                    jet2pb2[i].Location = new Point(-46, 376);
                }

            }

            if (Form2.usercheck)
            {
                for (int i = 2; i >= armorsum; i--)
                {
                    armorbox[i].Hide();
                }
            }


        }

        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            cheet.Text += e.KeyCode;


            if (cheet.Text == "GHOST")
            {
                cheettest = true;
                cheet.Text = "";
            }

            else if (cheet.Text == "UNGHOST")
            {
                cheettest = false;
                cheet.Text = "";
            }

            else if (cheet.Text == "AUTO")
            {
                Autopilot = true;
            }

            else if (cheet.Text == "UNAUTO")
            {
                Autopilot = false;
            }

            if (e.KeyCode != Keys.G && e.KeyCode != Keys.H && e.KeyCode != Keys.O && e.KeyCode != Keys.S && e.KeyCode != Keys.T && e.KeyCode != Keys.U && e.KeyCode != Keys.N && e.KeyCode != Keys.A && e.KeyCode != Keys.U)
            {
                cheet.Text = "";
            }

            if (e.KeyCode == Keys.Escape)
            {
                this.Hide();

                new Form2().ShowDialog();

                this.Close();

            }

            if (e.KeyCode == Keys.Left)
            {


                pictureBox1.Location = new Point(pictureBox1.Location.X - 12, pictureBox1.Location.Y);

                if (!bullet1)
                {
                    pictureBox8.Location = new Point(pictureBox8.Location.X - 12, pictureBox8.Location.Y);


                }
                if (!bullet2)
                {
                    pictureBox9.Location = new Point(pictureBox9.Location.X - 12, pictureBox9.Location.Y);

                }
                if (!bullet3)
                {
                    pictureBox10.Location = new Point(pictureBox10.Location.X - 12, pictureBox10.Location.Y);


                }
                if (!bullet4)
                {
                    pictureBox11.Location = new Point(pictureBox11.Location.X - 12, pictureBox11.Location.Y);

                }
                if (!bullet5)
                {
                    pictureBox12.Location = new Point(pictureBox12.Location.X - 12, pictureBox12.Location.Y);
                }
                if (!bullet6)
                {
                    pictureBox13.Location = new Point(pictureBox13.Location.X - 12, pictureBox13.Location.Y);

                }
                if (!bullet7)
                {
                    pictureBox14.Location = new Point(pictureBox14.Location.X - 12, pictureBox14.Location.Y);

                }
                if (!bullet8)
                {
                    pictureBox15.Location = new Point(pictureBox15.Location.X - 12, pictureBox15.Location.Y);

                }
                if (!bullet9)
                {
                    pictureBox16.Location = new Point(pictureBox16.Location.X - 12, pictureBox16.Location.Y);

                }
                if (!bullet10)
                {
                    pictureBox17.Location = new Point(pictureBox17.Location.X - 12, pictureBox17.Location.Y);

                }
                if (!bullet11)
                {
                    pictureBox18.Location = new Point(pictureBox18.Location.X - 12, pictureBox18.Location.Y);

                }
                if (!bullet12)
                {
                    pictureBox19.Location = new Point(pictureBox19.Location.X - 12, pictureBox19.Location.Y);

                }
                if (!bullet13)
                {
                    pictureBox20.Location = new Point(pictureBox20.Location.X - 12, pictureBox20.Location.Y);

                }

                pictureBox21.Location = new Point(pictureBox21.Location.X - 12, pictureBox21.Location.Y);
                pictureBox33.Location = new Point(pictureBox33.Location.X - 12, pictureBox33.Location.Y);

                if (!bullet1t)
                {
                    pictureBox6.Location = new Point(pictureBox6.Location.X - 12, pictureBox6.Location.Y);


                }
                if (!bullet2t)
                {
                    pictureBox7.Location = new Point(pictureBox7.Location.X - 12, pictureBox7.Location.Y);

                }
                if (!bullet3t)
                {
                    pictureBox22.Location = new Point(pictureBox22.Location.X - 12, pictureBox22.Location.Y);


                }
                if (!bullet4t)
                {
                    pictureBox23.Location = new Point(pictureBox23.Location.X - 12, pictureBox23.Location.Y);

                }
                if (!bullet5t)
                {
                    pictureBox24.Location = new Point(pictureBox24.Location.X - 12, pictureBox24.Location.Y);

                }
                if (!bullet6t)
                {
                    pictureBox25.Location = new Point(pictureBox25.Location.X - 12, pictureBox25.Location.Y);

                }
                if (!bullet7t)
                {
                    pictureBox26.Location = new Point(pictureBox26.Location.X - 12, pictureBox26.Location.Y);

                }
                if (!bullet8t)
                {
                    pictureBox27.Location = new Point(pictureBox27.Location.X - 12, pictureBox27.Location.Y);

                }
                if (!bullet9t)
                {
                    pictureBox28.Location = new Point(pictureBox28.Location.X - 12, pictureBox28.Location.Y);

                }
                if (!bullet10t)
                {
                    pictureBox29.Location = new Point(pictureBox29.Location.X - 12, pictureBox29.Location.Y);

                }
                if (!bullet11t)
                {
                    pictureBox30.Location = new Point(pictureBox30.Location.X - 12, pictureBox30.Location.Y);

                }
                if (!bullet12t)
                {
                    pictureBox31.Location = new Point(pictureBox31.Location.X - 12, pictureBox31.Location.Y);

                }
                if (!bullet13t)
                {
                    pictureBox32.Location = new Point(pictureBox32.Location.X - 12, pictureBox32.Location.Y);

                }

                if (f)
                {

                    float angle = -25f;
                    pictureBox1.Image = RotateImage(originalImage, angle);
                }

                f = false;

                if (chek)
                {
                    timer3.Enabled = true;

                    if (sum == 1)
                    {
                        bullet1 = true;
                    }
                    if (sum == 2)
                    {
                        bullet2 = true;
                    }
                    if (sum == 3)
                    {
                        bullet3 = true;
                    }
                    if (sum == 4)
                    {
                        bullet4 = true;
                    }
                    if (sum == 5)
                    {
                        bullet5 = true;
                    }
                    if (sum == 6)
                    {
                        bullet6 = true;
                    }
                    if (sum == 7)
                    {
                        bullet7 = true;
                    }
                    if (sum == 8)
                    {
                        bullet8 = true;
                    }
                    if (sum == 9)
                    {
                        bullet9 = true;
                    }
                    if (sum == 10)
                    {
                        bullet10 = true;
                    }
                    if (sum == 11)
                    {
                        bullet11 = true;
                    }
                    if (sum == 12)
                    {
                        bullet12 = true;
                    }
                    if (sum == 13)
                    {
                        bullet13 = true;
                    }

                    if (levelup)
                    {

                        if (sum2 == 1)
                        {
                            bullet1t = true;
                        }
                        if (sum2 == 2)
                        {
                            bullet2t = true;
                        }
                        if (sum2 == 3)
                        {
                            bullet3t = true;
                        }
                        if (sum2 == 4)
                        {
                            bullet4t = true;
                        }
                        if (sum2 == 5)
                        {
                            bullet5t = true;
                        }
                        if (sum2 == 6)
                        {
                            bullet6t = true;
                        }
                        if (sum2 == 7)
                        {
                            bullet7t = true;
                        }
                        if (sum2 == 8)
                        {
                            bullet8t = true;
                        }
                        if (sum2 == 9)
                        {
                            bullet9t = true;
                        }
                        if (sum2 == 10)
                        {
                            bullet10t = true;
                        }
                        if (sum2 == 11)
                        {
                            bullet11t = true;
                        }
                        if (sum2 == 12)
                        {
                            bullet12t = true;
                        }
                        if (sum2 == 13)
                        {
                            bullet13t = true;
                        }

                    }

                }

            }

            if (e.KeyCode == Keys.Space)
            {


                chek = true;

                timer3.Enabled = true;

                if (sum == 1)
                {
                    bullet1 = true;
                }
                if (sum == 2)
                {
                    bullet2 = true;
                }
                if (sum == 3)
                {
                    bullet3 = true;
                }
                if (sum == 4)
                {
                    bullet4 = true;
                }
                if (sum == 5)
                {
                    bullet5 = true;
                }
                if (sum == 6)
                {
                    bullet6 = true;
                }
                if (sum == 7)
                {
                    bullet7 = true;
                }
                if (sum == 8)
                {
                    bullet8 = true;
                }
                if (sum == 9)
                {
                    bullet9 = true;
                }
                if (sum == 10)
                {
                    bullet10 = true;
                }
                if (sum == 11)
                {
                    bullet11 = true;
                }
                if (sum == 12)
                {
                    bullet12 = true;
                }
                if (sum == 13)
                {
                    bullet13 = true;
                }

                if (levelup)
                {
                    if (sum2 == 1)
                    {
                        bullet1t = true;
                    }
                    if (sum2 == 2)
                    {
                        bullet2t = true;
                    }
                    if (sum2 == 3)
                    {
                        bullet3t = true;
                    }
                    if (sum2 == 4)
                    {
                        bullet4t = true;
                    }
                    if (sum2 == 5)
                    {
                        bullet5t = true;
                    }
                    if (sum2 == 6)
                    {
                        bullet6t = true;
                    }
                    if (sum2 == 7)
                    {
                        bullet7t = true;
                    }
                    if (sum2 == 8)
                    {
                        bullet8t = true;
                    }
                    if (sum2 == 9)
                    {
                        bullet9t = true;
                    }
                    if (sum2 == 10)
                    {
                        bullet10t = true;
                    }
                    if (sum2 == 11)
                    {
                        bullet11t = true;
                    }
                    if (sum2 == 12)
                    {
                        bullet12t = true;
                    }
                    if (sum2 == 13)
                    {
                        bullet13t = true;
                    }
                }

                timer2.Enabled = true;
            }

            else if (e.KeyCode == Keys.Right)
            {


                pictureBox1.Location = new Point(pictureBox1.Location.X + 12, pictureBox1.Location.Y);

                if (!bullet1)
                {
                    pictureBox8.Location = new Point(pictureBox8.Location.X + 12, pictureBox8.Location.Y);


                }
                if (!bullet2)
                {
                    pictureBox9.Location = new Point(pictureBox9.Location.X + 12, pictureBox9.Location.Y);

                }
                if (!bullet3)
                {
                    pictureBox10.Location = new Point(pictureBox10.Location.X + 12, pictureBox10.Location.Y);


                }
                if (!bullet4)
                {
                    pictureBox11.Location = new Point(pictureBox11.Location.X + 12, pictureBox11.Location.Y);

                }
                if (!bullet5)
                {
                    pictureBox12.Location = new Point(pictureBox12.Location.X + 12, pictureBox12.Location.Y);

                }
                if (!bullet6)
                {
                    pictureBox13.Location = new Point(pictureBox13.Location.X + 12, pictureBox13.Location.Y);

                }
                if (!bullet7)
                {
                    pictureBox14.Location = new Point(pictureBox14.Location.X + 12, pictureBox14.Location.Y);

                }
                if (!bullet8)
                {
                    pictureBox15.Location = new Point(pictureBox15.Location.X + 12, pictureBox15.Location.Y);

                }
                if (!bullet9)
                {
                    pictureBox16.Location = new Point(pictureBox16.Location.X + 12, pictureBox16.Location.Y);

                }
                if (!bullet10)
                {
                    pictureBox17.Location = new Point(pictureBox17.Location.X + 12, pictureBox17.Location.Y);

                }
                if (!bullet11)
                {
                    pictureBox18.Location = new Point(pictureBox18.Location.X + 12, pictureBox18.Location.Y);

                }
                if (!bullet12)
                {
                    pictureBox19.Location = new Point(pictureBox19.Location.X + 12, pictureBox19.Location.Y);

                }
                if (!bullet13)
                {
                    pictureBox20.Location = new Point(pictureBox20.Location.X + 12, pictureBox20.Location.Y);

                }

                pictureBox21.Location = new Point(pictureBox21.Location.X + 12, pictureBox21.Location.Y);
                pictureBox33.Location = new Point(pictureBox33.Location.X + 12, pictureBox33.Location.Y);

                if (!bullet1t)
                {
                    pictureBox6.Location = new Point(pictureBox6.Location.X + 12, pictureBox6.Location.Y);


                }
                if (!bullet2t)
                {
                    pictureBox7.Location = new Point(pictureBox7.Location.X + 12, pictureBox7.Location.Y);

                }
                if (!bullet3t)
                {
                    pictureBox22.Location = new Point(pictureBox22.Location.X + 12, pictureBox22.Location.Y);


                }
                if (!bullet4t)
                {
                    pictureBox23.Location = new Point(pictureBox23.Location.X + 12, pictureBox23.Location.Y);

                }
                if (!bullet5t)
                {
                    pictureBox24.Location = new Point(pictureBox24.Location.X + 12, pictureBox24.Location.Y);

                }
                if (!bullet6t)
                {
                    pictureBox25.Location = new Point(pictureBox25.Location.X + 12, pictureBox25.Location.Y);

                }
                if (!bullet7t)
                {
                    pictureBox26.Location = new Point(pictureBox26.Location.X + 12, pictureBox26.Location.Y);

                }
                if (!bullet8t)
                {
                    pictureBox27.Location = new Point(pictureBox27.Location.X + 12, pictureBox27.Location.Y);

                }
                if (!bullet9t)
                {
                    pictureBox28.Location = new Point(pictureBox28.Location.X + 12, pictureBox28.Location.Y);

                }
                if (!bullet10t)
                {
                    pictureBox29.Location = new Point(pictureBox29.Location.X + 12, pictureBox29.Location.Y);

                }
                if (!bullet11t)
                {
                    pictureBox30.Location = new Point(pictureBox30.Location.X + 12, pictureBox30.Location.Y);

                }
                if (!bullet12t)
                {
                    pictureBox31.Location = new Point(pictureBox31.Location.X + 12, pictureBox31.Location.Y);

                }
                if (!bullet13t)
                {
                    pictureBox32.Location = new Point(pictureBox32.Location.X + 12, pictureBox32.Location.Y);

                }



                if (g)
                {

                    float angle = 25f;
                    pictureBox1.Image = RotateImage(originalImage, angle);
                }

                g = false;

                if (chek)
                {
                    timer3.Enabled = true;

                    if (sum == 1)
                    {
                        bullet1 = true;
                    }
                    if (sum == 2)
                    {
                        bullet2 = true;
                    }
                    if (sum == 3)
                    {
                        bullet3 = true;
                    }
                    if (sum == 4)
                    {
                        bullet4 = true;
                    }
                    if (sum == 5)
                    {
                        bullet5 = true;
                    }
                    if (sum == 6)
                    {
                        bullet6 = true;
                    }
                    if (sum == 7)
                    {
                        bullet7 = true;
                    }
                    if (sum == 8)
                    {
                        bullet8 = true;
                    }
                    if (sum == 9)
                    {
                        bullet9 = true;
                    }
                    if (sum == 10)
                    {
                        bullet10 = true;
                    }
                    if (sum == 11)
                    {
                        bullet11 = true;
                    }
                    if (sum == 12)
                    {
                        bullet12 = true;
                    }
                    if (sum == 13)
                    {
                        bullet13 = true;
                    }

                    if (levelup)
                    {

                        if (sum2 == 1)
                        {
                            bullet1t = true;
                        }
                        if (sum2 == 2)
                        {
                            bullet2t = true;
                        }
                        if (sum2 == 3)
                        {
                            bullet3t = true;
                        }
                        if (sum2 == 4)
                        {
                            bullet4t = true;
                        }
                        if (sum2 == 5)
                        {
                            bullet5t = true;
                        }
                        if (sum2 == 6)
                        {
                            bullet6t = true;
                        }
                        if (sum2 == 7)
                        {
                            bullet7t = true;
                        }
                        if (sum2 == 8)
                        {
                            bullet8t = true;
                        }
                        if (sum2 == 9)
                        {
                            bullet9t = true;
                        }
                        if (sum2 == 10)
                        {
                            bullet10t = true;
                        }
                        if (sum2 == 11)
                        {
                            bullet11t = true;
                        }
                        if (sum2 == 12)
                        {
                            bullet12t = true;
                        }
                        if (sum2 == 13)
                        {
                            bullet13t = true;
                        }

                    }

                }
            }

            if (e.KeyCode == Keys.A)
            {


                pictureBox01.Location = new Point(pictureBox01.Location.X - 12, pictureBox01.Location.Y);

                if (!j2bullet1)
                {
                    pictureBox34.Location = new Point(pictureBox34.Location.X - 12, pictureBox34.Location.Y);


                }
                if (!j2bullet2)
                {
                    pictureBox35.Location = new Point(pictureBox35.Location.X - 12, pictureBox35.Location.Y);

                }
                if (!j2bullet3)
                {
                    pictureBox36.Location = new Point(pictureBox36.Location.X - 12, pictureBox36.Location.Y);


                }
                if (!j2bullet4)
                {
                    pictureBox37.Location = new Point(pictureBox37.Location.X - 12, pictureBox37.Location.Y);

                }
                if (!j2bullet5)
                {
                    pictureBox38.Location = new Point(pictureBox38.Location.X - 12, pictureBox38.Location.Y);
                }
                if (!j2bullet6)
                {
                    pictureBox39.Location = new Point(pictureBox39.Location.X - 12, pictureBox39.Location.Y);

                }
                if (!j2bullet7)
                {
                    pictureBox40.Location = new Point(pictureBox40.Location.X - 12, pictureBox40.Location.Y);

                }
                if (!j2bullet8)
                {
                    pictureBox41.Location = new Point(pictureBox41.Location.X - 12, pictureBox41.Location.Y);

                }
                if (!j2bullet9)
                {
                    pictureBox42.Location = new Point(pictureBox42.Location.X - 12, pictureBox42.Location.Y);

                }
                if (!j2bullet10)
                {
                    pictureBox43.Location = new Point(pictureBox43.Location.X - 12, pictureBox43.Location.Y);

                }
                if (!j2bullet11)
                {
                    pictureBox44.Location = new Point(pictureBox44.Location.X - 12, pictureBox44.Location.Y);

                }
                if (!j2bullet12)
                {
                    pictureBox45.Location = new Point(pictureBox45.Location.X - 12, pictureBox45.Location.Y);

                }
                if (!j2bullet13)
                {
                    pictureBox46.Location = new Point(pictureBox46.Location.X - 12, pictureBox46.Location.Y);

                }

                pictureBox47.Location = new Point(pictureBox47.Location.X - 12, pictureBox47.Location.Y);
                pictureBox61.Location = new Point(pictureBox61.Location.X - 12, pictureBox61.Location.Y);

                if (!j2bullet1t)
                {
                    pictureBox48.Location = new Point(pictureBox48.Location.X - 12, pictureBox48.Location.Y);


                }
                if (!j2bullet2t)
                {
                    pictureBox49.Location = new Point(pictureBox49.Location.X - 12, pictureBox49.Location.Y);

                }
                if (!j2bullet3t)
                {
                    pictureBox50.Location = new Point(pictureBox50.Location.X - 12, pictureBox50.Location.Y);


                }
                if (!j2bullet4t)
                {
                    pictureBox51.Location = new Point(pictureBox51.Location.X - 12, pictureBox51.Location.Y);

                }
                if (!j2bullet5t)
                {
                    pictureBox52.Location = new Point(pictureBox52.Location.X - 12, pictureBox52.Location.Y);

                }
                if (!j2bullet6t)
                {
                    pictureBox53.Location = new Point(pictureBox53.Location.X - 12, pictureBox53.Location.Y);

                }
                if (!j2bullet7t)
                {
                    pictureBox54.Location = new Point(pictureBox54.Location.X - 12, pictureBox54.Location.Y);

                }
                if (!j2bullet8t)
                {
                    pictureBox55.Location = new Point(pictureBox55.Location.X - 12, pictureBox55.Location.Y);

                }
                if (!j2bullet9t)
                {
                    pictureBox56.Location = new Point(pictureBox56.Location.X - 12, pictureBox56.Location.Y);

                }
                if (!j2bullet10t)
                {
                    pictureBox57.Location = new Point(pictureBox57.Location.X - 12, pictureBox57.Location.Y);

                }
                if (!j2bullet11t)
                {
                    pictureBox58.Location = new Point(pictureBox58.Location.X - 12, pictureBox58.Location.Y);

                }
                if (!j2bullet12t)
                {
                    pictureBox59.Location = new Point(pictureBox59.Location.X - 12, pictureBox59.Location.Y);

                }
                if (!j2bullet13t)
                {
                    pictureBox60.Location = new Point(pictureBox60.Location.X - 12, pictureBox60.Location.Y);

                }

                if (j2f)
                {

                    float angle = -25f;
                    pictureBox01.Image = RotateImage(originalImage, angle);
                }

                j2f = false;

                if (j2chek)
                {
                    timer10.Enabled = true;

                    if (j2sum == 1)
                    {
                        j2bullet1 = true;
                    }
                    if (j2sum == 2)
                    {
                        j2bullet2 = true;
                    }
                    if (j2sum == 3)
                    {
                        j2bullet3 = true;
                    }
                    if (j2sum == 4)
                    {
                        j2bullet4 = true;
                    }
                    if (j2sum == 5)
                    {
                        j2bullet5 = true;
                    }
                    if (j2sum == 6)
                    {
                        j2bullet6 = true;
                    }
                    if (j2sum == 7)
                    {
                        j2bullet7 = true;
                    }
                    if (j2sum == 8)
                    {
                        j2bullet8 = true;
                    }
                    if (j2sum == 9)
                    {
                        j2bullet9 = true;
                    }
                    if (j2sum == 10)
                    {
                        j2bullet10 = true;
                    }
                    if (j2sum == 11)
                    {
                        j2bullet11 = true;
                    }
                    if (j2sum == 12)
                    {
                        j2bullet12 = true;
                    }
                    if (j2sum == 13)
                    {
                        j2bullet13 = true;
                    }

                    if (j2levelup)
                    {

                        if (j2sum2 == 1)
                        {
                            j2bullet1t = true;
                        }
                        if (j2sum2 == 2)
                        {
                            j2bullet2t = true;
                        }
                        if (j2sum2 == 3)
                        {
                            j2bullet3t = true;
                        }
                        if (j2sum2 == 4)
                        {
                            bullet4t = true;
                        }
                        if (j2sum2 == 5)
                        {
                            j2bullet5t = true;
                        }
                        if (j2sum2 == 6)
                        {
                            j2bullet6t = true;
                        }
                        if (j2sum2 == 7)
                        {
                            j2bullet7t = true;
                        }
                        if (j2sum2 == 8)
                        {
                            j2bullet8t = true;
                        }
                        if (j2sum2 == 9)
                        {
                            j2bullet9t = true;
                        }
                        if (j2sum2 == 10)
                        {
                            j2bullet10t = true;
                        }
                        if (j2sum2 == 11)
                        {
                            j2bullet11t = true;
                        }
                        if (j2sum2 == 12)
                        {
                            j2bullet12t = true;
                        }
                        if (j2sum2 == 13)
                        {
                            j2bullet13t = true;
                        }

                    }

                }

            }

            if (e.KeyCode == Keys.W)
            {


                j2chek = true;

                timer10.Enabled = true;

                if (j2sum == 1)
                {
                    j2bullet1 = true;
                }
                if (j2sum == 2)
                {
                    j2bullet2 = true;
                }
                if (j2sum == 3)
                {
                    j2bullet3 = true;
                }
                if (j2sum == 4)
                {
                    j2bullet4 = true;
                }
                if (j2sum == 5)
                {
                    j2bullet5 = true;
                }
                if (j2sum == 6)
                {
                    j2bullet6 = true;
                }
                if (j2sum == 7)
                {
                    j2bullet7 = true;
                }
                if (j2sum == 8)
                {
                    j2bullet8 = true;
                }
                if (j2sum == 9)
                {
                    j2bullet9 = true;
                }
                if (j2sum == 10)
                {
                    j2bullet10 = true;
                }
                if (j2sum == 11)
                {
                    j2bullet11 = true;
                }
                if (j2sum == 12)
                {
                    j2bullet12 = true;
                }
                if (j2sum == 13)
                {
                    j2bullet13 = true;
                }

                if (j2levelup)
                {
                    if (j2sum2 == 1)
                    {
                        j2bullet1t = true;
                    }
                    if (j2sum2 == 2)
                    {
                        j2bullet2t = true;
                    }
                    if (j2sum2 == 3)
                    {
                        j2bullet3t = true;
                    }
                    if (j2sum2 == 4)
                    {
                        j2bullet4t = true;
                    }
                    if (j2sum2 == 5)
                    {
                        j2bullet5t = true;
                    }
                    if (j2sum2 == 6)
                    {
                        j2bullet6t = true;
                    }
                    if (j2sum2 == 7)
                    {
                        j2bullet7t = true;
                    }
                    if (j2sum2 == 8)
                    {
                        j2bullet8t = true;
                    }
                    if (j2sum2 == 9)
                    {
                        j2bullet9t = true;
                    }
                    if (j2sum2 == 10)
                    {
                        j2bullet10t = true;
                    }
                    if (j2sum2 == 11)
                    {
                        j2bullet11t = true;
                    }
                    if (j2sum2 == 12)
                    {
                        j2bullet12t = true;
                    }
                    if (j2sum2 == 13)
                    {
                        j2bullet13t = true;
                    }
                }

                timer11.Enabled = true;
            }

            else if (e.KeyCode == Keys.D)
            {

                pictureBox01.Location = new Point(pictureBox01.Location.X + 12, pictureBox01.Location.Y);

                if (!j2bullet1)
                {
                    pictureBox34.Location = new Point(pictureBox34.Location.X + 12, pictureBox34.Location.Y);


                }
                if (!j2bullet2)
                {
                    pictureBox35.Location = new Point(pictureBox35.Location.X + 12, pictureBox35.Location.Y);

                }
                if (!j2bullet3)
                {
                    pictureBox36.Location = new Point(pictureBox36.Location.X + 12, pictureBox36.Location.Y);


                }
                if (!j2bullet4)
                {
                    pictureBox37.Location = new Point(pictureBox37.Location.X + 12, pictureBox37.Location.Y);

                }
                if (!j2bullet5)
                {
                    pictureBox38.Location = new Point(pictureBox38.Location.X + 12, pictureBox38.Location.Y);
                }
                if (!j2bullet6)
                {
                    pictureBox39.Location = new Point(pictureBox39.Location.X + 12, pictureBox39.Location.Y);

                }
                if (!j2bullet7)
                {
                    pictureBox40.Location = new Point(pictureBox40.Location.X + 12, pictureBox40.Location.Y);

                }
                if (!j2bullet8)
                {
                    pictureBox41.Location = new Point(pictureBox41.Location.X + 12, pictureBox41.Location.Y);

                }
                if (!j2bullet9)
                {
                    pictureBox42.Location = new Point(pictureBox42.Location.X + 12, pictureBox42.Location.Y);

                }
                if (!j2bullet10)
                {
                    pictureBox43.Location = new Point(pictureBox43.Location.X + 12, pictureBox43.Location.Y);

                }
                if (!j2bullet11)
                {
                    pictureBox44.Location = new Point(pictureBox44.Location.X + 12, pictureBox44.Location.Y);

                }
                if (!j2bullet12)
                {
                    pictureBox45.Location = new Point(pictureBox45.Location.X + 12, pictureBox45.Location.Y);

                }
                if (!j2bullet13)
                {
                    pictureBox46.Location = new Point(pictureBox46.Location.X + 12, pictureBox46.Location.Y);

                }

                pictureBox47.Location = new Point(pictureBox47.Location.X + 12, pictureBox47.Location.Y);
                pictureBox61.Location = new Point(pictureBox61.Location.X + 12, pictureBox61.Location.Y);

                if (!j2bullet1t)
                {
                    pictureBox48.Location = new Point(pictureBox48.Location.X + 12, pictureBox48.Location.Y);


                }
                if (!j2bullet2t)
                {
                    pictureBox49.Location = new Point(pictureBox49.Location.X + 12, pictureBox49.Location.Y);

                }
                if (!j2bullet3t)
                {
                    pictureBox50.Location = new Point(pictureBox50.Location.X + 12, pictureBox50.Location.Y);


                }
                if (!j2bullet4t)
                {
                    pictureBox51.Location = new Point(pictureBox51.Location.X + 12, pictureBox51.Location.Y);

                }
                if (!j2bullet5t)
                {
                    pictureBox52.Location = new Point(pictureBox52.Location.X + 12, pictureBox52.Location.Y);

                }
                if (!j2bullet6t)
                {
                    pictureBox53.Location = new Point(pictureBox53.Location.X + 12, pictureBox53.Location.Y);

                }
                if (!j2bullet7t)
                {
                    pictureBox54.Location = new Point(pictureBox54.Location.X + 12, pictureBox54.Location.Y);

                }
                if (!j2bullet8t)
                {
                    pictureBox55.Location = new Point(pictureBox55.Location.X + 12, pictureBox55.Location.Y);

                }
                if (!j2bullet9t)
                {
                    pictureBox56.Location = new Point(pictureBox56.Location.X + 12, pictureBox56.Location.Y);

                }
                if (!j2bullet10t)
                {
                    pictureBox57.Location = new Point(pictureBox57.Location.X + 12, pictureBox57.Location.Y);

                }
                if (!j2bullet11t)
                {
                    pictureBox58.Location = new Point(pictureBox58.Location.X + 12, pictureBox58.Location.Y);

                }
                if (!j2bullet12t)
                {
                    pictureBox59.Location = new Point(pictureBox59.Location.X + 12, pictureBox59.Location.Y);

                }
                if (!j2bullet13t)
                {
                    pictureBox60.Location = new Point(pictureBox60.Location.X + 12, pictureBox60.Location.Y);

                }

                if (j2g)
                {

                    float angle = +25f;
                    pictureBox01.Image = RotateImage(originalImage, angle);
                }

                j2g = false;

                if (j2chek)
                {
                    timer10.Enabled = true;

                    if (j2sum == 1)
                    {
                        j2bullet1 = true;
                    }
                    if (j2sum == 2)
                    {
                        j2bullet2 = true;
                    }
                    if (j2sum == 3)
                    {
                        j2bullet3 = true;
                    }
                    if (j2sum == 4)
                    {
                        j2bullet4 = true;
                    }
                    if (j2sum == 5)
                    {
                        j2bullet5 = true;
                    }
                    if (j2sum == 6)
                    {
                        j2bullet6 = true;
                    }
                    if (j2sum == 7)
                    {
                        j2bullet7 = true;
                    }
                    if (j2sum == 8)
                    {
                        j2bullet8 = true;
                    }
                    if (j2sum == 9)
                    {
                        j2bullet9 = true;
                    }
                    if (j2sum == 10)
                    {
                        j2bullet10 = true;
                    }
                    if (j2sum == 11)
                    {
                        j2bullet11 = true;
                    }
                    if (j2sum == 12)
                    {
                        j2bullet12 = true;
                    }
                    if (j2sum == 13)
                    {
                        j2bullet13 = true;
                    }

                    if (j2levelup)
                    {

                        if (j2sum2 == 1)
                        {
                            j2bullet1t = true;
                        }
                        if (j2sum2 == 2)
                        {
                            j2bullet2t = true;
                        }
                        if (j2sum2 == 3)
                        {
                            j2bullet3t = true;
                        }
                        if (j2sum2 == 4)
                        {
                            bullet4t = true;
                        }
                        if (j2sum2 == 5)
                        {
                            j2bullet5t = true;
                        }
                        if (j2sum2 == 6)
                        {
                            j2bullet6t = true;
                        }
                        if (j2sum2 == 7)
                        {
                            j2bullet7t = true;
                        }
                        if (j2sum2 == 8)
                        {
                            j2bullet8t = true;
                        }
                        if (j2sum2 == 9)
                        {
                            j2bullet9t = true;
                        }
                        if (j2sum2 == 10)
                        {
                            j2bullet10t = true;
                        }
                        if (j2sum2 == 11)
                        {
                            j2bullet11t = true;
                        }
                        if (j2sum2 == 12)
                        {
                            j2bullet12t = true;
                        }
                        if (j2sum2 == 13)
                        {
                            j2bullet13t = true;
                        }

                    }

                }

            }

            if (e.KeyCode == Keys.Enter)
            {
                if (Enterchek)
                {

                    pbwsum = 1;
                    score = 0;
                    armor = 3;
                    armorsum = 3;
                    j2armor = 3;
                    j2armorsum = 3;
                    armorpbw = 1;
                    label1.Text = score + "";
                    giantmove = false;
                    timer1.Enabled = true;
                    timer2.Enabled = true;
                    timer3.Enabled = true;
                    timer3.Enabled = true;
                    timer6.Enabled = true;
                    levelup = false;
                    j2levelup = false;
                    this.BackColor = Color.FromArgb(0, 229, 228);
                    pictureBox2.Location = new Point(371, -322);
                    pictureBox3.Location = new Point(371, -268);
                    pictureBox4.Location = new Point(371, -214);
                    pictureBox5.Location = new Point(371, -160);
                    armorbox[0].Show();
                    armorbox[1].Show();
                    armorbox[2].Show();
                    j2armorbox[0].Show();
                    j2armorbox[1].Show();
                    j2armorbox[2].Show();

                    timer3.Stop();
                    timer3.Start();

                    Enterchek = false;
                }
            }

            if (e.KeyCode == Keys.Up)
            {
                move++;

            }

            if (e.KeyCode == Keys.Down)
            {
                move--;
            }

            if (e.KeyCode == Keys.NumPad8)
            {
                bulletboost++;
            }

            if (e.KeyCode == Keys.NumPad2)
            {
                bulletboost--;
            }

            if (e.Control && e.KeyCode == Keys.S)
            {
                if (Form2.usercheck)
                {

                    string textfile = Form2.userpath;

                    using (StreamWriter writer = new StreamWriter(textfile))
                    {
                        writer.WriteLine(score);
                        writer.WriteLine(armorsum);
                        writer.WriteLine(armor);
                        writer.WriteLine(armorpbw);
                        writer.WriteLine(bulletboost);

                    }

                }

                else
                {
                    MessageBox.Show("please Login or sign up");
                }

            }

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Left)
            {

                pictureBox1.Image = RotateImage(originalImage, 0f);
                f = true;

            }

            if (e.KeyCode == Keys.Space)
            {
                chek = false;
            }

            else if (e.KeyCode == Keys.Right)

            {

                pictureBox1.Image = RotateImage(originalImage, 0f);
                g = true;

            }

            if (e.KeyCode == Keys.A)
            {

                pictureBox01.Image = RotateImage(originalImage, 0f);
                j2f = true;

            }

            if (e.KeyCode == Keys.W)
            {
                j2chek = false;
            }

            else if (e.KeyCode == Keys.D)

            {

                pictureBox01.Image = RotateImage(originalImage, 0f);
                j2g = true;

            }

        }

        private Image RotateImage(Image image, float angle)
        {
            Bitmap rotatedImage = new Bitmap(image.Width, image.Height);
            rotatedImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);
            using (Graphics g = Graphics.FromImage(rotatedImage))
            {
                g.TranslateTransform(image.Width / 2, image.Height / 2);
                g.RotateTransform(angle);
                g.DrawImage(image, new Point(-image.Width / 2, -image.Height / 2));
            }
            return rotatedImage;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (score % 100 == 0 && score != 0)
            {
                timer1.Enabled = false;

                for (int l = 0; l <= 3; l++)
                {
                    pbw[l].Location = new Point(pbw[l].Location.X, -60);
                }

                giantarmor = 100;
                giantmove = true;

            }

            for (int i = 0; i <= 3; i++)
            {

                if (pbw[i].Location.Y >= pictureBox1.Location.Y || pbw[i].Location.Y >= pictureBox01.Location.Y)
                {


                    score++;
                    label1.Text = score + "";

                    label1sum = Convert.ToInt32(label1.Text);
                    label2sum = Convert.ToInt32(label2.Text);

                    if (label1sum >= label2sum)
                    {
                        File.WriteAllText("armortable.txt", label1.Text);
                        label2.Text = label1.Text;
                    }


                    if (score % 100 == 0)
                    {
                        pbwsum++;
                        if (pbwsum % 2 == 0)
                        {
                            this.BackColor = Color.FromArgb(35, 33, 26);

                        }
                        else
                        {
                            this.BackColor = Color.FromArgb(0, 229, 228);

                        }

                    }

                    if (score % 100 == 0)
                    {
                        armorpbw++;



                    }




                    Random rnd = new Random();
                    rn = rnd.Next(1, 550);

                    pbw[i].Location = new Point(rn, 0);

                    if (Autopilot)
                    {
                        while (pictureBox1.Location.X >= pbw[i].Location.X )
                        {
                            
                            pictureBox1.Location = new Point(pictureBox1.Location.X - 11, pictureBox1.Location.Y);

                            if (!bullet1)
                            {
                                pictureBox8.Location = new Point(pictureBox8.Location.X - 11, pictureBox8.Location.Y);


                            }
                            if (!bullet2)
                            {
                                pictureBox9.Location = new Point(pictureBox9.Location.X - 11, pictureBox9.Location.Y);

                            }
                            if (!bullet3)
                            {
                                pictureBox10.Location = new Point(pictureBox10.Location.X - 11, pictureBox10.Location.Y);


                            }
                            if (!bullet4)
                            {
                                pictureBox11.Location = new Point(pictureBox11.Location.X - 11, pictureBox11.Location.Y);

                            }
                            if (!bullet5)
                            {
                                pictureBox12.Location = new Point(pictureBox12.Location.X - 11, pictureBox12.Location.Y);
                            }
                            if (!bullet6)
                            {
                                pictureBox13.Location = new Point(pictureBox13.Location.X - 11, pictureBox13.Location.Y);

                            }
                            if (!bullet7)
                            {
                                pictureBox14.Location = new Point(pictureBox14.Location.X - 11, pictureBox14.Location.Y);

                            }
                            if (!bullet8)
                            {
                                pictureBox15.Location = new Point(pictureBox15.Location.X - 11, pictureBox15.Location.Y);

                            }
                            if (!bullet9)
                            {
                                pictureBox16.Location = new Point(pictureBox16.Location.X - 11, pictureBox16.Location.Y);

                            }
                            if (!bullet10)
                            {
                                pictureBox17.Location = new Point(pictureBox17.Location.X - 11, pictureBox17.Location.Y);

                            }
                            if (!bullet11)
                            {
                                pictureBox18.Location = new Point(pictureBox18.Location.X - 11, pictureBox18.Location.Y);

                            }
                            if (!bullet12)
                            {
                                pictureBox19.Location = new Point(pictureBox19.Location.X - 11, pictureBox19.Location.Y);

                            }
                            if (!bullet13)
                            {
                                pictureBox20.Location = new Point(pictureBox20.Location.X - 11, pictureBox20.Location.Y);

                            }

                            pictureBox21.Location = new Point(pictureBox21.Location.X - 11, pictureBox21.Location.Y);
                            pictureBox33.Location = new Point(pictureBox33.Location.X - 11, pictureBox33.Location.Y);

                            if (!bullet1t)
                            {
                                pictureBox6.Location = new Point(pictureBox6.Location.X - 11, pictureBox6.Location.Y);


                            }
                            if (!bullet2t)
                            {
                                pictureBox7.Location = new Point(pictureBox7.Location.X - 11, pictureBox7.Location.Y);

                            }
                            if (!bullet3t)
                            {
                                pictureBox22.Location = new Point(pictureBox22.Location.X - 11, pictureBox22.Location.Y);


                            }
                            if (!bullet4t)
                            {
                                pictureBox23.Location = new Point(pictureBox23.Location.X - 11, pictureBox23.Location.Y);

                            }
                            if (!bullet5t)
                            {
                                pictureBox24.Location = new Point(pictureBox24.Location.X - 11, pictureBox24.Location.Y);

                            }
                            if (!bullet6t)
                            {
                                pictureBox25.Location = new Point(pictureBox25.Location.X - 11, pictureBox25.Location.Y);

                            }
                            if (!bullet7t)
                            {
                                pictureBox26.Location = new Point(pictureBox26.Location.X - 11, pictureBox26.Location.Y);

                            }
                            if (!bullet8t)
                            {
                                pictureBox27.Location = new Point(pictureBox27.Location.X - 11, pictureBox27.Location.Y);

                            }
                            if (!bullet9t)
                            {
                                pictureBox28.Location = new Point(pictureBox28.Location.X - 11, pictureBox28.Location.Y);

                            }
                            if (!bullet10t)
                            {
                                pictureBox29.Location = new Point(pictureBox29.Location.X - 11, pictureBox29.Location.Y);
                                
                            }
                            if (!bullet11t)
                            {
                                pictureBox30.Location = new Point(pictureBox30.Location.X - 11, pictureBox30.Location.Y);

                            }
                            if (!bullet12t)
                            {
                                pictureBox31.Location = new Point(pictureBox31.Location.X - 11, pictureBox31.Location.Y);

                            }
                            if (!bullet13t)
                            {
                                pictureBox32.Location = new Point(pictureBox32.Location.X - 11, pictureBox32.Location.Y);

                            }

                            if (f)
                            {

                                float angle = -25f;
                                pictureBox1.Image = RotateImage(originalImage, angle);
                            }

                            f = false;

                            auto = false;
                            timer14.Enabled = true;

                        }
                        while (pictureBox1.Location.X <= pbw[i].Location.X )
                        {

                            pictureBox1.Location = new Point(pictureBox1.Location.X + 11, pictureBox1.Location.Y);

                            if (!bullet1)
                            {
                                pictureBox8.Location = new Point(pictureBox8.Location.X + 11, pictureBox8.Location.Y);


                            }
                            if (!bullet2)
                            {
                                pictureBox9.Location = new Point(pictureBox9.Location.X + 11, pictureBox9.Location.Y);

                            }
                            if (!bullet3)
                            {
                                pictureBox10.Location = new Point(pictureBox10.Location.X + 11, pictureBox10.Location.Y);


                            }
                            if (!bullet4)
                            {
                                pictureBox11.Location = new Point(pictureBox11.Location.X + 11, pictureBox11.Location.Y);

                            }
                            if (!bullet5)
                            {
                                pictureBox12.Location = new Point(pictureBox12.Location.X + 11, pictureBox12.Location.Y);

                            }
                            if (!bullet6)
                            {
                                pictureBox13.Location = new Point(pictureBox13.Location.X + 11, pictureBox13.Location.Y);

                            }
                            if (!bullet7)
                            {
                                pictureBox14.Location = new Point(pictureBox14.Location.X + 11, pictureBox14.Location.Y);

                            }
                            if (!bullet8)
                            {
                                pictureBox15.Location = new Point(pictureBox15.Location.X + 11, pictureBox15.Location.Y);

                            }
                            if (!bullet9)
                            {
                                pictureBox16.Location = new Point(pictureBox16.Location.X + 11, pictureBox16.Location.Y);

                            }
                            if (!bullet10)
                            {
                                pictureBox17.Location = new Point(pictureBox17.Location.X + 11, pictureBox17.Location.Y);

                            }
                            if (!bullet11)
                            {
                                pictureBox18.Location = new Point(pictureBox18.Location.X + 11, pictureBox18.Location.Y);

                            }
                            if (!bullet12)
                            {
                                pictureBox19.Location = new Point(pictureBox19.Location.X + 11, pictureBox19.Location.Y);

                            }
                            if (!bullet13)
                            {
                                pictureBox20.Location = new Point(pictureBox20.Location.X + 11, pictureBox20.Location.Y);

                            }

                            pictureBox21.Location = new Point(pictureBox21.Location.X + 11, pictureBox21.Location.Y);
                            pictureBox33.Location = new Point(pictureBox33.Location.X + 11, pictureBox33.Location.Y);

                            if (!bullet1t)
                            {
                                pictureBox6.Location = new Point(pictureBox6.Location.X + 11, pictureBox6.Location.Y);


                            }
                            if (!bullet2t)
                            {
                                pictureBox7.Location = new Point(pictureBox7.Location.X + 11, pictureBox7.Location.Y);

                            }
                            if (!bullet3t)
                            {
                                pictureBox22.Location = new Point(pictureBox22.Location.X + 11, pictureBox22.Location.Y);


                            }
                            if (!bullet4t)
                            {
                                pictureBox23.Location = new Point(pictureBox23.Location.X + 11, pictureBox23.Location.Y);

                            }
                            if (!bullet5t)
                            {
                                pictureBox24.Location = new Point(pictureBox24.Location.X + 11, pictureBox24.Location.Y);

                            }
                            if (!bullet6t)
                            {
                                pictureBox25.Location = new Point(pictureBox25.Location.X + 11, pictureBox25.Location.Y);

                            }
                            if (!bullet7t)
                            {
                                pictureBox26.Location = new Point(pictureBox26.Location.X + 11, pictureBox26.Location.Y);

                            }
                            if (!bullet8t)
                            {
                                pictureBox27.Location = new Point(pictureBox27.Location.X + 11, pictureBox27.Location.Y);

                            }
                            if (!bullet9t)
                            {
                                pictureBox28.Location = new Point(pictureBox28.Location.X + 11, pictureBox28.Location.Y);

                            }
                            if (!bullet10t)
                            {
                                pictureBox29.Location = new Point(pictureBox29.Location.X + 11, pictureBox29.Location.Y);

                            }
                            if (!bullet11t)
                            {
                                pictureBox30.Location = new Point(pictureBox30.Location.X + 11, pictureBox30.Location.Y);

                            }
                            if (!bullet12t)
                            {
                                pictureBox31.Location = new Point(pictureBox31.Location.X + 11, pictureBox31.Location.Y);

                            }
                            if (!bullet13t)
                            {
                                pictureBox32.Location = new Point(pictureBox32.Location.X + 11, pictureBox32.Location.Y);

                            }



                            if (g)
                            {

                                float angle = 25f;
                                pictureBox1.Image = RotateImage(originalImage, angle);
                            }

                            g = false;

                            auto = false;
                            timer14.Enabled = true;
                        }


                            for (int j = 0; j <= 13; j++)
                        {
                            pb[j].Location = new Point(pictureBox1.Location.X + 33, pictureBox1.Location.Y);
                        }

                        for (int j = 0; j <= 13; j++)
                        {
                            pb2[j].Location = new Point(pictureBox1.Location.X + 5, pictureBox1.Location.Y);
                        }

                        timer3.Enabled = true;

                        if (sum == 1)
                        {
                            bullet1 = true;
                        }
                        if (sum == 2)
                        {
                            bullet2 = true;
                        }
                        if (sum == 3)
                        {
                            bullet3 = true;
                        }
                        if (sum == 4)
                        {
                            bullet4 = true;
                        }
                        if (sum == 5)
                        {
                            bullet5 = true;
                        }
                        if (sum == 6)
                        {
                            bullet6 = true;
                        }
                        if (sum == 7)
                        {
                            bullet7 = true;
                        }
                        if (sum == 8)
                        {
                            bullet8 = true;
                        }
                        if (sum == 9)
                        {
                            bullet9 = true;
                        }
                        if (sum == 10)
                        {
                            bullet10 = true;
                        }
                        if (sum == 11)
                        {
                            bullet11 = true;
                        }
                        if (sum == 12)
                        {
                            bullet12 = true;
                        }
                        if (sum == 13)
                        {
                            bullet13 = true;
                        }

                        if (levelup)
                        {
                            if (sum2 == 1)
                            {
                                bullet1t = true;
                            }
                            if (sum2 == 2)
                            {
                                bullet2t = true;
                            }
                            if (sum2 == 3)
                            {
                                bullet3t = true;
                            }
                            if (sum2 == 4)
                            {
                                bullet4t = true;
                            }
                            if (sum2 == 5)
                            {
                                bullet5t = true;
                            }
                            if (sum2 == 6)
                            {
                                bullet6t = true;
                            }
                            if (sum2 == 7)
                            {
                                bullet7t = true;
                            }
                            if (sum2 == 8)
                            {
                                bullet8t = true;
                            }
                            if (sum2 == 9)
                            {
                                bullet9t = true;
                            }
                            if (sum2 == 10)
                            {
                                bullet10t = true;
                            }
                            if (sum2 == 11)
                            {
                                bullet11t = true;
                            }
                            if (sum2 == 12)
                            {
                                bullet12t = true;
                            }
                            if (sum2 == 13)
                            {
                                bullet13t = true;
                            }
                        }

                        timer2.Enabled = true;

                    }

                    break;
                }
            }


            for (int i = 0; i <= 13; i++)
            {
                for (int j = 0; j <= 3; j++)
                {


                    if (pb[i].Bounds.IntersectsWith(pbw[j].Bounds))
                    {

                        pbwarmor[j] -= bulletboost;

                        pb[i].Location = new Point(pictureBox1.Location.X + 33, pictureBox1.Location.Y);


                        if (i == 0)
                        {
                            bullet1 = false;
                        }
                        else if (i == 1)
                        {
                            bullet2 = false;
                        }
                        else if (i == 2)
                        {
                            bullet3 = false;
                        }
                        else if (i == 3)
                        {
                            bullet4 = false;
                        }
                        else if (i == 4)
                        {
                            bullet5 = false;
                        }
                        else if (i == 5)
                        {
                            bullet6 = false;
                        }
                        else if (i == 6)
                        {
                            bullet7 = false;
                        }
                        else if (i == 7)
                        {
                            bullet8 = false;
                        }
                        else if (i == 8)
                        {
                            bullet9 = false;
                        }
                        else if (i == 9)
                        {
                            bullet10 = false;
                        }
                        else if (i == 10)
                        {
                            bullet11 = false;
                        }
                        else if (i == 11)
                        {
                            bullet12 = false;
                        }
                        else if (i == 12)
                        {
                            bullet13 = false;
                        }

                        if (pbwarmor[j] <= 0)
                        {
                            pbwarmor[j] = 0;
                        }

                        if (pbwarmor[j] == 0)
                        {



                            pbwarmor[j] = armorpbw;


                            explosion.Show();
                            explosion.Location = new Point(pbw[j].Location.X, pbw[j].Location.Y);
                            timer8.Enabled = true;

                            if (hurtrandom.Next(1, 25) == 3)
                            {

                                heart.Location = pbw[j].Location;
                                timer7.Enabled = true;
                            }
                            else if (hurtrandom.Next(1, 50) == 15)
                            {

                                bulletlevelup.Location = pbw[j].Location;
                                timer9.Enabled = true;
                            }


                            pbw[j].Location = new Point(pbw[j].Location.X, 450);

                            score++;



                            if (score % 100 == 0)
                            {
                                pbwsum++;

                                if (pbwsum % 2 == 0)
                                {
                                    this.BackColor = Color.FromArgb(35, 33, 26);

                                }
                                else
                                {
                                    this.BackColor = Color.FromArgb(0, 229, 228);

                                }
                            }
                            if (score % 100 == 0)
                            {
                                armorpbw++;

                            }



                        }

                    }







                }
            }

            for (int i = 0; i <= 13; i++)
            {
                for (int j = 0; j <= 3; j++)
                {

                    if (pb2[i].Bounds.IntersectsWith(pbw[j].Bounds))
                    {

                        pbwarmor[j] -= armorpbw;

                        pb2[i].Location = new Point(pictureBox1.Location.X + 5, pictureBox1.Location.Y);

                        if (i == 0)
                        {
                            bullet1t = false;
                        }
                        else if (i == 1)
                        {
                            bullet2t = false;
                        }
                        else if (i == 2)
                        {
                            bullet3t = false;
                        }
                        else if (i == 3)
                        {
                            bullet4t = false;
                        }
                        else if (i == 4)
                        {
                            bullet5t = false;
                        }
                        else if (i == 5)
                        {
                            bullet6t = false;
                        }
                        else if (i == 6)
                        {
                            bullet7t = false;
                        }
                        else if (i == 7)
                        {
                            bullet8t = false;
                        }
                        else if (i == 8)
                        {
                            bullet9t = false;
                        }
                        else if (i == 9)
                        {
                            bullet10t = false;
                        }
                        else if (i == 10)
                        {
                            bullet11t = false;
                        }
                        else if (i == 11)
                        {
                            bullet12t = false;
                        }
                        else if (i == 12)
                        {
                            bullet13t = false;
                        }

                        if (pbwarmor[j] <= 0)
                        {
                            pbwarmor[j] = 0;
                        }

                        if (pbwarmor[j] == 0)
                        {

                            pbwarmor[j] = armorpbw;


                            explosion.Show();
                            explosion.Location = new Point(pbw[j].Location.X, pbw[j].Location.Y);
                            timer8.Enabled = true;

                            if (hurtrandom.Next(1, 25) == 3)
                            {

                                heart.Location = pbw[j].Location;
                                timer7.Enabled = true;
                            }
                            else if (hurtrandom.Next(1, 35) == 10)
                            {

                                bulletlevelup.Location = pbw[j].Location;
                                timer9.Enabled = true;
                            }


                            pbw[j].Location = new Point(pbw[j].Location.X, 450);

                            score++;



                            if (score % 100 == 0)
                            {
                                pbwsum++;

                                if (pbwsum % 2 == 0)
                                {
                                    this.BackColor = Color.FromArgb(35, 33, 26);

                                }
                                else
                                {
                                    this.BackColor = Color.FromArgb(0, 229, 228);

                                }
                            }
                            if (score % 100 == 0)
                            {
                                armorpbw++;

                            }



                        }

                    }


                }
            }


            for (int g = 0; g <= 3; g++)
            {
                pbw[g].Location = new Point(pbw[g].Location.X, pbw[g].Location.Y + pbwsum);
            }



            /////////////////////////////////////////////

            for (int i = 0; i <= 13; i++)
            {
                for (int j = 0; j <= 3; j++)
                {


                    if (jet2pb[i].Bounds.IntersectsWith(pbw[j].Bounds))
                    {

                        pbwarmor[j] -= bulletboost;

                        jet2pb[i].Location = new Point(pictureBox01.Location.X + 33, pictureBox01.Location.Y);


                        if (i == 0)
                        {
                            j2bullet1 = false;
                        }
                        else if (i == 1)
                        {
                            j2bullet2 = false;
                        }
                        else if (i == 2)
                        {
                            j2bullet3 = false;
                        }
                        else if (i == 3)
                        {
                            j2bullet4 = false;
                        }
                        else if (i == 4)
                        {
                            j2bullet5 = false;
                        }
                        else if (i == 5)
                        {
                            j2bullet6 = false;
                        }
                        else if (i == 6)
                        {
                            j2bullet7 = false;
                        }
                        else if (i == 7)
                        {
                            j2bullet8 = false;
                        }
                        else if (i == 8)
                        {
                            j2bullet9 = false;
                        }
                        else if (i == 9)
                        {
                            j2bullet10 = false;
                        }
                        else if (i == 10)
                        {
                            j2bullet11 = false;
                        }
                        else if (i == 11)
                        {
                            j2bullet12 = false;
                        }
                        else if (i == 12)
                        {
                            j2bullet13 = false;
                        }

                        if (pbwarmor[j] <= 0)
                        {
                            pbwarmor[j] = 0;
                        }

                        if (pbwarmor[j] == 0)
                        {



                            pbwarmor[j] = armorpbw;


                            explosion.Show();
                            explosion.Location = new Point(pbw[j].Location.X, pbw[j].Location.Y);
                            timer8.Enabled = true;

                            if (hurtrandom.Next(1, 25) == 3)
                            {

                                heart.Location = pbw[j].Location;
                                timer7.Enabled = true;
                            }
                            else if (hurtrandom.Next(1, 50) == 15)
                            {

                                bulletlevelup.Location = pbw[j].Location;
                                timer9.Enabled = true;
                            }


                            pbw[j].Location = new Point(pbw[j].Location.X, 450);

                            score++;



                            if (score % 100 == 0)
                            {
                                pbwsum++;

                                if (pbwsum % 2 == 0)
                                {
                                    this.BackColor = Color.FromArgb(35, 33, 26);

                                }
                                else
                                {
                                    this.BackColor = Color.FromArgb(0, 229, 228);

                                }
                            }




                        }

                    }





                }
            }

            for (int i = 0; i <= 13; i++)
            {
                for (int j = 0; j <= 3; j++)
                {

                    if (jet2pb2[i].Bounds.IntersectsWith(pbw[j].Bounds))
                    {

                        pbwarmor[j] -= armorpbw;

                        jet2pb2[i].Location = new Point(pictureBox01.Location.X + 5, pictureBox01.Location.Y);

                        if (i == 0)
                        {
                            j2bullet1t = false;
                        }
                        else if (i == 1)
                        {
                            j2bullet2t = false;
                        }
                        else if (i == 2)
                        {
                            j2bullet3t = false;
                        }
                        else if (i == 3)
                        {
                            j2bullet4t = false;
                        }
                        else if (i == 4)
                        {
                            j2bullet5t = false;
                        }
                        else if (i == 5)
                        {
                            j2bullet6t = false;
                        }
                        else if (i == 6)
                        {
                            j2bullet7t = false;
                        }
                        else if (i == 7)
                        {
                            j2bullet8t = false;
                        }
                        else if (i == 8)
                        {
                            j2bullet9t = false;
                        }
                        else if (i == 9)
                        {
                            j2bullet10t = false;
                        }
                        else if (i == 10)
                        {
                            j2bullet11t = false;
                        }
                        else if (i == 11)
                        {
                            j2bullet12t = false;
                        }
                        else if (i == 12)
                        {
                            j2bullet13t = false;
                        }

                        if (pbwarmor[j] <= 0)
                        {
                            pbwarmor[j] = 0;
                        }

                        if (pbwarmor[j] == 0)
                        {

                            pbwarmor[j] = armorpbw;


                            explosion.Show();
                            explosion.Location = new Point(pbw[j].Location.X, pbw[j].Location.Y);
                            timer8.Enabled = true;

                            if (hurtrandom.Next(1, 25) == 3)
                            {

                                heart.Location = pbw[j].Location;
                                timer7.Enabled = true;
                            }
                            else if (hurtrandom.Next(1, 35) == 10)
                            {

                                bulletlevelup.Location = pbw[j].Location;
                                timer9.Enabled = true;
                            }


                            pbw[j].Location = new Point(pbw[j].Location.X, 450);

                            score++;



                            if (score % 100 == 0)
                            {
                                pbwsum++;

                                if (pbwsum % 2 == 0)
                                {
                                    this.BackColor = Color.FromArgb(35, 33, 26);

                                }
                                else
                                {
                                    this.BackColor = Color.FromArgb(0, 229, 228);

                                }
                            }
                            if (score % 100 == 0)
                            {
                                armorpbw++;

                            }



                        }

                    }


                }
            }





        }

        private void timer2_Tick(object sender, EventArgs e)
        {


            for (int i = 0; i < 13; i++)
            {

                if (pb[i].Location.Y <= -48)
                {
                    pb[i].Location = new Point(pictureBox1.Location.X + 33, pictureBox1.Location.Y);

                    if (i == 0)
                    {
                        bullet1 = false;
                    }
                    else if (i == 1)
                    {
                        bullet2 = false;
                    }
                    else if (i == 2)
                    {
                        bullet3 = false;
                    }
                    else if (i == 3)
                    {
                        bullet4 = false;
                    }
                    else if (i == 4)
                    {
                        bullet5 = false;
                    }
                    else if (i == 5)
                    {
                        bullet6 = false;
                    }
                    else if (i == 6)
                    {
                        bullet7 = false;
                    }
                    else if (i == 7)
                    {
                        bullet8 = false;
                    }
                    else if (i == 8)
                    {
                        bullet9 = false;
                    }
                    else if (i == 9)
                    {
                        bullet10 = false;
                    }
                    else if (i == 10)
                    {
                        bullet11 = false;
                    }
                    else if (i == 11)
                    {
                        bullet12 = false;
                    }
                    else if (i == 12)
                    {
                        bullet13 = false;
                    }
                }
            }



            if (bullet1)
            {
                pictureBox8.Location = new Point(pictureBox8.Location.X, pictureBox8.Location.Y - move);

            }
            if (bullet2)
            {
                pictureBox9.Location = new Point(pictureBox9.Location.X, pictureBox9.Location.Y - move);


            }
            if (bullet3)
            {
                pictureBox10.Location = new Point(pictureBox10.Location.X, pictureBox10.Location.Y - move);

            }
            if (bullet4)
            {
                pictureBox11.Location = new Point(pictureBox11.Location.X, pictureBox11.Location.Y - move);


            }
            if (bullet5)
            {
                pictureBox12.Location = new Point(pictureBox12.Location.X, pictureBox12.Location.Y - move);

            }
            if (bullet6)
            {
                pictureBox13.Location = new Point(pictureBox13.Location.X, pictureBox13.Location.Y - move);

            }
            if (bullet7)
            {
                pictureBox14.Location = new Point(pictureBox14.Location.X, pictureBox14.Location.Y - move);

            }
            if (bullet8)
            {
                pictureBox15.Location = new Point(pictureBox15.Location.X, pictureBox15.Location.Y - move);

            }
            if (bullet9)
            {
                pictureBox16.Location = new Point(pictureBox16.Location.X, pictureBox16.Location.Y - move);

            }
            if (bullet10)
            {
                pictureBox17.Location = new Point(pictureBox17.Location.X, pictureBox17.Location.Y - move);

            }
            if (bullet11)
            {
                pictureBox18.Location = new Point(pictureBox18.Location.X, pictureBox18.Location.Y - move);

            }
            if (bullet12)
            {
                pictureBox19.Location = new Point(pictureBox19.Location.X, pictureBox19.Location.Y - move);

            }
            if (bullet13)
            {
                pictureBox20.Location = new Point(pictureBox20.Location.X, pictureBox20.Location.Y - move);

            }

            for (int k = 0; k < 13; k++)
            {

                if (pb2[k].Location.Y <= -48)
                {
                    pb2[k].Location = new Point(pictureBox1.Location.X + 5, pictureBox1.Location.Y);

                    if (k == 0)
                    {
                        bullet1t = false;
                    }
                    else if (k == 1)
                    {
                        bullet2t = false;
                    }
                    else if (k == 2)
                    {
                        bullet3t = false;
                    }
                    else if (k == 3)
                    {
                        bullet4t = false;
                    }
                    else if (k == 4)
                    {
                        bullet5t = false;
                    }
                    else if (k == 5)
                    {
                        bullet6t = false;
                    }
                    else if (k == 6)
                    {
                        bullet7t = false;
                    }
                    else if (k == 7)
                    {
                        bullet8t = false;
                    }
                    else if (k == 8)
                    {
                        bullet9t = false;
                    }
                    else if (k == 9)
                    {
                        bullet10t = false;
                    }
                    else if (k == 10)
                    {
                        bullet11t = false;
                    }
                    else if (k == 11)
                    {
                        bullet12t = false;
                    }
                    else if (k == 12)
                    {
                        bullet13t = false;
                    }

                }

            }

            if (bullet1t)
            {
                pictureBox6.Location = new Point(pictureBox6.Location.X, pictureBox6.Location.Y - move);

            }
            if (bullet2t)
            {
                pictureBox7.Location = new Point(pictureBox7.Location.X, pictureBox7.Location.Y - move);


            }
            if (bullet3t)
            {
                pictureBox22.Location = new Point(pictureBox22.Location.X, pictureBox22.Location.Y - move);

            }
            if (bullet4t)
            {
                pictureBox23.Location = new Point(pictureBox23.Location.X, pictureBox23.Location.Y - move);


            }
            if (bullet5t)
            {
                pictureBox24.Location = new Point(pictureBox24.Location.X, pictureBox24.Location.Y - move);

            }
            if (bullet6t)
            {
                pictureBox25.Location = new Point(pictureBox25.Location.X, pictureBox25.Location.Y - move);

            }
            if (bullet7t)
            {
                pictureBox26.Location = new Point(pictureBox26.Location.X, pictureBox26.Location.Y - move);

            }
            if (bullet8t)
            {
                pictureBox27.Location = new Point(pictureBox27.Location.X, pictureBox27.Location.Y - move);

            }
            if (bullet9t)
            {
                pictureBox28.Location = new Point(pictureBox28.Location.X, pictureBox28.Location.Y - move);

            }
            if (bullet10t)
            {
                pictureBox29.Location = new Point(pictureBox29.Location.X, pictureBox29.Location.Y - move);

            }
            if (bullet11t)
            {
                pictureBox30.Location = new Point(pictureBox30.Location.X, pictureBox30.Location.Y - move);

            }
            if (bullet12t)
            {
                pictureBox31.Location = new Point(pictureBox31.Location.X, pictureBox31.Location.Y - move);

            }
            if (bullet13t)
            {
                pictureBox32.Location = new Point(pictureBox32.Location.X, pictureBox32.Location.Y - move);

            }


        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            sum++;

            if (levelup)
            {
                sum2++;
            }

            if (sum >= 13)
            {
                sum = 1;
            }

            if (sum2 >= 13)
            {
                sum2 = 1;
            }




            timer3.Enabled = false;
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            score++;


            if (score % 100 == 0)
            {
                pbwsum++;

                if (pbwsum % 2 == 0)
                {
                    this.BackColor = Color.FromArgb(35, 33, 26);

                }
                else
                {
                    this.BackColor = Color.FromArgb(0, 229, 228);

                }
            }

            if (score % 100 == 0)
            {
                armorpbw++;

            }

            label1.Text = score + "";

            label1sum = Convert.ToInt32(label1.Text);
            label2sum = Convert.ToInt32(label2.Text);

            if (label1sum >= label2sum)
            {
                File.WriteAllText("armortable.txt", label1.Text);
                label2.Text = label1.Text;
            }

        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            pbwsum++;

            if (score % 100 == 0)
            {
                pbwsum++;

                if (pbwsum % 2 == 0)
                {
                    this.BackColor = Color.FromArgb(35, 33, 26);

                }
                else
                {
                    this.BackColor = Color.FromArgb(0, 229, 228);

                }
            }






        }

        private void timer6_Tick(object sender, EventArgs e)
        {

            if (pbwsum % 2 == 0)
            {

                moon.Show();
                galaxy.Show();

                for (int i = 0; i <= 34; i++)
                {
                    star[i].Show();
                }

                if (moon.Location.Y >= 443)
                {
                    moon.Location = new Point(moon.Location.X, -74);
                }

                if (galaxy.Location.Y >= 443)
                {
                    galaxy.Location = new Point(galaxy.Location.X, -74);
                }

                moon.Location = new Point(moon.Location.X, moon.Location.Y + 1);

                galaxy.Location = new Point(galaxy.Location.X, galaxy.Location.Y + 1);

                for (int i = 0; i <= 34; i++)
                {
                    if (star[i].Location.Y >= 443)
                    {
                        star[i].Location = new Point(star[i].Location.X, -74);
                    }

                    star[i].Location = new Point(star[i].Location.X, star[i].Location.Y + 6);
                }

                sun.Hide();


            }
            else
            {
                sun.Show();

                for (int i = 0; i <= 34; i++)
                {
                    star[i].Hide();
                }
                moon.Hide();
                galaxy.Hide();

                if (sun.Location.Y >= 443)
                {
                    sun.Location = new Point(sun.Location.X, -74);
                }

                sun.Location = new Point(sun.Location.X, sun.Location.Y + 1);

            }


        }

        private void timer7_Tick(object sender, EventArgs e)
        {

            heart.Location = new Point(heart.Location.X, heart.Location.Y + 2);

            if (heart.Bounds.IntersectsWith(pictureBox1.Bounds))
            {
                if (armor < 3)
                {

                    armor++;
                    armorsum++;

                    armorbox[armorsum - 1].Show();

                }

                heart.Location = new Point(100, 500);
            }

            if (heart.Bounds.IntersectsWith(pictureBox01.Bounds))
            {
                if (j2armor < 3)
                {

                    j2armor++;
                    j2armorsum++;

                    j2armorbox[armorsum - 1].Show();

                }

                heart.Location = new Point(100, 500);
            }

        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            explosion.Hide();
            timer8.Enabled = false;
        }

        private void timer9_Tick(object sender, EventArgs e)
        {

            bulletlevelup.Location = new Point(bulletlevelup.Location.X, bulletlevelup.Location.Y + 2);

            if (bulletlevelup.Bounds.IntersectsWith(pictureBox1.Bounds))
            {
                levelup = true;
                bulletboost++;

                bulletlevelup.Location = new Point(100, 500);
            }

            if (bulletlevelup.Bounds.IntersectsWith(pictureBox01.Bounds))
            {
                j2levelup = true;
                bulletboost++;
                bulletlevelup.Location = new Point(100, 500);
            }

        }

        private void timer10_Tick(object sender, EventArgs e)
        {
            j2sum++;

            if (levelup)
            {
                j2sum2++;
            }

            if (j2sum >= 13)
            {
                j2sum = 1;
            }

            if (j2sum2 >= 13)
            {
                j2sum2 = 1;
            }




            timer10.Enabled = false;
        }

        private void timer11_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 13; i++)
            {

                if (jet2pb[i].Location.Y <= -48)
                {
                    jet2pb[i].Location = new Point(pictureBox01.Location.X + 33, pictureBox01.Location.Y);

                    if (i == 0)
                    {
                        j2bullet1 = false;
                    }
                    else if (i == 1)
                    {
                        j2bullet2 = false;
                    }
                    else if (i == 2)
                    {
                        j2bullet3 = false;
                    }
                    else if (i == 3)
                    {
                        j2bullet4 = false;
                    }
                    else if (i == 4)
                    {
                        j2bullet5 = false;
                    }
                    else if (i == 5)
                    {
                        j2bullet6 = false;
                    }
                    else if (i == 6)
                    {
                        j2bullet7 = false;
                    }
                    else if (i == 7)
                    {
                        j2bullet8 = false;
                    }
                    else if (i == 8)
                    {
                        j2bullet9 = false;
                    }
                    else if (i == 9)
                    {
                        j2bullet10 = false;
                    }
                    else if (i == 10)
                    {
                        j2bullet11 = false;
                    }
                    else if (i == 11)
                    {
                        j2bullet12 = false;
                    }
                    else if (i == 12)
                    {
                        j2bullet13 = false;
                    }
                }
            }



            if (j2bullet1)
            {
                pictureBox34.Location = new Point(pictureBox34.Location.X, pictureBox34.Location.Y - 12);

            }
            if (j2bullet2)
            {
                pictureBox35.Location = new Point(pictureBox35.Location.X, pictureBox35.Location.Y - 12);


            }
            if (j2bullet3)
            {
                pictureBox36.Location = new Point(pictureBox36.Location.X, pictureBox36.Location.Y - 12);

            }
            if (j2bullet4)
            {
                pictureBox37.Location = new Point(pictureBox37.Location.X, pictureBox37.Location.Y - 12);


            }
            if (j2bullet5)
            {
                pictureBox38.Location = new Point(pictureBox38.Location.X, pictureBox38.Location.Y - 12);

            }
            if (j2bullet6)
            {
                pictureBox39.Location = new Point(pictureBox39.Location.X, pictureBox39.Location.Y - 12);

            }
            if (j2bullet7)
            {
                pictureBox40.Location = new Point(pictureBox40.Location.X, pictureBox40.Location.Y - 12);

            }
            if (j2bullet8)
            {
                pictureBox41.Location = new Point(pictureBox41.Location.X, pictureBox41.Location.Y - 12);

            }
            if (j2bullet9)
            {
                pictureBox42.Location = new Point(pictureBox42.Location.X, pictureBox42.Location.Y - 12);

            }
            if (j2bullet10)
            {
                pictureBox43.Location = new Point(pictureBox43.Location.X, pictureBox43.Location.Y - 12);

            }
            if (j2bullet11)
            {
                pictureBox44.Location = new Point(pictureBox44.Location.X, pictureBox44.Location.Y - 12);

            }
            if (j2bullet12)
            {
                pictureBox45.Location = new Point(pictureBox45.Location.X, pictureBox45.Location.Y - 12);

            }
            if (j2bullet13)
            {
                pictureBox46.Location = new Point(pictureBox46.Location.X, pictureBox46.Location.Y - 12);

            }

            for (int k = 0; k < 13; k++)
            {

                if (jet2pb2[k].Location.Y <= -48)
                {
                    jet2pb2[k].Location = new Point(pictureBox01.Location.X + 5, pictureBox01.Location.Y);

                    if (k == 0)
                    {
                        j2bullet1t = false;
                    }
                    else if (k == 1)
                    {
                        j2bullet2t = false;
                    }
                    else if (k == 2)
                    {
                        j2bullet3t = false;
                    }
                    else if (k == 3)
                    {
                        j2bullet4t = false;
                    }
                    else if (k == 4)
                    {
                        j2bullet5t = false;
                    }
                    else if (k == 5)
                    {
                        j2bullet6t = false;
                    }
                    else if (k == 6)
                    {
                        j2bullet7t = false;
                    }
                    else if (k == 7)
                    {
                        j2bullet8t = false;
                    }
                    else if (k == 8)
                    {
                        j2bullet9t = false;
                    }
                    else if (k == 9)
                    {
                        j2bullet10t = false;
                    }
                    else if (k == 10)
                    {
                        j2bullet11t = false;
                    }
                    else if (k == 11)
                    {
                        j2bullet12t = false;
                    }
                    else if (k == 12)
                    {
                        j2bullet13t = false;
                    }

                }

            }

            if (j2bullet1t)
            {
                pictureBox48.Location = new Point(pictureBox48.Location.X, pictureBox48.Location.Y - 12);

            }
            if (j2bullet2t)
            {
                pictureBox49.Location = new Point(pictureBox49.Location.X, pictureBox49.Location.Y - 12);


            }
            if (j2bullet3t)
            {
                pictureBox50.Location = new Point(pictureBox50.Location.X, pictureBox50.Location.Y - 12);

            }
            if (j2bullet4t)
            {
                pictureBox51.Location = new Point(pictureBox51.Location.X, pictureBox51.Location.Y - 12);


            }
            if (j2bullet5t)
            {
                pictureBox52.Location = new Point(pictureBox52.Location.X, pictureBox52.Location.Y - 12);

            }
            if (j2bullet6t)
            {
                pictureBox53.Location = new Point(pictureBox53.Location.X, pictureBox53.Location.Y - 12);

            }
            if (j2bullet7t)
            {
                pictureBox54.Location = new Point(pictureBox54.Location.X, pictureBox54.Location.Y - 12);

            }
            if (j2bullet8t)
            {
                pictureBox55.Location = new Point(pictureBox55.Location.X, pictureBox55.Location.Y - 12);

            }
            if (j2bullet9t)
            {
                pictureBox56.Location = new Point(pictureBox56.Location.X, pictureBox56.Location.Y - 12);

            }
            if (j2bullet10t)
            {
                pictureBox57.Location = new Point(pictureBox57.Location.X, pictureBox57.Location.Y - 12);

            }
            if (j2bullet11t)
            {
                pictureBox58.Location = new Point(pictureBox58.Location.X, pictureBox58.Location.Y - 12);

            }
            if (j2bullet12t)
            {
                pictureBox59.Location = new Point(pictureBox59.Location.X, pictureBox59.Location.Y - 12);

            }
            if (j2bullet13t)
            {
                pictureBox60.Location = new Point(pictureBox60.Location.X, pictureBox60.Location.Y - 12);

            }

        }

        private void timer12_Tick(object sender, EventArgs e)
        {

            if (giantmove && giant.Location.Y <= 29)
            {
                for (int i = 0; i <= 5; i++)
                {
                    gianbullet[i].Location = new Point(gianbullet[i].Location.X, gianbullet[i].Location.Y + 5);
                }

                giant.Location = new Point(giant.Location.X, giant.Location.Y + 5);





            }

            if (!giantmove && giant.Location.Y >= -239)
            {
                for (int i = 0; i <= 5; i++)
                {
                    gianbullet[i].Location = new Point(gianbullet[i].Location.X, gianbullet[i].Location.Y - 5);
                }

                giant.Location = new Point(giant.Location.X, giant.Location.Y - 5);



            }

        }

        private void timer13_Tick(object sender, EventArgs e)
        {
            if (giantmove)
            {

                for (int i = 0; i <= 13; i++)
                {



                    if (giant.Bounds.IntersectsWith(pb[i].Bounds))
                    {
                        giantarmor -= bulletboost;

                        pb[i].Location = new Point(pictureBox1.Location.X + 33, pictureBox1.Location.Y);

                        if (i == 0)
                        {
                            bullet1 = false;
                        }
                        else if (i == 1)
                        {
                            bullet2 = false;
                        }
                        else if (i == 2)
                        {
                            bullet3 = false;
                        }
                        else if (i == 3)
                        {
                            bullet4 = false;
                        }
                        else if (i == 4)
                        {
                            bullet5 = false;
                        }
                        else if (i == 5)
                        {
                            bullet6 = false;
                        }
                        else if (i == 6)
                        {
                            bullet7 = false;
                        }
                        else if (i == 7)
                        {
                            bullet8 = false;
                        }
                        else if (i == 8)
                        {
                            bullet9 = false;
                        }
                        else if (i == 9)
                        {
                            bullet10 = false;
                        }
                        else if (i == 10)
                        {
                            bullet11 = false;
                        }
                        else if (i == 11)
                        {
                            bullet12 = false;
                        }
                        else if (i == 12)
                        {
                            bullet13 = false;
                        }

                        if (giantarmor <= 0)
                        {
                            giantarmor = 0;
                        }

                        if (giantarmor == 0)
                        {
                            timer1.Enabled = true;

                            giantmove = false;

                            giantbullet1.Location = new Point(giantbullet1.Location.X, -189);
                            giantbullet2.Location = new Point(giantbullet2.Location.X, -158);
                            giantbullet3.Location = new Point(giantbullet3.Location.X, -120);
                            giantbullet4.Location = new Point(giantbullet4.Location.X, -120);
                            giantbullet5.Location = new Point(giantbullet5.Location.X, -158);
                            giantbullet6.Location = new Point(giantbullet6.Location.X, -189);

                        }

                    }

                    if (giant.Bounds.IntersectsWith(pb2[i].Bounds))
                    {
                        giantarmor -= bulletboost;

                        pb2[i].Location = new Point(pictureBox1.Location.X + 5, pictureBox1.Location.Y);

                        if (i == 0)
                        {
                            bullet1t = false;
                        }
                        else if (i == 1)
                        {
                            bullet2t = false;
                        }
                        else if (i == 2)
                        {
                            bullet3t = false;
                        }
                        else if (i == 3)
                        {
                            bullet4t = false;
                        }
                        else if (i == 4)
                        {
                            bullet5t = false;
                        }
                        else if (i == 5)
                        {
                            bullet6t = false;
                        }
                        else if (i == 6)
                        {
                            bullet7t = false;
                        }
                        else if (i == 7)
                        {
                            bullet8t = false;
                        }
                        else if (i == 8)
                        {
                            bullet9t = false;
                        }
                        else if (i == 9)
                        {
                            bullet10t = false;
                        }
                        else if (i == 10)
                        {
                            bullet11t = false;
                        }
                        else if (i == 11)
                        {
                            bullet12t = false;
                        }
                        else if (i == 12)
                        {
                            bullet13t = false;
                        }

                        if (giantarmor <= 0)
                        {
                            giantarmor = 0;
                        }

                        if (giantarmor == 0)
                        {
                            timer1.Enabled = true;

                            giantmove = false;

                            giantbullet1.Location = new Point(giantbullet1.Location.X, -189);
                            giantbullet2.Location = new Point(giantbullet2.Location.X, -158);
                            giantbullet3.Location = new Point(giantbullet3.Location.X, -120);
                            giantbullet4.Location = new Point(giantbullet4.Location.X, -120);
                            giantbullet5.Location = new Point(giantbullet5.Location.X, -158);
                            giantbullet6.Location = new Point(giantbullet6.Location.X, -189);
                        }

                    }

                    if (giant.Bounds.IntersectsWith(jet2pb[i].Bounds))

                    {


                        giantarmor -= bulletboost;

                        jet2pb[i].Location = new Point(pictureBox01.Location.X + 5, pictureBox01.Location.Y);

                        if (i == 0)
                        {
                            j2bullet1 = false;
                        }
                        else if (i == 1)
                        {
                            j2bullet2 = false;
                        }
                        else if (i == 2)
                        {
                            j2bullet3 = false;
                        }
                        else if (i == 3)
                        {
                            j2bullet4 = false;
                        }
                        else if (i == 4)
                        {
                            j2bullet5 = false;
                        }
                        else if (i == 5)
                        {
                            j2bullet6 = false;
                        }
                        else if (i == 6)
                        {
                            j2bullet7 = false;
                        }
                        else if (i == 7)
                        {
                            j2bullet8 = false;
                        }
                        else if (i == 8)
                        {
                            j2bullet9 = false;
                        }
                        else if (i == 9)
                        {
                            j2bullet10 = false;
                        }
                        else if (i == 10)
                        {
                            j2bullet11 = false;
                        }
                        else if (i == 11)
                        {
                            j2bullet12 = false;
                        }
                        else if (i == 12)
                        {
                            j2bullet13 = false;
                        }

                        if (giantarmor <= 0)
                        {
                            giantarmor = 0;
                        }

                        if (giantarmor == 0)
                        {
                            timer1.Enabled = true;

                            giantmove = false;

                            giantbullet1.Location = new Point(giantbullet1.Location.X, -189);
                            giantbullet2.Location = new Point(giantbullet2.Location.X, -158);
                            giantbullet3.Location = new Point(giantbullet3.Location.X, -120);
                            giantbullet4.Location = new Point(giantbullet4.Location.X, -120);
                            giantbullet5.Location = new Point(giantbullet5.Location.X, -158);
                            giantbullet6.Location = new Point(giantbullet6.Location.X, -189);

                        }
                    }

                    if (giant.Bounds.IntersectsWith(jet2pb2[i].Bounds))

                    {

                        giantarmor -= bulletboost;

                        jet2pb2[i].Location = new Point(pictureBox01.Location.X + 5, pictureBox01.Location.Y);

                        if (i == 0)
                        {
                            j2bullet1t = false;
                        }
                        else if (i == 1)
                        {
                            j2bullet2t = false;
                        }
                        else if (i == 2)
                        {
                            j2bullet3t = false;
                        }
                        else if (i == 3)
                        {
                            j2bullet4t = false;
                        }
                        else if (i == 4)
                        {
                            j2bullet5t = false;
                        }
                        else if (i == 5)
                        {
                            j2bullet6t = false;
                        }
                        else if (i == 6)
                        {
                            j2bullet7t = false;
                        }
                        else if (i == 7)
                        {
                            j2bullet8t = false;
                        }
                        else if (i == 8)
                        {
                            j2bullet9t = false;
                        }
                        else if (i == 9)
                        {
                            j2bullet10t = false;
                        }
                        else if (i == 10)
                        {
                            j2bullet11t = false;
                        }
                        else if (i == 11)
                        {
                            j2bullet12t = false;
                        }
                        else if (i == 12)
                        {
                            j2bullet13t = false;
                        }

                        if (giantarmor <= 0)
                        {
                            giantarmor = 0;
                        }

                        if (giantarmor == 0)
                        {
                            timer1.Enabled = true;

                            giantmove = false;

                            giantbullet1.Location = new Point(giantbullet1.Location.X, -189);
                            giantbullet2.Location = new Point(giantbullet2.Location.X, -158);
                            giantbullet3.Location = new Point(giantbullet3.Location.X, -120);
                            giantbullet4.Location = new Point(giantbullet4.Location.X, -120);
                            giantbullet5.Location = new Point(giantbullet5.Location.X, -158);
                            giantbullet6.Location = new Point(giantbullet6.Location.X, -189);

                        }

                    }


                }

                for (int i = 0; i <= 5; i++)
                {
                    if (gianbullet[i].Location.Y >= 445)
                    {
                        if (i == 0)
                        {
                            giantbullet1.Location = new Point(giantbullet1.Location.X, -189 + 50);
                        }

                        if (i == 1)
                        {
                            giantbullet2.Location = new Point(giantbullet2.Location.X, -158 + 50);
                        }

                        if (i == 2)
                        {
                            giantbullet3.Location = new Point(giantbullet3.Location.X, -120 + 50);
                        }

                        if (i == 3)
                        {
                            giantbullet4.Location = new Point(giantbullet4.Location.X, -120 + 50);
                        }

                        if (i == 4)
                        {
                            giantbullet5.Location = new Point(giantbullet5.Location.X, -158 + 50);
                        }

                        if (i == 5)
                        {
                            giantbullet6.Location = new Point(giantbullet6.Location.X, -189 + 50);
                        }

                    }

                    if (i % 2 == 0)
                    {
                        gianbullet[i].Location = new Point(gianbullet[i].Location.X, gianbullet[i].Location.Y + 1);

                    }

                    else
                    {
                        gianbullet[i].Location = new Point(gianbullet[i].Location.X, gianbullet[i].Location.Y + 2);
                    }




                }

            }

            if (!cheettest)
            {
                for (int i = 0; i <= 3; i++)
                {
                    for (int j = 0; j <= 5; j++)
                    {


                        if (pictureBox1.Bounds.IntersectsWith(pbw[i].Bounds) || pictureBox1.Bounds.IntersectsWith(gianbullet[j].Bounds))
                        {

                            if (pictureBox1.Bounds.IntersectsWith(gianbullet[j].Bounds))
                            {
                                if (j == 0)
                                {
                                    giantbullet1.Location = new Point(giantbullet1.Location.X, -189 + 50);
                                }

                                if (j == 1)
                                {
                                    giantbullet2.Location = new Point(giantbullet2.Location.X, -158 + 50);
                                }

                                if (j == 2)
                                {
                                    giantbullet3.Location = new Point(giantbullet3.Location.X, -120 + 50);
                                }

                                if (j == 3)
                                {
                                    giantbullet4.Location = new Point(giantbullet4.Location.X, -120 + 50);
                                }

                                if (j == 4)
                                {
                                    giantbullet5.Location = new Point(giantbullet5.Location.X, -158 + 50);
                                }

                                if (j == 5)
                                {
                                    giantbullet6.Location = new Point(giantbullet6.Location.X, -189 + 50);
                                }

                            }



                            armorsum--;
                            armor--;

                            pbw[i].Location = new Point(pbw[i].Location.X, 450);


                            armorbox[armorsum].Hide();



                            if (armor == 0)
                            {

                                label1sum = Convert.ToInt32(label1.Text);
                                label2sum = Convert.ToInt32(label2.Text);

                                if (label1sum >= label2sum)
                                {
                                    File.WriteAllText("armortable.txt", label1.Text);
                                    label2.Text = label1.Text;
                                }

                                giantbullet1.Location = new Point(giantbullet1.Location.X, -189);
                                giantbullet2.Location = new Point(giantbullet2.Location.X, -158);
                                giantbullet3.Location = new Point(giantbullet3.Location.X, -120);
                                giantbullet4.Location = new Point(giantbullet4.Location.X, -120);
                                giantbullet5.Location = new Point(giantbullet5.Location.X, -158);
                                giantbullet6.Location = new Point(giantbullet6.Location.X, -189);

                                timer1.Enabled = false;
                                timer2.Enabled = false;
                                timer3.Enabled = false;
                                timer4.Enabled = false;
                                timer6.Enabled = false;
                                giantmove = false;
                                f = true;
                                g = true;
                                chek = false;

                                

                                MessageBox.Show("Game ovvver");
                                Enterchek = true;


                            }

                        }

                    }
                }
            }
            if (!cheettest)
            {
                for (int i = 0; i <= 3; i++)
                {
                    for (int j = 0; j <= 5; j++)
                    {

                        if (pictureBox01.Bounds.IntersectsWith(pbw[i].Bounds) || pictureBox01.Bounds.IntersectsWith(gianbullet[j].Bounds))
                        {

                            if (pictureBox01.Bounds.IntersectsWith(gianbullet[j].Bounds))
                            {
                                if (j == 0)
                                {
                                    giantbullet1.Location = new Point(giantbullet1.Location.X, -189 + 50);
                                }

                                if (j == 1)
                                {
                                    giantbullet2.Location = new Point(giantbullet2.Location.X, -158 + 50);
                                }

                                if (j == 2)
                                {
                                    giantbullet3.Location = new Point(giantbullet3.Location.X, -120 + 50);
                                }

                                if (j == 3)
                                {
                                    giantbullet4.Location = new Point(giantbullet4.Location.X, -120 + 50);
                                }

                                if (j == 4)
                                {
                                    giantbullet5.Location = new Point(giantbullet5.Location.X, -158 + 50);
                                }

                                if (j == 5)
                                {
                                    giantbullet6.Location = new Point(giantbullet6.Location.X, -189 + 50);
                                }

                            }

                            j2armorsum--;
                            j2armor--;

                            pbw[i].Location = new Point(pbw[i].Location.X, 450);


                            j2armorbox[j2armorsum].Hide();



                            if (j2armor == 0)
                            {

                                label1sum = Convert.ToInt32(label1.Text);
                                label2sum = Convert.ToInt32(label2.Text);

                                if (label1sum >= label2sum)
                                {
                                    File.WriteAllText("armortable.txt", label1.Text);
                                    label2.Text = label1.Text;
                                }

                                giantbullet1.Location = new Point(giantbullet1.Location.X, -189);
                                giantbullet2.Location = new Point(giantbullet2.Location.X, -158);
                                giantbullet3.Location = new Point(giantbullet3.Location.X, -120);
                                giantbullet4.Location = new Point(giantbullet4.Location.X, -120);
                                giantbullet5.Location = new Point(giantbullet5.Location.X, -158);
                                giantbullet6.Location = new Point(giantbullet6.Location.X, -189);

                                timer1.Enabled = false;
                                timer2.Enabled = false;
                                timer3.Enabled = false;
                                timer4.Enabled = false;
                                timer6.Enabled = false;
                                f = true;
                                g = true;
                                chek = false;

                                

                                MessageBox.Show("Game ovvver");
                                Enterchek = true;


                            }
                        }

                    }
                }
            }


        }

        private void timer14_Tick(object sender, EventArgs e)
        {
            auto = true;
            timer14.Enabled = false;        
        }

    }
}