using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fall2020_CSC403_Project.code;


namespace Fall2020_CSC403_Project
{
    public partial class startMenu : Form
    {
        public startMenu()
        {
            InitializeComponent();
        }

        private void startMenu_Load(object sender, EventArgs e)
        {
        }

        private void Exit_MouseClick(object sender, MouseEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Start_MouseClick(object sender, MouseEventArgs e)
        {
            modeSelection mode = new modeSelection();
            mode.Show();
        }

        private void Options_MouseClick(object sender, MouseEventArgs e)
        {
            Options options = new Options();
            options.Show();
        }
    }
}

