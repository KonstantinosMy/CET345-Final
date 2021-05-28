using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lineScript : MonoBehaviour
{

    public Transform origin;
    public Transform destin;
    public LineRenderer line;

    void Start()
    {
        line.SetWidth(.2f, .2f);   // or just set it in the Inspector
    }

    void Update()
    {
        line.SetPosition(0, origin.position);
        line.SetPosition(1, destin.position);
    }
}
