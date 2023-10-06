using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacStudentMovement : MonoBehaviour
{
    // Pivot points for PacStudent's movement (only for Assessment 3)
    public Vector2[] corners;
    public int nextCornerIndex;
    public Animator animatorPacStudent;
    public AudioSource noPellet;

    // Start is called before the first frame update
    void Start()
    {
        animatorPacStudent = GetComponent<Animator>();
        noPellet = GetComponent<AudioSource>();
        noPellet.loop = true;
        transform.position = new Vector3(-17.01f, 15.51f, 0f);
        nextCornerIndex = 1;
    }

    // Update is called once per frame
    void Update()
    {
        // If PacStudent has reached the corner
        if ((Vector2)transform.position == corners[nextCornerIndex])
        {
            nextCornerIndex++;
            if (nextCornerIndex == 4)
            {
                nextCornerIndex = 0;
            }
        }
        if (nextCornerIndex == 0)
        {
            animatorPacStudent.Play("PacStudentUp");
        }
        else if (nextCornerIndex == 1)
        {
            animatorPacStudent.Play("PacStudentRight");
        }
        else if (nextCornerIndex == 2)
        {
            animatorPacStudent.Play("PacStudentDown");
        }
        else if (nextCornerIndex == 3)
        {
            animatorPacStudent.Play("PacStudentLeft");
        }
        transform.position = Vector3.MoveTowards(transform.position, corners[nextCornerIndex], Time.deltaTime);
    }
}