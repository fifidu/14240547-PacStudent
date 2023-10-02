using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    public AudioSource intro;
    public AudioSource normalLoop;

    // Start is called before the first frame update
    void Start()
    {
        intro.Play();
        normalLoop.PlayDelayed(intro.clip.length);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
