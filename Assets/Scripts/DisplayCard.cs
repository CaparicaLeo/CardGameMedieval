using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DisplayCard : MonoBehaviour
{
    private List<Cards> displayCard = new List<Cards>();
    public int displayId;

    public int id;
    public string cardName;
    public int cost;
    public int power;
    public int life;
    public string cardDescription;
    public Sprite spriteImage;

    public Text nameText;
    public Text costText;
    public Text powerText;
    public Text lifeText;
    public Text descriptionText;
    public Image artImage;

    void Start()
    {
        displayCard.Add(CardDataBase.cardList[displayId]);
    }

    void Update()
    {
        id = displayCard[0].id;
        cardName = displayCard[0].cardName;
        cost = displayCard[0].cost;
        power = displayCard[0].power;
        life = displayCard[0].life;
        cardDescription = displayCard[0].cardDescription;
        spriteImage = displayCard[0].spriteImage;

        nameText.text = " " + cardName;
        costText.text = " " + cost;
        powerText.text = " " + power;
        lifeText.text = " "+ life;
        descriptionText.text = " "+ cardDescription;
        artImage.sprite = spriteImage;
    }
}
