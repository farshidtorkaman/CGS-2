using System;
using System.Windows.Forms;

namespace ArtGalleryWin
{
    public partial class Form1 : Form
    {
        private int _wrongSubmittedCount = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(username.Text) || string.IsNullOrWhiteSpace(password.Text))
            {
                MessageBox.Show("Username and Password is Required");
                return;
            }

            if (username.Text != "CGS" && password.Text != "admin")
            {
                _wrongSubmittedCount++;
                MessageBox.Show("Wrong Username and Password");
                if (_wrongSubmittedCount == 4)
                {
                    Application.Exit();
                }

                return;
            }

            var cgsArt = new CgsArt { Visible = true };
            cgsArt.Activate();
            this.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
