using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemHandler : MonoBehaviour
{
    public static int hasItem = 0;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public void Update()
    {
        Debug.Log("Items: " + hasItem);
    }
}
