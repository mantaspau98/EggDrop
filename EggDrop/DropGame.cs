using System;
using System.Collections.Generic;
using System.Text;

namespace EggDrop
{
    public class DropGame
    {
        int numOfLevels;
        int breaksOnLevel;
        public DropGame(int numOfLevels, int breaksOnLevel)
        {
            this.numOfLevels = numOfLevels;
            this.breaksOnLevel = breaksOnLevel;
        }

        public void setBreaksOnLevel(int breaksOnLevel)
        {
            this.breaksOnLevel = breaksOnLevel;
        }

        public Boolean TestIfBreaks(int level)
        {
            
            //if the level is equal or higher - the egg breaks
            if (level >= this.breaksOnLevel)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public int FindHighestLevel()
        {
            //split into 10 segments
            int x = this.numOfLevels / 10;

            for(int i = 10; i <= this.numOfLevels; i+=x)
            {
                
                if (this.TestIfBreaks(i))
                {
                    // if webreak our first egg
                    for (int j = 0; j <= x; j++)
                    {
                        
                        if (this.TestIfBreaks(i-x + j))
                        {
                            //if we break the second egg - return the previous floor
                            return i-x + j - 1;
                        }
                    }
                }

            }
            return this.numOfLevels;
        }
    }
}
