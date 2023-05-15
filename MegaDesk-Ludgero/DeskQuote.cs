using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Ludgero
{
    internal class DeskQuote
    {
        
        private string _name;
        public enum RushOrderOptions
        {
            Day3,
            Day5,
            Day7,
            Default14
        }
        private RushOrderOptions _chosenRushOrder = RushOrderOptions.Default14;
        
    }
}
