using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class FruitTree
    {
        public string TypeOfFruit { get; }
        private int piecesOfFruitLeft;
        public int PiecesOfFruitLeft
        {
            get
            {
                return piecesOfFruitLeft;
            }
            private set
            {
                PiecesOfFruitLeft = piecesOfFruitLeft;
            }

           
        }
        public bool PickFruit(int numberOfPiecesToRemove)
        {
            if (piecesOfFruitLeft > 0)
            {
                piecesOfFruitLeft -= numberOfPiecesToRemove;
                return true;
            }
            else
            {
                return false;
            }
        }

        public FruitTree(string typeOfFruit, int startingPiecesOfFruit)
        {
            TypeOfFruit = typeOfFruit;
            piecesOfFruitLeft = startingPiecesOfFruit;
        }
    }
}
