using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScreenMusic : MonoBehaviour
{
    public AudioSource introLoop;

    // Start is called before the first frame update
    void Start()
    {
        introLoop.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
