
using UnityEngine;

public class NaveAnimation : MonoBehaviour
{
    [SerializeField] private Vector3 posicionFinal;
    private Vector3 posicionInicial;


    private void Awake()
    {
        posicionInicial = transform.position;
    }



    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, posicionFinal, 0.1f);
    }

    private void OnDisable()
    {
        transform.position = posicionInicial;
    }
}
