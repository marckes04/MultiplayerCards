using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cardBack : MonoBehaviour
{

    public GameObject CardBack;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(DisplayCard.staticCardBack == true)
        {
            CardBack.SetActive(true);
        }

        else
        {
            CardBack.SetActive(false);
        }
    }
}
