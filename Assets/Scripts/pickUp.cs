using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUp : MonoBehaviour
{
    public GameObject brain;
    bool inRange;
    public GameObject pressE;
    public GameObject item;
  
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && inRange)
        {
            itemHandler.hasItem++;
            Destroy(item);
        }
    }
    public void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            pressE.SetActive(true);
            inRange = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        pressE.SetActive(false);
        inRange = false;
    }

}
