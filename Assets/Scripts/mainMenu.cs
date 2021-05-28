using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class mainMenu : MonoBehaviour
{

    public GameObject pauseCanvas;
    public GameObject controlCanvas;

    public void startGame()
    {
        SceneManager.LoadScene(1);
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
