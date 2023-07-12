using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayerApplication
{
    public partial class MusicPlayer : Form
    {
        public MusicPlayer()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //select songs
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true; //code to select many songs
            if(ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames; //save track name in files array
                paths = ofd.FileNames; //save file path in paths array

                for(int i=0; i<files.Length; i++)
                {
                    listBoxSongs.Items.Add(files[i]); //show songs in listbox
                }
            }
        }

        //create array to save the title and path of music tracks

        String[] paths, files;

        private void listBoxSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            //code will play selected song
            WindowsMusicPlayer.URL = paths[listBoxSongs.SelectedIndex];
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //close the app
            this.Close();
        }
    }
}
