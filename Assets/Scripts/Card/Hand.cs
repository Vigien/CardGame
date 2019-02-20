using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand {

    public List<Card> cardsInHand;


    public Hand()
    {
        cardsInHand = new List<Card>();
    }

    public Hand(List<Card> StartingHand)
    {
        cardsInHand = StartingHand;
    }

    public bool UseCard(Card UsedCard)
    {
        return cardsInHand.Remove(UsedCard);
    }

    public bool AddCard(Card cardTaken)
    {
        if(cardsInHand.Count < 10)
        {
            cardsInHand.Add(cardTaken);
            return true;
        }
        else
        {
            return false;
        }
            
    }
}
