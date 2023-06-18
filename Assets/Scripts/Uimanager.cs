using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Uimanager : MonoBehaviour
{
    //slider
     Slider slider;


    private void Start()
    {
        slider = GetComponent<Slider> ();
        slider.value = 1;
    }

    private void Update()
    {
        GameManager gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        
        slider.value = (float)gameManager._playerhp / (float)gameManager._maxhp;
    }
}
