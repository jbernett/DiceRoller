using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiceRoller.Models
{
    public class DiceVM
    {
        public int selectedDie { get; set; }
        public int amount { get; set; }
        public int total { get; set; }

        public int GetTotal(int selectedDie, int amount)
        {
            Random generator = new Random();
            for (int i = 0; i < amount; i++)
            {
                total += generator.Next(selectedDie)+1;
            }
            return total;
        }
    }
}
