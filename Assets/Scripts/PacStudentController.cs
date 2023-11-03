using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacStudentController : MonoBehaviour
{
    private Tweener tweener;
    KeyCode lastInput;
    // KeyCode currentInput;
    public GameObject pacStu;
    public ParticleSystem dust;
    public Animator animator;
    private Vector3 startPos, endPos;
    private Vector3 direction;
    private float duration = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        tweener = GetComponent<Tweener>();
        animator = pacStu.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // record lastInput
        if (Input.GetKeyDown("w"))
        {
            lastInput = KeyCode.W;
        }
        if (Input.GetKeyDown("a"))
        {
            lastInput = KeyCode.A;
        }
        if (Input.GetKeyDown("s"))
        {
            lastInput = KeyCode.S;
        }
        if (Input.GetKeyDown("d"))
        {
            lastInput = KeyCode.D;
        }

        if (!tweener.isLerping)
        {
            if (lastInput == KeyCode.W)
            {
                // currentInput = KeyCode.W;
                startPos = pacStu.transform.position;
                endPos = new Vector3(startPos.x, startPos.y + 1.0f, startPos.z);
                tweener.AddTween(pacStu.transform, startPos, endPos, duration);
                animator.Play("PacStudentUp");
                dust.Play();
            }
            if (lastInput == KeyCode.A)
            {
                // currentInput = KeyCode.A;
                startPos = pacStu.transform.position;
                endPos = new Vector3(startPos.x - 1.0f, startPos.y, startPos.z);
                tweener.AddTween(pacStu.transform, startPos, endPos, duration);
                animator.Play("PacStudentLeft");
                dust.Play();
            }
            if (lastInput == KeyCode.S)
            {
                // currentInput = KeyCode.S;
                startPos = pacStu.transform.position;
                endPos = new Vector3(startPos.x, startPos.y - 1.0f, startPos.z);
                tweener.AddTween(pacStu.transform, startPos, endPos, duration);
                animator.Play("PacStudentDown");
                dust.Play();
            }
            if (lastInput == KeyCode.D)
            {
                // currentInput = KeyCode.D;
                startPos = pacStu.transform.position;
                endPos = new Vector3(startPos.x + 1.0f, startPos.y, startPos.z);
                tweener.AddTween(pacStu.transform, startPos, endPos, duration);
                animator.Play("PacStudentRight");
                dust.Play();
            }
        }
    }
}
