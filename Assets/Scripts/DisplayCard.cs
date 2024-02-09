using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DisplayCard : MonoBehaviour
{
    public List<Card> Displaycard = new List<Card>();
    public int displayId;

    public int id;
    public string cardName;
    public int cost;
    public int power;
    public string cardDescription;
    public Sprite spriteImage; 

    public Text nameText;
    public Text costText;
    public Text powerText;
    public Text descriptionText;
    public Image artImage;


    void Start()
    {
        Displaycard[0] = CardDatabase.cardList[displayId];
    }

   
    void Update()
    {
        id = Displaycard[0].id;
        cardName = Displaycard[0].cardName;
        cost = Displaycard[0].cost;
        power = Displaycard[0].power;
        cardDescription = Displaycard[0].cardDescription;
        spriteImage = Displaycard[0].spriteImage;

        nameText.text = " " + cardName;
        costText.text = " " + cost;
        powerText.text = " " + power;
        descriptionText.text = " " + cardDescription;
        artImage.sprite = spriteImage;
    }
}
