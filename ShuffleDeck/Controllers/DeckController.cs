using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ShuffleDeck.Models;

namespace ShuffleDeck.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DeckController : ControllerBase
    {
        private static readonly List<char> Suits = new List<char>()
        {
            '♥', '♦', '♠', '♣'
        };

        private static readonly List<string> Values = new List<string>()
        {
            "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"
        };

        [HttpGet]
        [Route("api")]
        public IEnumerable<Card> Get()
        {
            var deck = new List<Card>();
            var count = 1;

            //foreach Suit  
            foreach (var suit in Suits)
            {
                //add a value
                foreach (var value in Values)
                {
                    var card = new Card();
                    card.Id = count++;
                    card.Suit = suit;
                    card.Value = value;

                    //then add new card to deck
                    deck.Add(card);
                }
            }

            return deck;
        }
    }
}