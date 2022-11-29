using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Crear : MonoBehaviour
{

    public Button crear;
    public GameObject prefabarbol;
    public GameObject prefabarbol2;
    public GameObject prefabgranero;
    public GameObject calabaza;

    public enum EstadosSelector
    {
        EnEspera,
        SeleccionObjetoMover,
        EsperaTrasCreacion,

        ObjetoSeleccionado,
        Mover,
        Crear,

        //Los estados que se necesiten//
    }
    [SerializeField]
    EstadosSelector estadoActual = EstadosSelector.EnEspera;
    public GameObject objetoseleccionado;


    void Update()
    {
        switch (estadoActual)
        {

          
             
             case EstadosSelector.SeleccionObjetoMover:
                SeleccionObjeto();
                break;
             case EstadosSelector.Mover:
                MoverObjeto();
                break;
            
            
             case EstadosSelector.EsperaTrasCreacion:
                estadoActual = EstadosSelector.Mover;
                break;

        }

    }
    void SeleccionObjeto()
    {

        if (Input.GetMouseButtonUp(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {

                GameObject objectHit = hit.transform.gameObject;
                if (objectHit.CompareTag("Creable"))
                {
                    
                    
                    



                   
                    
                    objetoseleccionado = objectHit;

                    if (estadoActual == EstadosSelector.SeleccionObjetoMover)
                    {

                        estadoActual = EstadosSelector.Mover;

                    }
                    

                    }
                    else if (estadoActual == EstadosSelector.EsperaTrasCreacion)
                    {


                        estadoActual = EstadosSelector.Crear;
                        //Debug.Log("prueba");

                    }
                    
                }   


            }

        }

    
    void MoverObjeto()

    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        objetoseleccionado.SetActive(false);

        if (Physics.Raycast(ray, out hit))
        {
            objetoseleccionado.transform.position = hit.point + ((Vector3.up * objetoseleccionado.transform.localScale.y)/2);
        }


        objetoseleccionado.SetActive(true);
        if (Input.GetMouseButtonUp(0))
        {
            estadoActual = EstadosSelector.EnEspera;
            objetoseleccionado = null;

        }






    }
     void CrearObjeto(GameObject elementoACrear)
    {
        GameObject nuevoObjeto = Instantiate(elementoACrear, Vector3.zero, Quaternion.identity);
        objetoseleccionado = nuevoObjeto;
        

        estadoActual = EstadosSelector.EsperaTrasCreacion;
        
    }




   

    

    
     void Seleccionarcrear()
    {

       
    }   
}


            
    
