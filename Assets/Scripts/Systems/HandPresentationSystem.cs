// using DG.Tweening;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

namespace Dune
{
    public class HandPresentationSystem : MonoBehaviour
    {
        private bool isAnimating;

        public void Initialize(ObjectPool pool, DeckWidget deck, DiscardPileWidget discardPile)
        {

        }

        public bool IsAnimating()
        {
            return isAnimating;
        }
    }
}
