using System.Collections.Generic;
using UnityEngine;

namespace Dune
{
    public class DeckDrawingSystem : MonoBehaviour
    {
        public HandPresentationSystem HandPresentationSystem;

        private List<RuntimeCard> deck;
        private List<RuntimeCard> discardPile;
        private List<RuntimeCard> hand;

        private DeckWidget deckWidget;
        private DiscardPileWidget discardPileWidget;

        private const int InitialDeckCapacity = 20;
        private const int InitialDiscardPileCapacity = 20;
        private const int InitialHandCapacity = 10;

        public void Initialize(DeckWidget deck, DiscardPileWidget discardPile)
        {
            deckWidget = deck;
            discardPileWidget = discardPile;
        }

        private void Start()
        {
            deck = new List<RuntimeCard>(InitialDeckCapacity);
            discardPile = new List<RuntimeCard>(InitialDiscardPileCapacity);
            hand = new List<RuntimeCard>(InitialHandCapacity);
        }

        public List<RuntimeCard> GetDeck()
        {
            return deck;
        }

        public int LoadDeck(List<CardTemplate> playerDeck)
        {
            var deckSize = 0;
            return deckSize;
        }

        public void ShuffleDeck()
        {
            deck.Shuffle();
        }
    }
}
