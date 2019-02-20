using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spell : Card {

    private Manager.Types AttackType;
    private Manager.AreaOfAffect AreaOfAffect;
    private int  HPCost, Potency;

    public Spell()
    {
        CardName = "Spell test";
        AttackType = Manager.Types.ailment;
        AreaOfAffect = Manager.AreaOfAffect.personal;
        SP = HPCost = Potency = 0;
    }

    public Spell(string cardName, Manager.Types attackType, Manager.AreaOfAffect areaOfAffect, int sPCost, int hPCost, int potency)
    {
        CardName = cardName;
        AttackType = attackType;
        AreaOfAffect = areaOfAffect;
        SP = sPCost;
        HPCost = hPCost;
        Potency = potency;
    }

    public Manager.Types GetAttackType() => AttackType;
    public Manager.AreaOfAffect GetAreaOfAffect() => AreaOfAffect;
    public int GetHPCost() => HPCost;
    public int GetPotency() => Potency;

}
