using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ConsoleLogic : MonoBehaviour
{
    public Light doorLight;
    public Image consoleImage;
    public Animator door1Animation;

    public GameObject adminPanel;
    private bool adminPanelOn;
    private bool inCollider;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        adminPanelOn = adminPanel.GetComponent<Admin_Logic>().adminPanelOn;

        if (inCollider && adminPanelOn)
        {
            doorLight.color = Color.green;
            consoleImage.color = Color.green;
            door1Animation.SetBool("isOpen", true);
        }
       
    }

    public void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.tag == "Scientist")
        {
            Debug.Log("Scientist is in the collider");
            inCollider = true;
        }
    }

    public void OnTriggerExit(Collider other)
    {

        Debug.Log("Scientist left the collider");
        doorLight.color = Color.red;
        consoleImage.color = Color.red;
        door1Animation.SetBool("isOpen", false);
        inCollider = false;
    }
}
