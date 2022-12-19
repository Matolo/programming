using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyCrushLogic
{
    public class CandyCrusher
    {
        public static bool ScoreRowPresent(RegularCandies[,] playingField)
        {

            for (int row = 0; row < playingField.GetLength(0); row++)
            {
                int counter = 1;
                for (int column = 1; column < playingField.GetLength(1); column++)
                {
                    if (playingField[row, column] == playingField[row, column - 1])
                    {
                        counter++;
                        if (counter == 3)
                            return true;
                    }
                    else
                        counter = 1;
                }
            }
            return false;
        }
        public static bool ScoreColumnPresent(RegularCandies[,] playingField)
        {

            for (int column = 0; column < playingField.GetLength(0); column++)
            {
                int counter = 1;
                for (int row = 1; row < playingField.GetLength(1); row++)
                {
                    if (playingField[row, column] == playingField[row - 1, column])
                    {
                        counter++;
                        if (counter == 3)
                            return true;
                    }
                    else
                        counter = 1;
                }
            }
            return false;
        }
    }
}
