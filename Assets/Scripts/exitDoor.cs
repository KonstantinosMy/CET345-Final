using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exitDoor : MonoBehaviour
{
    public Animator doorAnim;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            doorAnim.SetBool("isOpen", true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            doorAnim.SetBool("isOpen", false);
        }
        
    }
}
