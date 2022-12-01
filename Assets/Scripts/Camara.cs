using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Camara : MonoBehaviour



{
    public Vector3 origen;
    public Vector3 final;


    void Update()
    {

        if (Input.GetMouseButton(0))

        {
           final  = Camera.main.ScreenToWorldPoint(Input.mousePosition) - Camera.main.transform.position;


              origen = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            Camera.main.transform.position = origen - final;



        }

       








    }


}
