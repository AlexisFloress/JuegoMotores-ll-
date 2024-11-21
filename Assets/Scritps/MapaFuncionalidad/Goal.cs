using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    private int vueltasPlayer = 0;
    private int vueltasIA = 0;
    private void OnTriggerEnter(Collider other)
    {
        string tag = other.gameObject.tag;
        switch (tag)
        {
            case "Player":
                vueltasPlayer++;
                Debug.Log("Se detecto la meta");
                if (vueltasPlayer == 3)
                {
                    SceneManager.LoadScene("EndRaceW");
                }
                break;
            case "IA":
                vueltasIA++;
                Debug.Log("Se detecto la meta IA");
                if (vueltasIA == 3)
                {
                    SceneManager.LoadScene("EndRaceL");
                }
                break;
        }
    }
}
