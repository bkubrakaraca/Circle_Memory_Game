using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class candy : MonoBehaviour 
{

    public bool birMi;
    string isim = "kalp";
    public int _sayı;

    public GameObject gameEvent;

    bool firstTouch;
    public bool basladiMi;
    private void Start()
    {
        gameEvent = GameObject.Find("GameEvent");
        firstTouch = true;
        basladiMi = false;
    }
    void OnMouseDown()
    {
        if (basladiMi)
        {
            if (birMi)
            {


                GameObject click = this.gameObject;

                gameEvent.GetComponent<gameEvent>().Piece(click, _sayı);
                firstTouch = false;


            }
            else
            {
                GameObject click = this.gameObject;


                gameEvent.GetComponent<gameEvent>().Piece(click, _sayı);
            }



        }
        
       
    }


}
