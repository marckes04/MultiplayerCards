using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeck : MonoBehaviour
{
    public List<Card> deck = new List<Card>();
    public List<Card> container = new List<Card>();
    public int x;
    public int deckSize;
    // Start is called before the first frame update
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
