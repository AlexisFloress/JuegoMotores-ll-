using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetChooseNave : MonoBehaviour
{
    private int nave = NaveSelector.NAVE;
    private CinemachineVirtualCamera camera;
    [SerializeField] private GameObject nave1;
    [SerializeField] private GameObject nave2;
    [SerializeField] private GameObject nave3;
    void Start()
    {
        camera =  GetComponent<CinemachineVirtualCamera>();
        ChooseNave();
    }

    private void ChooseNave()
    {
        switch (nave)
        {
            case 1:
                nave1.gameObject.SetActive(true);
                camera.Follow = nave1.transform;
                camera.LookAt = nave1.transform;
                break;
            case 2:
                nave2.gameObject.SetActive(true);
                camera.Follow = nave2.transform;
                camera.LookAt = nave2.transform;
                break;
            case 3:
                nave3.gameObject.SetActive(true);
                camera.Follow = nave3.transform;
                camera.LookAt = nave3.transform;
                break;
        }
    }
    
}
