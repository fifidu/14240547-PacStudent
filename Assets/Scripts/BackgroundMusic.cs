using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    public AudioSource normalLoop;

    // Start is called before the first frame update
    void Start()
    {
        normalLoop.Play();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
