using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEditor.Animations;

public class Scientist2 : MonoBehaviour
{
    public Transform point1;
    public Transform point2;
    private NavMeshAgent agent;
    public Animator anim;
    public bool isAllowed1 = false;
    public bool isAllowed2 = false;
    public Animator door1;
    public Animator door2;

    public GameObject _point1;
    private bool inPoint1;
    private bool inPoint1Cur;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.autoBraking = false;
    }

    void Update()
    {
        inPoint1 = _point1.GetComponent<CheckForSci>().InPoint;
        inPoint1Cur = _point1.GetComponent<CheckForSci>().InPointCur;
        if (isAllowed1)
        {
            door1.SetBool("isOpen", true);
            GoToPoint1();
        }
        else if (!isAllowed1)
        {
            door1.SetBool("isOpen", false);
            Stop();
        }
        if (inPoint1Cur)
        {
            Stop();
        }
        if (isAllowed2)
        {
            door2.SetBool("isOpen", true);
        }
        else if (!isAllowed2)
        {
            door2.SetBool("isOpen", false);
        }
        if (isAllowed2 && inPoint1)
        {
            door2.SetBool("isOpen", true);
            GoToPoint2();
        }
        else if (!isAllowed2 && inPoint1)
        {
            door2.SetBool("isOpen", false);
            GoToPoint1();
        }
        
    }

    void GoToPoint1()
    {
        agent.isStopped = false;
        anim.SetBool("isWalking", true);

        // Set the agent to go to the currently selected destination.
        agent.destination = point1.position;
    }

    void GoToPoint2()
    {
        agent.isStopped = false;
        anim.SetBool("isWalking", true);

        // Set the agent to go to the currently selected destination.
        agent.destination = point2.position;
    }

    void Stop()
    {
        agent.isStopped = true;
        anim.SetBool("isWalking", false);
        // Returns if no points have been set up

    }

}

