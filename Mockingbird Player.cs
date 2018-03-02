using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * 
 */

namespace MusicProgram
{
    public partial class Player : Form
    {
        bool isPlaying = false;

        MockingbirdLauncher form = new MockingbirdLauncher();

        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();

        public Player()
        {
            InitializeComponent();
        }

        private void Player_Load(object sender, EventArgs e)
        {
            //loads files and properties into array
            form.SetFilepath();

            form.SetFileProperties();

            songListBox.Items.Clear();

            //debug code
            //MessageBox.Show(form.SongNum().ToString() + " songs");

            for(int a = 0;a < form.SongNum(); a++)
            {
                //debug code
                //MessageBox.Show(form.SongNum().ToString());
                //MessageBox.Show(form.GetFileProperties(a, 0));
                songListBox.Items.Add(form.GetFileProperties(a, 1));
            }
        }

        private void Play()
        {
            //Make the application reference the selected file and play it
            wplayer.URL = songListBox.GetItemText(form.GetFileProperties(songListBox.SelectedIndex,0));
            wplayer.controls.play();

            playPauseButton.Image = MusicProgram.Properties.Resources.mockingpause;
        }

        private void Pause()
        {
            //Make the application stop the currently playing file
            wplayer.controls.pause();

            playPauseButton.Image = MusicProgram.Properties.Resources.mockingplay;
        }

        private void Next()
        {
            if (songListBox.SelectedIndex == 143)
            {
                songListBox.SelectedIndex = 0;
            }
            else
            {
                songListBox.SelectedIndex += 1;
            }

            if (isPlaying == true)
            {
                Play();
            }
        }

        private void Previous()
        {
            if (songListBox.SelectedIndex < 1)
            {
                songListBox.SelectedIndex = 143;
            }
            else
            {
                songListBox.SelectedIndex -= 1;
            }

            if (isPlaying == true)
            {
                Play();
            }
        }

        private void playPauseButton_Click(object sender, EventArgs e)
        {
            if (songListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Select a song.");
            }

            else if (isPlaying == false)
            {
                Play();
                isPlaying = true;
            }

            else
            {
                Pause();
                isPlaying = false;
            }
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            Previous();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            Next();
        }

        private void exitLaunchButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
