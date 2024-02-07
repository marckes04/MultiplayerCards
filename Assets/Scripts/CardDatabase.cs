using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDatabase : MonoBehaviour
{
   public static List<Card> cardList = new List<Card>();

    void Awake()
    {
        cardList.Add(new Card(0, "None", 0,0,"None"));
        cardList.Add(new Card(1, "Human", 2, 1, "This is a human"));
        cardList.Add(new Card(2, "Elf", 3, 3, "This is a elf"));
        cardList.Add(new Card(0, "Dwarf", 4, 4, "This is a dwarf"));
        cardList.Add(new Card(0, "Troll", 5, 5, "This is a troll"));
    }
}
