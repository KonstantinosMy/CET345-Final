using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPress : MonoBehaviour
{
    bool inCollider = false;
    bool isAllowed = false;
    public Animator correspondingPillar;

    public GameObject r;
    public GameObject b;
    public GameObject y;
    public GameObject g;
    public AudioSource push;
    public AudioSource click;
    void Update()
    {
        if (inCollider && Input.GetKeyDown(KeyCode.E))
        {
            push.Play();
            click.Play();
            correspondingPillar.SetBool("isTriggered", true);   
        }
        if (Input.GetKeyUp(KeyCode.E))
        {
            correspondingPillar.SetBool("isTriggered", false);
        }
    }

    public void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            inCollider = true;
            
            if (this.name == "ConsoleBlue")
            {
                b.SetActive(true);
            }
            else if (this.name == "ConsoleRed")
            {
                r.SetActive(true);
            }
            else if (this.name == "ConsoleYellow")
            {
                y.SetActive(true);
            }
            else if (this.name == "ConsoleGreen")
            {
                g.SetActive(true);
            }
        }
    }

    public void OnTriggerExit(Collider other)
    {
        inCollider = false;
        Reset();
    }

    private void Reset()
    {
        g.SetActive(false);
        y.SetActive(false);
        r.SetActive(false);
        b.SetActive(false);
    }
}
