using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour



{
    public Camera camara;

    void Start()
    {
        RaycastHit hit;
        Ray ray = camara.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit))
        {
            Transform objectHit = hit.transform;


        }







    }


}
