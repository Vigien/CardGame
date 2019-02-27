using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace SA
{
    [CreateAssetMenu(menuName = "Cards/Spell")]
    public class SpellCard : CardType
    {
        public override void OnSetType(CardDisplay viz)
        {
            Element t = GameManager.GetResourcesManager().typeElement;
            CardDisplayProperties type = viz.GetProperty(t);
            type.text.text = typeName;

            viz.statsHolder.SetActive(false);
    
        }
    }
}
