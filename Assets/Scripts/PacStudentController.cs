using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacStudentController : MonoBehaviour
{
    private Tweener tweener;
    KeyCode lastInput;
    private bool isLerping;

    // Start is called before the first frame update
    void Start()
    {
        tweener = GetComponent<Tweener>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("a"))
        {
            tweener.AddTween(this.transform, this.transform.position, new Vector3(-2.0f, 0.5f, 0.0f), 1.5f);
        }
    }
}
