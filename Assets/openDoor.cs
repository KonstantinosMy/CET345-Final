using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openDoor : MonoBehaviour
{
    bool inTrigger = false;
    public Animator door;
    public AudioSource consoleAudio;
    public AudioSource countDown;
    void Update()
    {
        if (inTrigger && Input.GetKeyDown(KeyCode.E))
        {
            activateDoor();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            inTrigger = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        inTrigger = false;
    }

    private void activateDoor()
    {
        door.SetBool("isOpen", true);
        consoleAudio.Play();
        countDown.Play();
        //turn on door light
        StartCoroutine(waitForSeconds());
    }

    IEnumerator waitForSeconds()
    {
        yield return new WaitForSeconds(10f);
        door.SetBool("isOpen", false);
    }
}
