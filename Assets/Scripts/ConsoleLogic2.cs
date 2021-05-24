using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ConsoleLogic2 : MonoBehaviour
{
    public Light doorLight;
    public Image consoleImage;
    public Animator door3Animation;
    public GameObject scientist;

    // Update is called once per frame
    void Update()
    {


    }

    public void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Scientist")
        {
            Debug.Log("Scientist is in the collider");
            doorLight.color = Color.green;
            consoleImage.color = Color.green;
            door3Animation.SetBool("isOpen", true);
            scientist.GetComponent<Scientist2>().isAllowed1 = false;
        }
    }

    public void OnTriggerExit(Collider other)
    {

        Debug.Log("Scientist left the collider");
        doorLight.color = Color.red;
        consoleImage.color = Color.red;
        door3Animation.SetBool("isOpen", false);
    }
}
