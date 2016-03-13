using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RussianRoulette
{
    class GamePlay
    {
        public int RND;  
        
        private int _Random;

        public int RollingTotal = 0;
        public int Random
        {
            //RNG
            get
            {
                Random myRandom = new Random();
              _Random =  myRandom.Next(1, 7);

                return _Random;
            }
          
        }





    }
}
