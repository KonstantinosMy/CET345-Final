using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckForSci : MonoBehaviour
{
    public bool InPoint = false;
    public bool InPointCur = false;

    public GameObject brain;
    public GameObject scientist1;
    public Animator scientist;
    public void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Scientist")
        {
            InPointCur = true;
            InPoint = true;
            brain.GetComponent<Brain>().badVariable = false;
            scientist1.GetComponent<Scientist2>().isAllowed1 = false;
        }
    }
    public void OnTriggerExit(Collider other)
    {


            InPointCur = false;
        
    }


}
