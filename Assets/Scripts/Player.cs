using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player{

    public string name;
    public Deck playerDeck;
    public Hand playerHand;
    public int HP, SP, HPLeft, SPLeft;


    public Player()
    {
        name = "test";
        playerDeck = new Deck();
        playerHand = new Hand();
        HP = SP = HPLeft = SPLeft = 0;
    }

    public Player(string name, Deck deck, Hand hand)
    {
        this.name = name;
        playerDeck = deck;
        playerHand = hand;
        HP = HPLeft = 100;
        SP = SPLeft = 5;
    }

    public string GetName() => name;
    public Hand GetHand() => playerHand;
    public Deck GetDeck() => playerDeck;
    public int GetHP() => HP;
    public int GetHPLeft() => HPLeft;
    public int GetSP() => SP;
    public int GetSPLeft() => SPLeft;

    public void StartTurn()
    {
        SP = SPLeft = Mathf.Min(100, SP + 5);
        RobarCarta();
    }

    public void TakeDamage(int damage) => HPLeft = Mathf.Max(0, HPLeft - damage);
    public void HealDamage(int healing) => HPLeft = Mathf.Min(HP, HPLeft + healing);
    public bool UsarCarta(Card usedCard)
    {
        if(usedCard.GetSP() <= SPLeft)
        {
            SPLeft = SPLeft - usedCard.GetSP();
            playerHand.UseCard(usedCard);
            return true;
        } return false;
    }
    public bool RobarCarta()
    {
        if (playerDeck.GetCardsInDeck() > 0)
        {
            Card c = playerDeck.TakeCard();
            return playerHand.AddCard(c);
        } return false;
    }
}
