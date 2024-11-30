using UnityEngine;

namespace Scripts.Cards
{
    [RequireComponent(typeof(SpriteRenderer))]
    public class Card : MonoBehaviour
    {
        private Sprite _cardSprite, _reversedSprite;

        public Symbol Symbol { get; private set; }
        public int Value { get; private set; }
        public bool Reversed { get; private set; }

        /// <summary>
        /// Set card's symbol and value.
        /// </summary>
        /// <param name="symbol"> Card's symbol </param>
        /// <param name="value"> Card's value </param>
        public void InitializeCard(Symbol symbol, int value)
        {
            Symbol = symbol;
            Value = value;
            SetSprites();
        }

        private void SetSprites()
        {
            SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        }
    }
}