using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Card {

    protected string CardName;
    protected int SP;

    public string GetName() => CardName;
    public int GetSP() => SP;
}
