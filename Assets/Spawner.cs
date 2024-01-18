using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    ObjectPooler pooler;
    // Start is called before the first frame update
    void Start()
    {
        pooler = ObjectPooler.instance;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       pooler.SpawnFromPool("cube", transform.position, Quaternion.identity);
    }
}
