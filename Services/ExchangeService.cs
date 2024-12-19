using Gift_Exchange.Models;
using System.Collections.Generic;
using System.Linq;

namespace Gift_Exchange.Services
{
    public class ExchangeService
    {
        public List<GiftExchangePair> GenerateGiftExchangePairs(List<Player> players)
        {
            var shuffledPlayers = players.OrderBy(p => Guid.NewGuid()).ToList();
            var pairs = new List<GiftExchangePair>();

            for (int i = 0; i < shuffledPlayers.Count; i++)
            {
                var pair = new GiftExchangePair
                {
                    Giver = shuffledPlayers[i],
                    Receiver = shuffledPlayers[(i + 1) % shuffledPlayers.Count]
                };
                pairs.Add(pair);
            }

            return pairs;
        }
    }
}
