using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Deck {

    private List<Card> cards;
    private string deckname;
    private Manager.Arcana arcana_dominant;

    public Deck()
    {
        cards = new List<Card>();
        deckname = "test";
        arcana_dominant = Manager.Arcana.fool;
    }

    public Deck(List<Card> cards, string name, Manager.Arcana arcana)
    {
        this.cards = cards.OrderBy(a => Guid.NewGuid()).ToList();
        deckname = name;
        arcana_dominant = arcana;
    }

    public Card TakeCard()
    {
        var cardtaken = cards[0];
        cards.Remove(cardtaken);
        return cardtaken;
    }

    public int GetCardsInDeck() => cards.Count;
    public string GetName() => deckname;
    public Manager.Arcana GetArcanaDominant() => arcana_dominant;


}
