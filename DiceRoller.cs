using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2
{
    internal class DiceRoller
    {
        private Random random = new Random();

        public int[] SimulateRolls(int numberOfRolls)
        {
            int[] results = new int[11];

            for (int i = 0; i < numberOfRolls; i++)
            {
                int dice1 = random.Next(1, 7);
                int dice2 = random.Next(1, 7);

                int sum = dice1 + dice2;

                results[sum - 2]++;
            }

            return results;
        }
    }
}
