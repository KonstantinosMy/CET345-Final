using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brain : MonoBehaviour
{
    [SerializeField] bool redHit = false;
    [SerializeField] bool greenHit = false;
    [SerializeField] bool blueHit = false;
    [SerializeField] bool yellowHit = false;

    [SerializeField] bool redHit1 = false;
    [SerializeField] bool greenHit1 = false;
    [SerializeField] bool blueHit1 = false;
    [SerializeField] bool yellowHit1 = false;

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

    public bool badVariable = true;

    private void Start()
    {
        badVariable = true;
    }
    void Update()
    {
        redHit = ray1.GetComponent<LaserRayCast>().redHit;
        greenHit = ray1.GetComponent<LaserRayCast>().greenHit;
        yellowHit = ray1.GetComponent<LaserRayCast>().yellowHit;
        blueHit = ray1.GetComponent<LaserRayCast>().blueHit;

        redHit1 = ray2.GetComponent<LaserRayCast>().redHit;
        greenHit1 = ray2.GetComponent<LaserRayCast>().greenHit;
        yellowHit1 = ray2.GetComponent<LaserRayCast>().yellowHit;
        blueHit1 = ray2.GetComponent<LaserRayCast>().blueHit;

        Debug.Log("red" + redHit);
        Debug.Log("green" + greenHit);
        Debug.Log("blue" + blueHit);
        Debug.Log("yellow" + yellowHit);

        Debug.Log("red" + redHit1);
        Debug.Log("green" + greenHit1);
        Debug.Log("blue" + blueHit1);
        Debug.Log("yellow" + yellowHit1);

        CheckForCombo();

        if (purpleC && orangeC && badVariable)
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
        if ((redHit || redHit1) && (blueHit || blueHit1) )
        {
            purpleC = true;
            purple.color = Color.green;
            resetColors();
        }

        if ((redHit || redHit1) && (yellowHit || yellowHit1))
        {
            orangeC = true;
            orange.color = Color.green;
            resetColors();
        }

        if ((greenHit || greenHit1) && (blueHit || blueHit1))
        {
            cyanC = true;
            cyan.color = Color.green;
            resetColors();
        }

        if ((greenHit || greenHit1) && (yellowHit || yellowHit1))
        {
            limeC = true;
            lime.color = Color.green;
            resetColors();
        }
    }

    void resetColors()
    {
        ray1.GetComponent<LaserRayCast>().redHit = false;
        ray1.GetComponent<LaserRayCast>().blueHit = false;
        ray1.GetComponent<LaserRayCast>().yellowHit = false;
        ray1.GetComponent<LaserRayCast>().greenHit = false;

        ray2.GetComponent<LaserRayCast>().redHit = false;
        ray2.GetComponent<LaserRayCast>().blueHit = false;
        ray2.GetComponent<LaserRayCast>().yellowHit = false;
        ray2.GetComponent<LaserRayCast>().greenHit = false;
    }

}

