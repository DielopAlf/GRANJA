using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour



{
    public bool zooming;
    public float zoomSpeed;
    public Camera camara;

    void update()
    {
        if (zooming)
        {
            Ray ray = camara.ScreenPointToRay(Input.mousePosition);
            float zoomDistance = zoomSpeed * Input.GetAxis("Vertical") * Time.deltaTime;
            camara.transform.Translate(ray.direction * zoomDistance, Space.World);




        }











    }


}
