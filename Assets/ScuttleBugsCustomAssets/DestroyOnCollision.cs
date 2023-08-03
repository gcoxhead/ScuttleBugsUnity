using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{
    public Collider other;
    public GameObject gameObject;
   
    private void OnCollisionEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
