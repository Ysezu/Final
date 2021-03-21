using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kura
{
   
    public partial class MainMenu : Form
    {
        Random rnd;
        int cloudspeed;
        PictureBox[] cloud;
   
        public MainMenu()
        {
            InitializeComponent();
        }
        private void TimeMenu_Tick(object sender, EventArgs e)
        {
            for(int i = 0; i < cloud.Length; i++)
            {
                cloud[i].Left += cloudspeed;
                if(cloud[i].Left > 1280)
                {
                    cloud[i].Left = cloud[i].Height;
                }
            }
            for( int i = cloud.Length; i < cloud.Length; i++)
            {
                cloud[i].Left += cloudspeed - 10;
                if(cloud[i].Left >= 1280)
                {
                    cloud[i].Left = cloud[i].Left;
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cloudspeed = 5;
            cloud = new PictureBox[20];
            rnd = new Random();

                for( int i = 0; i < cloud.Length; i++)
            {
                cloud[i] = new PictureBox();
                cloud[i].BorderStyle = BorderStyle.None;
                cloud[i].Location = new Point(rnd.Next(-1200, 1100), rnd.Next(120, 280));
                if(i %2 == 0)
                {
                    cloud[i].Size = new Size(rnd.Next(100, 230), rnd.Next(30, 70));
                    cloud[i].BackColor = Color.FromArgb(rnd.Next(40, 120), 255, 200, 200);
                }
                else
                {
                    cloud[i].Size = new Size(150,25);
                    cloud[i].BackColor = Color.FromArgb(rnd.Next(40, 120), 255, 205, 205);
                }
                this.Controls.Add(cloud[i]);
            }
        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Game1 game1 = new Game1();
            game1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Game2 game2 = new Game2();
            game2.Show();
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.Font = new Font("Tahoma", 36);
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.Font = new Font("Tahoma", 28);
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.Font = new Font("Tahoma", 36);
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.Font = new Font("Tahoma", 28);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Game1 game1 = new Game1();
            game1.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Game2 game2 = new Game2();
            game2.Show();
        }
    }
}
