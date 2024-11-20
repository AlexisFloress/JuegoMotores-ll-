using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadScenes : MonoBehaviour
{

    public void SeleccionNave()
    {
        SceneManager.LoadScene("UI_SeleccionNave");
    }

    public void Configuracion()
    {
        SceneManager.LoadScene("UI_Settins");
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
}
