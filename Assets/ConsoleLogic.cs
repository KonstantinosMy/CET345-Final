using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ConsoleLogic : MonoBehaviour
{
    public Light doorLight;
    public Image consoleImage;
    public Animator door1Animation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

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
            door1Animation.SetBool("isOpen", true);
        }
    }

    public void OnTriggerExit(Collider other)
    {
       // if (other.gameObject.tag == "Scientist")
        //{
            Debug.Log("Scientist left the collider");
            doorLight.color = Color.red;
            consoleImage.color = Color.red;
            door1Animation.SetBool("isOpen", false);
       // }
    }
}
