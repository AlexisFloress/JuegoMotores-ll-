using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorStorm : MonoBehaviour
{
    [SerializeField] GameObject MegaRocas;
    public Transform[] spawnPositions;
    public float tiempoSpawn = 1f;
    public bool isInMeteorZone;
    private float timer = 0f;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if(isInMeteorZone == true && timer > tiempoSpawn)
        {
            TremendaLluvia();
            timer = 0f;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!other.gameObject.CompareTag("Asteroide"))
        {
            isInMeteorZone = true;
        }
        
        //Debug.Log(chequeo);
    }

    void TremendaLluvia()
    {
        int random = Random.Range(0, spawnPositions.Length);
        if (spawnPositions.Length == 0) return; 
        Vector3 spawnPosition = spawnPositions[random].position; 
        GameObject instance = Instantiate(MegaRocas, spawnPosition, Quaternion.identity);
        Destroy(instance.gameObject,5f);
        //indicioIndex = (indicioIndex + 1) % spawnPositions.Length;

    }
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red; 
        foreach (Transform spawnPosition in spawnPositions) 
        { 
            Gizmos.DrawSphere(spawnPosition.position, 1f); 
        }
    }
    
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isInMeteorZone = false;
            Debug.Log(isInMeteorZone);
        }
    }
    

}
