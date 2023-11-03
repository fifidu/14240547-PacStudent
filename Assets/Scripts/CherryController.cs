using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CherryController : MonoBehaviour
{
    public GameObject cherry;
    Vector3 position;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnCherry", 10, 10);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnCherry()
    {
        position = new Vector3(Random.Range(-40, 40), Random.Range(-25, 25), 0);
        Instantiate(cherry, position, Quaternion.identity);
    }
}
