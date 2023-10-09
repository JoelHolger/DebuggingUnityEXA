using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] Transform[] PassiveOrganism;
    [SerializeField] GameObject Enemy;
    
    void Start()
    {
        InvokeRepeating("SpawnPassiveOrganism", 1f, 5f);
        InvokeRepeating("SpawnEnemys", 1f, 2f);
    }

    void SpawnPassiveOrganisms()
    {
        Instantiate(PassiveOrganism[Random.Range(0, PassiveOrganism.Length)], transform.position, Quaternion.identity);
    }

    void SpawnEnemys()
    {
        Instantiate(Enemy, transform.position, Quaternion.identity);
    }
}
