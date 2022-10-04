using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShuffleDeck.Models
{
    public class Card
    {
        public int? Id { get; set; }
        public char Suit { get; set; }
        public string Value { get; set; }
    }
}
