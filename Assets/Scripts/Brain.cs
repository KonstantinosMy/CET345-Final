using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brain : MonoBehaviour
{
    [SerializeField] bool redHit = false;
    [SerializeField] bool greenHit = false;
    [SerializeField] bool blueHit = false;
    [SerializeField] bool yellowHit = false;

    public bool purpleC;
    public bool cyanC;
    public bool limeC;
    public bool orangeC;

    public Light purple;
    public Light cyan;
    public Light lime;
    public Light orange;

    public GameObject scientist;
    public GameObject ray1;
    public GameObject ray2;

    public AudioSource audioSource;

    void Update()
    {
        redHit = ray1.GetComponent<LaserRayCast>().redHit;
        greenHit = ray1.GetComponent<LaserRayCast>().greenHit;
        yellowHit = ray1.GetComponent<LaserRayCast>().yellowHit;
        blueHit = ray1.GetComponent<LaserRayCast>().blueHit;

        redHit = ray2.GetComponent<LaserRayCast>().redHit;
        greenHit = ray2.GetComponent<LaserRayCast>().greenHit;
        yellowHit = ray2.GetComponent<LaserRayCast>().yellowHit;
        blueHit = ray2.GetComponent<LaserRayCast>().blueHit;

        Debug.Log("red" + redHit);
        Debug.Log("green" + greenHit);
        Debug.Log("blue" + blueHit);
        Debug.Log("yellow" + yellowHit);

        CheckForCombo();

        if (purpleC && orangeC)
        {
            scientist.GetComponent<Scientist2>().isAllowed1 = true;
        }

        if (cyanC && limeC)
        {
            scientist.GetComponent<Scientist2>().isAllowed2 = true;
        }


    }

    void CheckForCombo()
    {
        if (redHit && blueHit )
        {
            purpleC = true;
            purple.color = Color.green;

        }

        if (redHit && yellowHit)
        {
            orangeC = true;
            orange.color = Color.green;

        }

        if (blueHit && greenHit)
        {
            cyanC = true;
            cyan.color = Color.green;

        }

        if (greenHit && yellowHit)
        {
            limeC = true;
            lime.color = Color.green;

        }
    }

}

