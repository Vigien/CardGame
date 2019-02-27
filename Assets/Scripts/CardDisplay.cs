using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace SA
{
    public class CardDisplay : MonoBehaviour
    {
        public Card card;
        public CardDisplayProperties[] properties;
        public GameObject statsHolder;
        /*
        public TextMeshProUGUI nameText;
        public Image personaImg;
        public Image personaTypeImg;
        public Image backgroundImg;
        public Image[] weaknesses;
        public TextMeshProUGUI spText;
        public TextMeshProUGUI atkText;
        public TextMeshProUGUI hpText;
        */
        // Start is called before the first frame update
        void Start()
        {
            /*
            nameText.text = card.name;
            personaImg.sprite = card.personaSprite;
            personaTypeImg.sprite = card.personaTypeSprite;
            backgroundImg.sprite = card.backgroundSprite;
            spText.text = card.sp.ToString();
            atkText.text = card.attack.ToString();
            hpText.text = card.hp.ToString();
            for (int i = 0; i < card.weaknesses.Length; i++)
            {
                weaknesses[i].sprite = card.weaknesses[i];
            }
            */

            LoadCard(card);

        }

        public void LoadCard(Card c)
        {
            if (c == null)
                return;

            card = c;
            c.cardType.OnSetType(this);

            for (int i = 0; i < card.properties.Length; i++)
            {
                CardProperties cp = card.properties[i];

                CardDisplayProperties p = GetProperty(cp.element);
                if (p == null)
                    continue;

                if (cp.element is ElementInt)
                {
                    p.text.text = cp.intValue.ToString();
                }
                else
                if (cp.element is ElementText)
                {
                    p.text.text = cp.stringValue;
                }
                else if (cp.element is ElementImage)
                {
                    p.img.sprite = cp.sprite;
                }
            }
        }

        public CardDisplayProperties GetProperty(Element e)
        {
            CardDisplayProperties result = null;

            for(int i = 0; i < properties.Length; i++)
            {
                if(properties[i].element == e)
                {
                    result = properties[i];
                    break;
                }
            }
            return result;
        }
    }
}
