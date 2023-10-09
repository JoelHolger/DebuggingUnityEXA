using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wobble : MonoBehaviour
{
    void FixedUpdate()
    {
        // should probably make it so the things cant look bad
        transform.localScale += new Vector3(Random.Range(-.02f, .02f), Random.Range(-.02f, .02f), Random.Range(0, 0));
    }
}
