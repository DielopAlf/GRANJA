using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimarBotones : MonoBehaviour
{

    public void ScaleUp()
    {
        LeanTween.scale(gameObject, Vector3.one*1.0f, 0.5f);
    }
    public void ScaleDown()
    {
        LeanTween.scale(gameObject, Vector3.one * 0.8f, 0.2f);
    }
}

