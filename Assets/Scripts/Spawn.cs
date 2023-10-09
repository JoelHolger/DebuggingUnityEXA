using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] Transform[] a;
    [SerializeField] GameObject s;
    
    void Start()
    {
        InvokeRepeating("Dothis", 1f, .5f);
    }

    void Dothis()
    {
        Instantiate(a[Random.Range(0, a.Length)], transform.position, Quaternion.identity);
    }
}
