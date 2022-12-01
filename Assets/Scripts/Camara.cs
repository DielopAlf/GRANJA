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
            //Calcular el movimiento del raton
            Vector3 mov = final - Input.mousePosition;
            gameObject.transform.position += mov;

        }




        final = Input.mousePosition;





    }


}
