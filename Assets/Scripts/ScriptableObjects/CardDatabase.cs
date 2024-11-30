using System;
using UnityEngine;
using Scripts.Cards;

namespace Scripts.ScriptableObjects
{
    [CreateAssetMenu(menuName = "Card Collection")]
    public class CardDatabase : ScriptableObject
    {
        [SerializeField] private Suit clubs, diamonds, hearts, spades;

        /// <summary>
        /// Get card's sprite corresponding to given card symbol and value
        /// </summary>
        /// <param name="symbol"> Card's symbol </param>
        /// <param name="value"> Card's value </param>
        public Sprite GetSprite(Symbol symbol, int value)
        {
            switch (symbol)
            {
                case Symbol.Clubs:
                    return GetValueFromSuit(clubs, value);
                case Symbol.Diamonds:
                    return GetValueFromSuit(diamonds, value);
                case Symbol.Hearts:
                    return GetValueFromSuit(hearts, value);
                default:
                    return GetValueFromSuit(spades, value);
            }
        }

        /// <summary>
        /// Returns card's sprite for a given value from a given suit
        /// </summary>
        /// <param name="suit"> Card's symbol </param>
        /// <param name="value"> Card's value </param>
        private Sprite GetValueFromSuit(Suit suit, int value)
        {
            return suit.cards[value];
        }

        #region Suit class
        [Serializable]
        public class Suit
        {
            public Sprite[] cards = new Sprite[13];
        }
        #endregion
    }
}