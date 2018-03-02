using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

/* Things To Implement:
 * 
 * Improved File Scanning Algorithm.
 * 
 */

namespace MusicProgram
{
    public partial class MockingbirdLauncher : Form
    {
        string version = "1.0.0";

        string[] filepath = new string[0];
        string[][] files;
        string[] subdir;

        string envdir;

        public MockingbirdLauncher()
        {
            InitializeComponent();
        }

        public void SetFilepath()
        {
            
            filepath = Directory.GetFiles(Directory.GetCurrentDirectory(), "*.mp3", SearchOption.AllDirectories);
        }

        public void SetFileProperties()
        {
            files = new string[filepath.Length][];
            //initaializes jagged array
            for (int i = 0; i < filepath.Length; i++)
            {
                files[i] = new string[3];
            }

            //assigns properties to array
            for (int i = 0; i < files.Length; i++)
            {
                files[i][0] = filepath[i];

                var mp3file = TagLib.File.Create(files[i][0]);

                files[i][1] = mp3file.Tag.Title;
                files[i][2] = mp3file.Tag.FirstAlbumArtist;


                //debug code
                //MessageBox.Show(files[i][1] + " by " + files[i][2] + "\r\n" + "at " + files[i][0]);
            }

            for (int i = 0; i < files.Length; i++)
            {
                if (files[i][1] == null)
                {
                    files[i][1] = "";
                }
                if (files[i][2] == null)
                {
                    files[i][2] = "";
                }
            }
        }
        public string GetFileProperties(int arr,int item)
        {
            return files[arr][item];
        }

        public int SongNum()
        {
            return filepath.Length;
        }

        public void DirectoryChange(string dir)
        {
            string a = Directory.GetCurrentDirectory();

            Directory.SetCurrentDirectory(envdir);

            StreamWriter directoryFile;

            directoryFile = File.CreateText(".\\Directory.txt");
            directoryFile.WriteLine(dir);

            directoryFile.Close();

            Directory.SetCurrentDirectory(a);

        }

        //Rewrites the information to the informationTextBox
        public void RewriteTextBox()
        {
            informationTextBox.Text = "Mockingbird Player" + "\r\n" +
                                    version + "\r\n \r\n" + "Current Directory: \r\n" 
                                    + Directory.GetCurrentDirectory();
        }

        private void MockingbirdLauncher_Load(object sender, EventArgs e)
        {
            //initial load of the informationTextBox
            envdir = Environment.CurrentDirectory;

            StreamReader dirInput;

            dirInput = File.OpenText(".\\Directory.txt");

            Directory.SetCurrentDirectory(dirInput.ReadLine());

            dirInput.Close();

            RewriteTextBox();
        }

        //Launches Player Window
        private void playerLaunchButton_Click(object sender, EventArgs e)
        {
            Player myPlayer = new Player();
            
            myPlayer.ShowDialog();
        }

        //Allows user to change music directory
        private void directoryButton_Click(object sender, EventArgs e)
        {

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                DirectoryChange(folderBrowserDialog1.SelectedPath);

                Directory.SetCurrentDirectory(folderBrowserDialog1.SelectedPath);
            }
            RewriteTextBox();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
