using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variety : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + new Vector3(Random.Range(-.5f,.5f), Random.Range(-.5f,.5f), Random.Range(0,0));
    }
}
