using System.Collections;
using System.Collections.Generic;
using UnityEngine;



    
public class ObjectSpawner : MonoBehaviour
{
    public GameObject objectToSpawn;
    public Transform SpawnPosition;
    public float timingInterval;
    float timer;


    // Start is called before the first frame update
    void Start()
    {
        
    }

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
