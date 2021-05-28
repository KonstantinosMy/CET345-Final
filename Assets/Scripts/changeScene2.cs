using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class changeScene2 : MonoBehaviour
{
    bool inCollider = false;
    void Update()
    {
        if (inCollider)
        {
            SceneManager.LoadScene("Puzzle_3");
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
