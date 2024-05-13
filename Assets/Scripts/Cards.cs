using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Cards
{
    public int id;
    public string cardName;
    public int cost;
    public int power;
    public int life;
    public string cardDescription;
    public Sprite spriteImage;

    public Cards(){

    }
    public Cards(int Id, string CardName, int Cost, int Power, int Life, string CardDescription, Sprite SpriteImage){
        id = Id;
        cardName = CardName;
        cost = Cost;
        power = Power;
        life = Life;
        cardDescription =CardDescription;
        spriteImage = SpriteImage;
    }
}
