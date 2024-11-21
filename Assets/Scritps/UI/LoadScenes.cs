using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadScenes : MonoBehaviour
{

    public void SeleccionNave()
    {
        SceneManager.LoadScene("UI_SeleccionNave");
    }

    public void Creditos()
    {
        SceneManager.LoadScene("Creditos");
    }

    public void BackMenuPrincipal()
    {
        SceneManager.LoadScene("UI_MenuInicial");
    }
    public void Nivel1()
    {
        SceneManager.LoadScene("Nivel_1"); 
    }
    public void Nivel2()
    {
        SceneManager.LoadScene("Nivel_2");
    }
    public void ChooseLevel()
    {
        SceneManager.LoadScene("ChooseLevel");
    }
    public void Salir()
    {
        Application.Quit();
    }
}
