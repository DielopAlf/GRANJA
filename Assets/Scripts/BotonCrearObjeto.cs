using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;






/* En el update comprobamos el estado y si esta en seleccionar objeto para mover rotar o escalar ejecutamos la funcion selecion objetos.
 * En selección objetos comprobamos si hacemos click y si le damos con un raycast a un objeto que tenga el tag de movible. 
 * En caso de que si guardamos ese objeto en la variable objetos seleccionados y cambiamos el estado a mover, escalar o rotar en base que estuvieramos en el estado de selec objeto mover escala o rotar.
 * En el update si estamos en alguno d elos 3 estados ejecutamos la funcion de cada uno.
 *
 *
 * */
public class BotonCrearObjeto : MonoBehaviour
{
    public Button crear;
   // public GameObject prefabarbol1;
    public GameObject prefabarbol2;
    public GameObject prefabgranero;
    public GameObject prefabcalabaza;
    public enum EstadosSelector
  {

        EnEspera,
        SeleccionObjetoMover,
        EsperaTrasCreacion,

        ObjetoSeleccionado,
        Mover,
        Soltar,
        Crear,

        //LOs estados que se necesiten//
   }
[SerializeField]
EstadosSelector estadoActual = EstadosSelector.EnEspera;
public GameObject objetoseleccionado;


void Update()
{
    switch (estadoActual)
    {



        // case EstadosSelector.EnEspera:
        //   estadoActual = EstadosSelector.SeleccionObjetoMover;
        //   estadoActual = EstadosSelector.SeleccionObjetoMover;
        //   break;
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


                //objetoseleccionadocambiarestado (añadir is 



                objetoseleccionado = objectHit;

                if (estadoActual == EstadosSelector.SeleccionObjetoMover)
                {

                    estadoActual = EstadosSelector.Mover;

                }
               
                else if (estadoActual == EstadosSelector.EsperaTrasCreacion)
                {


                    estadoActual = EstadosSelector.Crear;
                    //Debug.Log("prueba");

                }

            }


        }

    }

}
//movemos el objeto al punto donde este el raton.
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



public class OpcionesAnimacion : MonoBehaviour
{
    [SerializeField]
    GameObject menu;
    [SerializeField]
    GameObject image;
    void Start()
    {

    }

    void Update()
    {
>>>>>>> 0bb48d1b8a30552a9cceeb09becefc1b7e4f0fe3
>>>>>>> 9595981d0f6959681e0d8eb3a7be751f3554eab7

    }







}


public void CrearObjeto(GameObject elementoACrear)
{
    GameObject nuevoObjeto = Instantiate(elementoACrear, Vector3.zero, Quaternion.identity);
    objetoseleccionado = nuevoObjeto;
    estadoActual = EstadosSelector.EsperaTrasCreacion;

}


public void seleccionarmover()

{
    estadoActual = EstadosSelector.SeleccionObjetoMover;
}


public void Seleccionarcrear()
{

    //  estadoActual = EstadosSelector.SeleccionObjetoCrear;

}
   

    public void BotonCrear()
    {
        menu.SetActive(false);
        gameObject.SetActive(true);
    }

    public void BotonCancelar()
    {
        menu.SetActive(true);
        gameObject.SetActive(false);

    }

}
