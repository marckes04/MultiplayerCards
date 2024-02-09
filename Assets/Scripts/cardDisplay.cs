using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cardDisplay : MonoBehaviour
{
    public Card2 card;

    public Text nameText;
    public Text descriptionText;


    public Text manaText;
    public Text attackText;


    private void Start()
    {
        nameText.text = card.name;
        descriptionText.text = card.description;

        manaText.text = card.manaCost.ToString();
        attackText.text = card.attack.ToString();
    }

}
