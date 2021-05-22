using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Admin_Logic : MonoBehaviour
{
    private float timeLeft = 10;
    public Image adminImage;
    public bool adminPanelOn = false;
    public TMP_Text countdownTxt;
    private bool isInTrigger = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (adminPanelOn)
        {
            CountDown();
        }

        if (Input.GetKeyDown(KeyCode.E) && isInTrigger)
        {
            Debug.Log("Player interacted with Admin Panel");
            adminImage.color = Color.green;
            adminPanelOn = true;
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Player in collider");
            isInTrigger = true;
           
            
            
        }
    }
    public void OnTriggerExit(Collider other)
    {
        isInTrigger = false;
    }


    public void CountDown()
    {
        isInTrigger = false;
        timeLeft -= Time.deltaTime;
        countdownTxt.text = "ACTIVE for: "+ timeLeft.ToString("f0") + " seconds";
        if (timeLeft < 0)
        {
            adminPanelOn = false;
            adminImage.color = Color.red;
            countdownTxt.text = "INACTIVE";
            timeLeft = 10;
        }
    }
}
