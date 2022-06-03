using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triger1 : MonoBehaviour
{
    GameObject script;
    
    public void OnTriggerStay(Collider other)
    {
        if(other.tag == "test")
        {
            other.GetComponent<candy>().birMi = true;
            other.GetComponent<candy>()._sayı = 1;
        }
      
   
          

    }

  



}
