using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckForSci : MonoBehaviour
{
    public bool InPoint = false;
    public bool InPointCur = false;
    public void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Scientist")
        {
            InPointCur = true;
            InPoint = true;
        }
    }
    public void OnTriggerExit(Collider other)
    {


            InPointCur = false;
        
    }


}
