using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour {

    public Player Player1, Player2;

    public Deck P1Deck, P2Deck;

    public Hand P1Hand, P2Hand;



    public enum Types
    {
        phys,
        gun,
        fire,
        ice,
        electric,
        wind,
        psy,
        nuclear,
        bless,
        curse,
        almighty,
        ailment,
        heal,
        support,
        passive
    }
    public enum Arcana
    {
        fool,
        magician,
        priestess,
        empress,
        emperor,
        hierophant,
        lovers,
        chariot,
        strength,
        hermit,
        fortune,
        justice,
        hanged_man,
        death,
        temperance,
        devil,
        tower,
        star,
        moon,
        sun,
        judgement
    }
    public enum AreaOfAffect
    {
        personal,
        one_ally,
        all_allies,
        enemy,
        all_enemies,
        All
    }

    void Initialize()
    {
        List<Card> cardsP1 = new List<Card>();
        List<Card> cardsP2 = new List<Card>();

        P1Deck = new Deck(cardsP1,"Fools", Arcana.fool);
        P1Deck = new Deck(cardsP1,"Chariots", Arcana.chariot);

        Player1 = new Player("Joker", P1Deck, P1Hand);
        Player1 = new Player("Ann", P2Deck, P2Hand);
    }



	// Use this for initialization
	void Start () {
        Initialize();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
