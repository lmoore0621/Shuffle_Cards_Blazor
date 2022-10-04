using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShuffleDeck.Models
{
    public class Players
    {
        public List<Card> PlayerOne { get; set; }
        public List<Card> PlayerTwo { get; set; }
        public List<Card> PlayerThree { get; set; }
        public List<Card> PlayerFour { get; set; }
    }
}
