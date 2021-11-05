using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class LoseScreen : Form
    {
        public LoseScreen()
        {
            this.ControlBox = false;
            this.BackgroundImage = Properties.Resources.GameOverPicture;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            InitializeComponent();
            var timer = new Timer();
            //change the background image every second  
            timer.Interval = 1000;
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Start();
        }

        void Timer_Tick(object sender, EventArgs e)
        {
            //add image in list from resource file.  
            List<Bitmap> lisimage = new List<Bitmap>();
            lisimage.Add(Properties.Resources.GameOverPicture);
            var indexbackimage = DateTime.Now.Second % lisimage.Count;
            this.BackgroundImage = lisimage[indexbackimage];
        }

        // Play again from the beginning buttons
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        // exit button
        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
