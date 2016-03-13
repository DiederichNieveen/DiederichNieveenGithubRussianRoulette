using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RussianRoulette.Properties;

namespace RussianRoulette
{
    public partial class Menu : Form
    {
        GamePlay myGamePlay = new GamePlay();

        public List<Image> Images = new List<Image>();

        public List<int>ImageScore = new List<int>(); 


        public Menu()
        {
            InitializeComponent();

            myGamePlay.RND = myGamePlay.Random;

            //Images & scores
            Images.Add(Resources._6a00d83451bf3169e200e54f87cdf08834_500wi);
            Images.Add(Resources.fossil_turtle2);
            Images.Add(Resources.IMG_3799);
            Images.Add(Resources.one_of_five_caches_jewellery);
            Images.Add(Resources.Roman_statues);
            Images.Add(Resources.Stump7_08);
            ImageScore.Add(100);
            ImageScore.Add(200);
            ImageScore.Add(300);
            ImageScore.Add(400);
            ImageScore.Add(500);
            //ImageScore.Add(600);
        }

       

       
        private void AllDirtpile_Click(object sender, EventArgs e)
        {
            PictureBox fakePictureBox = (PictureBox) sender;
           
        //    myGamePlay.RND;

        //    fakePictureBox.Name;
        //    fakePictureBox.Tag;

            //Making picture fit
            Dirtpile1.SizeMode = PictureBoxSizeMode.StretchImage;
            Dirtpile2.SizeMode = PictureBoxSizeMode.StretchImage;
            Dirtpile3.SizeMode = PictureBoxSizeMode.StretchImage;
            Dirtpile4.SizeMode = PictureBoxSizeMode.StretchImage;
            Dirtpile5.SizeMode = PictureBoxSizeMode.StretchImage;
            Dirtpile6.SizeMode = PictureBoxSizeMode.StretchImage;

            //Sound when picture is clicked
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.Shovel_Digging);
            player.Play();

            //Fail when you get the empty hole
            if (myGamePlay.RND == Convert.ToInt32(fakePictureBox.Tag))
            {
                fakePictureBox.Image = Images[Images.Count - 1];
                //int lose = 1;
                //lbllose.Text = lose.ToString();
                MessageBox.Show("Sorry, you found nothing");
                this.Close();
                return;
            }

            //RNG for random pictures
            Random myRandom = new Random();
            int rdmImage =          myRandom.Next(0, Images.Count - 1);


            fakePictureBox.Image = Images[rdmImage];
            Images.RemoveAt(rdmImage);

            myGamePlay.RollingTotal += ImageScore[rdmImage];
            lblscore.Text = myGamePlay.RollingTotal.ToString();
            ImageScore.RemoveAt(rdmImage);

         
            //switch (myGamePlay.RND)
            //{
            //    case 1:

            //        fakePictureBox.Image = Images[1];
            //        Images.RemoveAt(1);
            //        int add100 = 100;
            //        lblscore.Text = add100.ToString();
            //        break;
            //    case 2:

            //        fakePictureBox.Image = Resources.fossil_turtle2;
            //        int add200 = 200;
            //        lblscore.Text = add200.ToString();
            //        break;
            //    case 3:

            //        fakePictureBox.Image = Resources.IMG_3799;
            //        int add300 = 300;
            //        lblscore.Text = add300.ToString();
            //        break;
            //    case 4:

            //        fakePictureBox.Image = Resources.one_of_five_caches_jewellery;
            //        int add500 = 500;
            //        lblscore.Text = add500.ToString();
            //        break;
            //    case 5:

            //        fakePictureBox.Image = Resources.Roman_statues;
            //        int add750 = 750;
            //        lblscore.Text = add750.ToString();
            //        break;
            //    case 6:

            //        fakePictureBox.Image = Resources.Stump7_08;
            //        int lose = 1;
            //        lbllose.Text = lose.ToString();
            //        break;

            //}
          //  SoundPlayer simPlayerSound = new SoundPlayer();

           


         //   fakePictureBox.Image = Resources.Fluffy_Dirt_Mole_Mound_tn1;

        }


    }
}
