using UnityEngine;
using Chronos;

public class Time_Control_2 : MonoBehaviour
{
    #region

    private float xDirection;
    private float yDirection;
    private RaycastHit hit;
    private GameObject lastGameObject;
    private int cubeNum;
    #endregion

    void Update()
    {

        //raycasting
        xDirection = Input.GetAxis("Mouse X");
        yDirection = Input.GetAxis("Mouse Y");

        CheckIfRayCastHit();
        transform.Rotate(-yDirection, xDirection, 0);

        if (cubeNum == 1)
        {
            controlCube();
        }
        else if (cubeNum == 2)
        {
            controlCube1();
        }
        else if (cubeNum == 3)
        {
            controlCube2();
        }
       

    }

    void CheckIfRayCastHit()
    {
        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            if (hit.collider.gameObject.tag != "Cube" || hit.collider.gameObject.tag != "Cube1" || hit.collider.gameObject.tag != "Cube2")
            {
                lastGameObject.GetComponent<Outline>().OutlineWidth = 0f;
            }

            else if (hit.collider.gameObject.tag == "Cube")
            {
                Debug.Log("RED CUBE HIT");
                hit.collider.gameObject.GetComponent<Outline>().OutlineWidth = 5f;
                lastGameObject = hit.collider.gameObject;
                cubeNum = 1;
            }
            else if (hit.collider.gameObject.tag != "Cube1")
            {
                Debug.Log("GREEN CUBE HIT");
                lastGameObject = hit.collider.gameObject;
                hit.collider.gameObject.GetComponent<Outline>().OutlineWidth = 5f;
                cubeNum = 2;
            }
            else if (hit.collider.gameObject.tag != "Cube2")
            {
                Debug.Log("YELLOW CUBE HIT");
                lastGameObject = hit.collider.gameObject;
                hit.collider.gameObject.GetComponent<Outline>().OutlineWidth = 5f;
                cubeNum = 3;
            }
        }
        
    }

    void controlCube()
    {
        // Get the Enemies global clock
        Clock clock = Timekeeper.instance.Clock("Cube");


        // Change its time scale on key press
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            clock.localTimeScale = -1; // Rewind
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            clock.localTimeScale = 0; // Pause
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            clock.localTimeScale = 0.5f; // Slow
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            clock.localTimeScale = 1; // Normal
        }
        else if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            clock.localTimeScale = 2; // Accelerate
        }
    }

    void controlCube1()
    {
        // Get the Enemies global clock
        Clock clock = Timekeeper.instance.Clock("Cube1");


        // Change its time scale on key press
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            clock.localTimeScale = -1; // Rewind
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            clock.localTimeScale = 0; // Pause
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            clock.localTimeScale = 0.5f; // Slow
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            clock.localTimeScale = 1; // Normal
        }
        else if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            clock.localTimeScale = 2; // Accelerate
        }
    }

    void controlCube2()
    {
        // Get the Enemies global clock
        Clock clock = Timekeeper.instance.Clock("Cube2");


        // Change its time scale on key press
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            clock.localTimeScale = -1; // Rewind
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            clock.localTimeScale = 0; // Pause
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            clock.localTimeScale = 0.5f; // Slow
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            clock.localTimeScale = 1; // Normal
        }
        else if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            clock.localTimeScale = 2; // Accelerate
        }
    }
}