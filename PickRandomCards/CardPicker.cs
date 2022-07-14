
namespace PickRandomCards
{
    internal class CardPicker
    {
        private static Random _ = new();
        public static string[] PickSomeCards(int numberOfCards)
        {
            string[] pickedCards = new string[numberOfCards];
            for(int i = 0; i < numberOfCards; i++)
            {
                pickedCards[i] = RandomValue() + " of " + RandomeSuite();
            }
            return pickedCards;
        }

        private static string RandomeSuite()
        {
            int value = new Random().Next(1, 5);
            if(value == 1) return "Spades";
            if(value == 2) return "Hearts";
            if(value == 3) return "Clubs";
            return "Diamonds";
        }

        private static string RandomValue()
        {
            int value = new Random().Next(1, 14);
            if(value == 1) return "Ace";
            if(value == 11) return "Jack";
            if(value == 12) return "Queen";
            if(value == 13) return "King";
            return value.ToString();
        }
    }
}
