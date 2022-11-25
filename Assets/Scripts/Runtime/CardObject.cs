// using DG.Tweening;
using System;
using System.Text;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;

namespace Dune
{
    /// <summary>
    /// This component is linked to the actual GameObjects corresponding to the cards that
    /// are in the player's hand.
    /// </summary>
    public class CardObject : MonoBehaviour
    {
#pragma warning disable 649
        [SerializeField]
        private TextMeshPro costText;
        [SerializeField]
        private TextMeshPro nameText;
        [SerializeField]
        private TextMeshPro typeText;
        [SerializeField]
        private TextMeshPro descriptionText;

        [SerializeField]
        private SpriteRenderer picture;
        [SerializeField]
        private SpriteRenderer glow;

        [SerializeField]
        private Color inHandColor;
        [SerializeField]
        private Color aboutToBePlayedColor;
#pragma warning restore 649

        public RuntimeCard RuntimeCard;
        public CardTemplate Template;

        private SortingGroup sortingGroup;

        private Vector3 cachedPos;
        private Quaternion cachedRot;
        private int cachedSortingOrder;
        private int highlightedSortingOrder;

        private bool interactable;

        private HandPresentationSystem handPresentationSystem;
        private CardWithArrowSelectionSystem cardWithArrowSelectionSystem;
        private CardWithoutArrowSelectionSystem cardWithoutArrowSelectionSystem;

        private bool beingHighlighted;
        private bool beingUnhighlighted;

        public enum CardState
        {
            InHand,
            AboutToBePlayed
        }

        public CardState State => currState;
        private CardState currState;

        private void Awake()
        {
            sortingGroup = GetComponent<SortingGroup>();
            SetGlowEnabled(false);
        }

        private void Start()
        {
            handPresentationSystem = FindObjectOfType<HandPresentationSystem>();
            cardWithArrowSelectionSystem = FindObjectOfType<CardWithArrowSelectionSystem>();
            cardWithoutArrowSelectionSystem = FindObjectOfType<CardWithoutArrowSelectionSystem>();
        }

        private void OnEnable()
        {
            SetState(CardState.InHand);
        }

        public void SetInfo(RuntimeCard card)
        {
            RuntimeCard = card;
            Template = card.Template;
            // costText.text = Template.Cost.ToString();
            // nameText.text = Template.Name;
            // typeText.text = "Spell";
            // var builder = new StringBuilder();
            // foreach (var effect in Template.Effects)
            // {
            //     builder.AppendFormat("{0}. ", effect.GetName());
            // }
            // descriptionText.text = builder.ToString();
            // picture.material = Template.Material;
            picture.sprite = Template.Picture;
        }

        public void SetGlowEnabled(bool glowEnabled)
        {
            glow.enabled = glowEnabled;
        }

        public void SetGlowEnabled(int playerMana)
        {
            glow.enabled = playerMana >= Template.Cost;
        }

        public bool IsGlowEnabled()
        {
            return glow.enabled;
        }

        public void OnManaChanged(int mana)
        {
            SetGlowEnabled(Template.Cost <= mana);
        }

        public void SetState(CardState state)
        {
            currState = state;
            switch (currState)
            {
                case CardState.InHand:
                    glow.color = inHandColor;
                    break;

                case CardState.AboutToBePlayed:
                    glow.color = aboutToBePlayedColor;
                    break;
            }
        }
    }
}
