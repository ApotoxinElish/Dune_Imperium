using System.Collections.Generic;
using UnityEngine;

namespace Dune
{
    public class DeckDrawingSystem : MonoBehaviour
    {
        private List<RuntimeCard> deck;

        private DeckWidget deckWidget;
        private DiscardPileWidget discardPileWidget;

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
