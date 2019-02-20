using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Persona : Card{

    private Spell freeCard;
    private Manager.Arcana arcana;
    private int  HP, HPLeft, ATK;
    private List<Manager.Types> weakness;

    public Persona()
    {
        CardName = "Test";
        freeCard = new Spell();
        arcana = Manager.Arcana.fool;
        SP = HP = HPLeft = ATK = 0;
        weakness = new List<Manager.Types>();
    }

    public Persona(string name, Spell freeCard, Manager.Arcana arcana, int sp, int hp, int atk, List<Manager.Types> weakness)
    {
        this.CardName = name;
        this.freeCard = freeCard;
        this.arcana = arcana;
        this.SP = sp;
        this.HP = hp;
        HPLeft = hp;
        this.ATK = atk;
        this.weakness = weakness;
    }

    public Spell GetFreeCard() => freeCard;
    public Manager.Arcana GetArcana() => arcana;
    public int GetHP() => HP;
    public int GetHPLeft() => HPLeft;
    public int GetAtk() => ATK;
    public List<Manager.Types> GetWeakness() => weakness;


    public void TakeDamage(int damage) => Mathf.Max(0, HPLeft - damage);
    public void Heal(int heal) => Mathf.Min(HP, HPLeft + heal);
    
}
