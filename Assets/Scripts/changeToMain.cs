using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class changeToMain : MonoBehaviour
{
    bool inCollider = false;
    void Update()
    {
        if (inCollider)
        {
            SceneManager.LoadScene("Level_1");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {

            inCollider = true;
        }
    }
}
