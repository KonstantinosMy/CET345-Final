using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwap : MonoBehaviour
{

    public Camera Player;
    public Camera CCTV;
    bool inCamera;
    bool inRange;
    public GameObject pressE;
    public AudioSource click;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && inCamera)
        {
            CCTV.enabled = false;
            inCamera = false;
            inRange = false;
            Player.enabled = true;
            click.Play();

        }

        if (Input.GetKeyDown(KeyCode.E) && inRange)
        {
            Player.enabled = false;
            CCTV.enabled = true;
            inCamera = true;
            click.Play();
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
