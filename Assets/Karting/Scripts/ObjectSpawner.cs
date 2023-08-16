using System.Collections;
using System.Collections.Generic;
using UnityEngine;



    
public class ObjectSpawner : MonoBehaviour
{
    public GameObject objectToSpawn;
    public Transform SpawnPosition;
    public float timingInterval;
    float timer;
   
    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer>=timingInterval)
        {
            Instantiate(objectToSpawn);
            timer = 0;
        }
        
    }
}
