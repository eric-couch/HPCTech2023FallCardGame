using HPCTech2023FallCardGame;

namespace HPCTech2023FallCardGameTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestCardHandForAce_True()
        {
            // Arrange
            Deck Hand = new Deck();
            Hand.Cards = new List<Card>()
            {
                new Card("♦", "8", 8),
                new Card("♣", "6", 6),
                new Card("♦", "10", 10),
                new Card("♦", "A", 14),
                new Card("♠", "8", 8)
            };

            // Act
            bool aceInHand = Hand.CheckForAce();

            // Assert 
            Assert.IsTrue(aceInHand);

        }

        [Test]
        public void TestCardHandForAce_False()
        {
            // Arrange
            Deck Hand = new Deck();
            Hand.Cards = new List<Card>()
            {
                new Card("♦", "8", 8),
                new Card("♣", "6", 6),
                new Card("♦", "10", 10),
                new Card("♦", "K", 13),
                new Card("♠", "8", 8)
            };

            // Act
            bool aceInHand = Hand.CheckForAce();

            // Assert 
            Assert.IsFalse(aceInHand);

        }
    }
}