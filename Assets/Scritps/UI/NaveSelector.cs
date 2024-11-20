using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NaveSelector : MonoBehaviour
{
    private static int Nave = 0;
    private int currentnave;
    [SerializeField] private Button botonIzquierdo;
    [SerializeField] private Button botonDerecho;
    [SerializeField] private Button botonJugar;

    public static int NAVE {get => Nave;}

    private void Awake()
    {
        SelectNave(0);
       
    }

    private void SelectNave(int _index)
    {
        botonIzquierdo.interactable = (_index != 0);
        botonDerecho.interactable = (_index != transform.childCount-1);

        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).gameObject.SetActive(i == _index);
        }

    }

    public void ChangeNave(int _change)
    {
        currentnave += _change;
        SelectNave(currentnave);

    }

    public void JugarNave1()
    {
        Nave = 1;
    }
    public void JugarNave2()
    {
        Nave = 2;
    }
    public void JugarNave3()
    {
        Nave = 3;
    }
}
