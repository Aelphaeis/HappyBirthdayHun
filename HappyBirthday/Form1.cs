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

using HappyBirthday.Screens;
namespace HappyBirthday
{
    public partial class Form1 : Form
    {
        const string song = "happy birthday song.mp3";
        Mp3Player player;
        List<UserControl> Screens;
        public Form1()
        {
            InitializeComponent();
            player = new Mp3Player();
            //does song exist in file directory? If not create it
            if (!File.Exists(song))
                File.WriteAllBytes(song, Resources.happy_birthday_song);

            //Create list to keep displays
            Screens = new List<UserControl>();
            Screens.Add(new Screen1{ Visible = true });
            Screens.Add(new Screen2 { Visible = false });
            Screens.Add(new Screen3 { Visible = false });
            Screens.Add(new Screen4 { Visible = false });
            Screens.Add(new Screen5 { Visible = false });
            Screens.Add(new Screen6 { Visible = false });
            Screens.Add(new Screen7 { Visible = false });
            Screens.Add(new Screen8 { Visible = false });

            //add screens to display;
            PlaySong();
        }



        public void NextScreen()
        {
            //Get the visible Screen
            var screen = Screens.First(p => p.Visible);
            var index = Screens.IndexOf(screen);

            //Determine if a the next screen exists
            if ((index + 1) > (Screens.Count - 1))
                return;

            //Hide current Screen, show next screen
            screen.Visible = false;
            Screens[index + 1].Visible = true;
        }

        public void PrevScreen()
        {
            //Get the visible Screen
            var screen = Screens.First(p => p.Visible);
            var index = Screens.IndexOf(screen);

            //Determine if a the previous screen exists
            if ((index - 1) < 0)
                return;

            //Hide current Screen, show previous screen
            screen.Visible = false;
            Screens[index - 1].Visible = true;

        }

        public void PlaySong()
        {
            player.Open(song);
            player.Play(true);
        }

        public void StopSong()
        {
            player.Close();
        }

        private void Play_Click(object sender, EventArgs e)
        {
            PlaySong();
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            StopSong();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Load all Screens into Panel
            foreach (var screen in Screens)
                panel1.Controls.Add(screen);
        }

        private void Next_Click(object sender, EventArgs e)
        {
            NextScreen();
        }

        private void Prev_Click(object sender, EventArgs e)
        {
            PrevScreen();
        }
    }
}
