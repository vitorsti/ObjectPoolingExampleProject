using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class ObjectBehavior : MonoBehaviour, IPooledObject
{
    [SerializeField]
    float upForce = 1f;
    [SerializeField]
    float sideforce = .1f;
    // Start is called before the first frame update
    void OnEnable()
    {
        float xForce = Random.Range(-sideforce, sideforce);
        float yForce = Random.Range(upForce / 2f, upForce);
        float zForce = Random.Range(-sideforce, sideforce);

        Vector3 force = new Vector3 (xForce, yForce, zForce);

        GetComponent<Rigidbody>().velocity = force;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnObjectSpawn() 
    {
        float xForce = Random.Range(-sideforce, sideforce);
        float yForce = Random.Range(upForce / 2f, upForce);
        float zForce = Random.Range(-sideforce, sideforce);

        Vector3 force = new Vector3(xForce, yForce, zForce);

        GetComponent<Rigidbody>().velocity = force;
    }
}
