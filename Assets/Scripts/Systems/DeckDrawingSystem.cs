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

        private const int InitialDeckCapacity = 15;
        private const int InitialDiscardPileCapacity = 15;
        private const int InitialHandCapacity = 5;

        public void Initialize(DeckWidget deck, DiscardPileWidget discardPile)
        {
            deckWidget = deck;
            discardPileWidget = discardPile;
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
