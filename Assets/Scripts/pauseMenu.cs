using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class pauseMenu : MonoBehaviour
{

    public GameObject player;
    public GameObject pauseCanvas;
    public GameObject controlCanvas;
    public GameObject UI;
    bool isPaused = false;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            pauseGame();
        }
        
    }

    public void pauseGame()
    {
        if (isPaused)
        {
            isPaused = false;
            pauseCanvas.SetActive(false);
            UI.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
        else
        {
            isPaused = true;
            pauseCanvas.SetActive(true);
            UI.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

        }
    }



    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void quitGame()
    {
        Application.Quit();
    }

    public void openControls()
    {
        pauseCanvas.SetActive(false);
        controlCanvas.SetActive(true);
    }

    public void closeControls()
    {
        pauseCanvas.SetActive(true);
        controlCanvas.SetActive(false);
    }

}
