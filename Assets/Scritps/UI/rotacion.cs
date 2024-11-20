using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class rotacion : MonoBehaviour
{
    public float vrotacion = 5f;


    void Update()
    {
        Rotacion();
    }

    void Rotacion()
    {
        transform.Rotate(0, vrotacion * Time.deltaTime, 0);
    }


}
