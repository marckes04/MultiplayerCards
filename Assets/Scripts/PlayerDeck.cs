using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeck : MonoBehaviour
{
    public List<Card> deck = new List<Card>();
    public int x;
    public int deckSize;
    public List<Card> container = new List<Card>();
    // Start is called before the first frame update


    public GameObject cardDeck1;
    public GameObject cardDeck2;
    public GameObject cardDeck3;
    public GameObject cardDeck4; 


    void Start()
    {
        x = 0;

        for(int i = 0; i < 40; i++)
        {
            x = Random.Range(1, 4);
            deck[i] = CardDatabase.cardList[x];
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(deckSize < 30)
        {
            cardDeck1.SetActive(false);
        }

        if (deckSize < 20)
        {
            cardDeck2.SetActive(false);
        }

        if (deckSize < 5)
        {
            cardDeck3.SetActive(false);
        }

        if (deckSize < 1)
        {
            cardDeck3.SetActive(false);
        }
    }


    public void Shuffle()
    {
        for(int i = 0;i < deckSize; i++)
        {
            container[0] = deck[i];
            int randonIndex = Random.Range(i, deckSize);
            deck[i] = deck[randonIndex];
            deck[randonIndex] = container[0];
        }
    }

}
