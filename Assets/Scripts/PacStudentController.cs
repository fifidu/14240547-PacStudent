using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacStudentController : MonoBehaviour
{
    private Tweener tweener;
    KeyCode lastInput;
    public GameObject pacStu;
    private bool isLerping;
    private Vector3 startPos, endPos;
    private float duration = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        tweener = GetComponent<Tweener>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("w"))
        {
            startPos = pacStu.transform.position;
            endPos = new Vector3(startPos.x, startPos.y + 1.0f, startPos.z);
            tweener.AddTween(pacStu.transform, startPos, endPos, duration);
        }
        if (Input.GetKeyDown("a"))
        {
            startPos = pacStu.transform.position;
            endPos = new Vector3(startPos.x - 1.0f, startPos.y, startPos.z);
            tweener.AddTween(pacStu.transform, startPos, endPos, duration);
        }
        if (Input.GetKeyDown("s"))
        {
            startPos = pacStu.transform.position;
            endPos = new Vector3(startPos.x, startPos.y - 1.0f, startPos.z);
            tweener.AddTween(pacStu.transform, startPos, endPos, duration);
        }
        if (Input.GetKeyDown("d"))
        {
            startPos = pacStu.transform.position;
            endPos = new Vector3(startPos.x + 1.0f, startPos.y, startPos.z);
            tweener.AddTween(pacStu.transform, startPos, endPos, duration);
        }
    }
}
