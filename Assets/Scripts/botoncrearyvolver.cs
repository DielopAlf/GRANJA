
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Botoncrearyvolver:MonoBehaviour
{
    [SerializeField]
    GameObject menu;
    [SerializeField]
    GameObject image;
    void Start()
    {

    }
    void update()
{

    
    //LeanTween.scale(image,  new Vector3(0f, 0f, 0f));
        // LeanTween.scale(image,  Vector3(6.4746f, 3.0623ff, 1f));
    //LeanTween.scale(image,  new Vector3(6.4746f, 3.0623ff, 1f));
}
public void BotonOpciones()
{

    menu.SetActive(false);
    gameObject.SetActive(true);

}
public void BotonVolver()

{
    menu.SetActive(true);
    gameObject.SetActive(false);


}
}