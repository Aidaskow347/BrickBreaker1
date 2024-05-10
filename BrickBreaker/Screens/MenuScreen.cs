using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace BrickBreaker
{
    public partial class MenuScreen : UserControl
    {
        public MenuScreen()
        {
            InitializeComponent();

            //play menu song on launch

             Form1.backSound.Play();

        }

        private void exitButton_Click(object sender, EventArgs e)
        {             
            Application.Exit();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            /*
            // Goes to the game screen
            GameScreen gs = new GameScreen();
            Form form = this.FindForm();

            form.Controls.Add(gs);
            form.Controls.Remove(this);

            gs.Location = new Point((form.Width - gs.Width) / 2, (form.Height - gs.Height) / 2);
            */


            // Goes to the level screen
            LevelScreen ls = new LevelScreen();
            Form form = this.FindForm();

            form.Controls.Add(ls);
            form.Controls.Remove(this);

            ls.Location = new Point((form.Width - ls.Width) / 2, (form.Height - ls.Height) / 2);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
