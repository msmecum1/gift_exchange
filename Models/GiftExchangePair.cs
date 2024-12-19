namespace Gift_Exchange.Models
{
    public class GiftExchangePair
    {
        public Player Giver { get; set; } = new Player();
        public Player Receiver { get; set; } = new Player();
    }
}
