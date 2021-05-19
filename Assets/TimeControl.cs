using UnityEngine;
using Chronos;

public class TimeControl : MonoBehaviour
{
    public GameObject[] iconList;
    void Update()
    {
        // Get the Enemies global clock
        Clock clock = Timekeeper.instance.Clock("Scientist");


        // Change its time scale on key press
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            clearIcons();
            iconList[0].SetActive(true);
            clock.localTimeScale = -1; // Rewind
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            clearIcons();
            iconList[1].SetActive(true);
            clock.localTimeScale = 0; // Pause
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            clearIcons();
            iconList[2].SetActive(true);
            clock.localTimeScale = 0.5f; // Slow
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            clearIcons();
            iconList[3].SetActive(true);
            clock.localTimeScale = 1; // Normal
        }
        else if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            clearIcons();
            iconList[4].SetActive(true);
            clock.localTimeScale = 2; // Accelerate
        }

        
    }
    
    private void clearIcons()
    {
        for (int y = 0; y < iconList.Length; y++)
        {
            iconList[y].SetActive(false);
            if (y == 5)
            {
                y = 0;
            }
        }
    }
    
}