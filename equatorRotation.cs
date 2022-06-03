using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class ekvatorÇevir : MonoBehaviour , IPointerDownHandler, IPointerUpHandler
{

    bool rotate = false;
    public bool asagi;
    public GameObject ekvator;
    void Start()
    {
      
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (rotate == false)
            return;


        if (asagi)
        {

            ekvator.transform.Rotate(Vector3.forward * 45 * Time.deltaTime);
        }
        else
        {
            ekvator.transform.Rotate(-Vector3.forward * 45 * Time.deltaTime);

        }
       
    }

   

    public void OnPointerDown(PointerEventData pointerEventData)
    {
        rotate = true;
    }

    public void OnPointerUp(PointerEventData pointerEventData)
    {
        rotate = false;
    }
}
