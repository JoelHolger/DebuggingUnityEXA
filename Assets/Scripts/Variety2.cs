using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variety2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.position = transform.position + new Vector3(Random.Range(-.2f,.2f), Random.Range(-.2f,.2f), Random.Range(0,0));
    }
}
