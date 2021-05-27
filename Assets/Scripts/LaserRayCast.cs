using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserRayCast : MonoBehaviour
{
    RaycastHit hit;
    private LineRenderer lr;

    public bool redHit = false;
    public bool greenHit = false;
    public bool blueHit = false;
    public bool yellowHit = false;


    void Start()
    {
        lr = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        CheckIfRayCastHit();

        Debug.Log("red" + redHit);
        Debug.Log("green" + greenHit);
        Debug.Log("blue" + blueHit);
        Debug.Log("yellow" + yellowHit);
    }

    void CheckIfRayCastHit()
    {
        lr.SetPosition(0, transform.position);

        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            if (hit.collider)
            {
                lr.SetPosition(1, hit.point);
            }

            if (hit.collider.gameObject.tag == "Red")
            {
                
                redHit = true;
            }
 

            if (hit.collider.gameObject.tag == "Green")
            {
               
                greenHit = true;
            }
  

            if (hit.collider.gameObject.tag == "Blue")
            {
                
                blueHit = true;
            }


            if (hit.collider.gameObject.tag == "Yellow")
            {

                yellowHit = true;
            }



        }
        else lr.SetPosition(1, transform.forward * 5000);


    }

   
}