using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameEvent : MonoBehaviour
{
    int count = 0;
    int firstObjectdaire ,secondDaire;

    int kalanHak = 6;
    public TMPro.TMP_Text haktext;
    public TMPro.TMP_Text puanText;
    public TMPro.TMP_Text puanTextfinish;
    public TMPro.TMP_Text puanTextKaybetti;
    public GameObject firstObject, secondObject;

    public GameObject kaybettinCanvas;

    int bitirmePuan = 0;
    public GameObject bitirmeCanvas;
    public  int Sahnepuan = 0;
    public static int puan = 0;
    void Start()
    {
        Sahnepuan = 0;
    }
    public void Update()
    {
        
        

        if(kalanHak == 0)
        {

            kaybettinCanvas.SetActive(true);
           
        }

        haktext.text = "Kalan Hak : " + kalanHak.ToString();
        puanTextfinish.text = "Skor : " + puan.ToString();
        puanTextKaybetti.text = "Skor : " + puan.ToString();
        puanText.text = "Skor : " + Sahnepuan.ToString();


        if(Sahnepuan < 0)
        {
            Sahnepuan = 0;
        }
       
    }

    public void Piece(GameObject click ,int daire)
    {
        if(count == 0)
        {

            firstObject = click;
            firstObjectdaire = daire;
         
            count = 1;
            firstObject.GetComponent<BoxCollider>().enabled = false;
    
            firstObject.transform.GetChild(0).GetComponent<Renderer>().material.color = Color.red;
        }
        else if(count == 1)
        {

            secondObject = click;
            secondDaire = daire;
            
            firstObject.GetComponent<BoxCollider>().enabled = true;


         

            if (firstObject.GetComponent<SpriteRenderer>().sprite.name == secondObject.GetComponent<SpriteRenderer>().sprite.name && secondDaire == firstObjectdaire)
            {
                firstObject.transform.GetChild(0).GetComponent<SpriteRenderer>().enabled = false;
                secondObject.transform.GetChild(0).GetComponent<SpriteRenderer>().enabled = false;
                Sahnepuan += 15;

                firstObject.GetComponent<SpriteRenderer>().enabled = true;
                secondObject.GetComponent<SpriteRenderer>().enabled = true;

                firstObject.GetComponent<BoxCollider>().enabled = false;
                secondObject.GetComponent<BoxCollider>().enabled = false;

                count = 0;
                firstObject = null;
                secondObject = null;
                bitirmePuan++;
                if (bitirmePuan == 4)
                {

                    bitirmeCanvas.SetActive(true);

                    puan += Sahnepuan;

                  
                }
            }
            else
            {
                Sahnepuan -= 5;
                kalanHak--;
                count = 0;
                firstObject.transform.GetChild(0).GetComponent<Renderer>().material.color = Color.white;
            }



        }

    }

    public void puanEkle()
    {

        puan += Sahnepuan;
    }
}
