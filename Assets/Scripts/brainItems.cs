using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brainItems : MonoBehaviour
{
    public itemHandler itemHandler;
    private int itemCount;

    public Light light1;
    public Light light2;
    public Light light3;

    public GameObject core1;
    public GameObject core2;
    public GameObject core3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        itemCount = itemHandler.hasItem;

        if (itemCount == 1)
        {
            light1.color = Color.green;
            core1.SetActive(true);
        }
        else if (itemCount == 2)
        {
            light1.color = Color.green;
            core1.SetActive(true);
            light2.color = Color.green;
            core2.SetActive(true);
        }
        else if (itemCount == 3)
        {
            light1.color = Color.green;
            core1.SetActive(true);
            light2.color = Color.green;
            core2.SetActive(true);
            light3.color = Color.green;
            core3.SetActive(true);
        }
    }
}
