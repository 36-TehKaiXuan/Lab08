using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnerscript : MonoBehaviour
{
    public GameObject SpawnObject1;
    public GameObject SpawnObject2; 
    public GameObject SpawnObject3;
    float PositionY;
    int RNG;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObjects", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        RNG = Random.Range(0, 3);
    }

    void SpawnObjects()
    {
        PositionY = Random.Range(4, -4f);
        this.transform.position = new Vector3(transform.position.x, PositionY, transform.position.z);
        if (RNG == 0)
        {
            Instantiate(SpawnObject1, transform.position, transform.rotation);
        }
        if (RNG == 1)
        {
            Instantiate(SpawnObject2, transform.position, transform.rotation);
        }
        if (RNG == 2)
        {
            Instantiate(SpawnObject3, transform.position, transform.rotation);
        }
    }
}
