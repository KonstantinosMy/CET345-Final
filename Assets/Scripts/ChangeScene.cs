using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ChangeScene : MonoBehaviour
{
    bool inCollider = false;
    void Update()
    {
        if (inCollider)
        {
            SceneManager.LoadScene("Puzzle_1");
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
