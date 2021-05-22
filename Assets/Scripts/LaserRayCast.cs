using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserRayCast : MonoBehaviour
{

    private LineRenderer lr;
    void Start()
    {
        lr = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        lr.SetPosition(0, transform.position);
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            if (hit.collider)
            {
                lr.SetPosition(1, hit.point);
            }

            if (hit.collider.gameObject.tag == "Red")
            {
                Debug.Log("Red hit");
            }
            else if (hit.collider.gameObject.tag == "Green")
            {
                Debug.Log("Green hit");
            }
            else if (hit.collider.gameObject.tag == "Blue")
            {
                Debug.Log("Blue hit");
            }
            else if (hit.collider.gameObject.tag == "Yellow")
            {
                Debug.Log("Yellow hit");
            }
        }
        else lr.SetPosition(1, transform.forward * 5000);
    }
}