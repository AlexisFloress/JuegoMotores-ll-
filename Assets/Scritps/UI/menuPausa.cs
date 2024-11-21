using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuPausa : MonoBehaviour
{
    //[SerializeField] private GameObject botonpausa;
    [SerializeField] private GameObject menupausa;
    private int change = 0;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(change == 0)
            {
                Pausa();
                change = 1;
                return;
            }
            if (change == 1)
            {
                Reanudar();
                change = 0;
                return;
            }
        }
    }
    public void Pausa()
    {
        Time.timeScale = 0f; 
        //botonpausa.SetActive(false);
        menupausa.SetActive(true);
    }

    public void Reanudar()
    {
        Time.timeScale = 1f;
        //botonpausa.SetActive(true);
        menupausa.SetActive(false);
        change = 0;
    }

    public void salir()
    {
        SceneManager.LoadScene("UI_MenuInicial");
    }
}
