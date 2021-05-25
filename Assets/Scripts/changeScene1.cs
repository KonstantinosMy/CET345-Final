using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class changeScene1 : MonoBehaviour
{
    bool inCollider = false;
    void Update()
    {
        if (inCollider)
        {
            SceneManager.LoadScene("Puzzle_2");
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
