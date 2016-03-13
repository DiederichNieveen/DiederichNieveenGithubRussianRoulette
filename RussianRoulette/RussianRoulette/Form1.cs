using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RussianRoulette
{
    public partial class Game : Form
    {
      //  GamePlay myGamePlay = new GamePlay();
        public Game()
        {
            InitializeComponent();
        }

        

        private void StartGame(object sender, EventArgs e)
        {
            
            //opens main game
            Menu secondMenu = new Menu();
                
            secondMenu.Show();
            //myGamePlay.RND = myGamePlay.Random;


        }

        private void CloseMenu(object sender, EventArgs e)
        {
            //closes window
            this.Close();
        }

    
         
    }
}
