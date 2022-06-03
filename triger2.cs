using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triger2 : MonoBehaviour
{
    
    public void OnTriggerStay(Collider other)
    {

        if (other.tag == "test")
        {
            other.GetComponent<candy>().birMi = false;
            other.GetComponent<candy>()._sayı = 2;
        }

    }


}


