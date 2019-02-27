using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SA
{
    [CreateAssetMenu(fileName = "New Card", menuName = "Card")]
    public class Card : ScriptableObject
    {
        /*
        public int id;
        public new string name;
        public Sprite personaSprite;
        public Sprite personaTypeSprite;
        public Sprite backgroundSprite;
        public Sprite[] weaknesses;
        public int sp;
        public int attack;
        public int hp;
        */
        public CardType cardType;
        public CardProperties[] properties;
    }
}