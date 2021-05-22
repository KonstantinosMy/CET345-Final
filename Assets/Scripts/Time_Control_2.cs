using UnityEngine;
using Chronos;

public class Time_Control_2 : MonoBehaviour
{
    #region
    public GameObject[] iconList;
    public GameObject[] iconList1;

    private float xDirection;
    private float yDirection;
    public LayerMask IgnoreMe;

    public Outline outline1;
    public Outline outline;

    private RaycastHit hit;

    private bool isHovered = false;
    private bool isHovered1 = false;

    private bool isSelected = false;
    private bool isSelected1 = false;
    #endregion

    void Update()
    {

        //raycasting
        xDirection = Input.GetAxis("Mouse X");
        yDirection = Input.GetAxis("Mouse Y");


        transform.Rotate(-yDirection, xDirection, 0);

        CheckIfRayCastHit();
        AbilityControl();



        if (isSelected == true)
        {
            isSelected1 = false;
            Clock clock = Timekeeper.instance.Clock("Laser2");
            Debug.Log("LASER 2 CAN BE TIME BENT");
 
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
        else if (isSelected1 == true)
        {
            isSelected = false;
            Clock clock = Timekeeper.instance.Clock("Laser1");
            Debug.Log("LASER 1 CAN BE TIME BENT");

            // Change its time scale on key press
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                clearIcons1();
                iconList1[0].SetActive(true);
                clock.localTimeScale = -1; // Rewind
            }
            else if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                clearIcons1();
                iconList1[1].SetActive(true);
                clock.localTimeScale = 0; // Pause
            }
            else if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                clearIcons1();
                iconList1[2].SetActive(true);
                clock.localTimeScale = 0.5f; // Slow
            }
            else if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                clearIcons1();
                iconList1[3].SetActive(true);
                clock.localTimeScale = 1; // Normal
            }
            else if (Input.GetKeyDown(KeyCode.Alpha5))
            {
                clearIcons1();
                iconList1[4].SetActive(true);
                clock.localTimeScale = 2; // Accelerate
            }
        }
        else if (isSelected == false || isSelected1 == false)
        {
            Debug.Log("LASERS CAN NO LONGER BE TIME BENT");
            Clock clock = null;
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

    private void clearIcons1()
    {
        for (int y = 0; y < iconList.Length; y++)
        {
            iconList1[y].SetActive(false);
            if (y == 5)
            {
                y = 0;
            }
        }
    }
    private void AbilityControl()
    {
        if (isHovered == true)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0) && isSelected == false)
            {
                outline.OutlineWidth = 5f;
                isSelected = true;
                Debug.Log("LASER 2 IS SELECTED");

            }
            else if (Input.GetKeyDown(KeyCode.Mouse0) && isSelected == true)
            {
                outline.OutlineWidth = 0f;
                isSelected = false;
                Debug.Log("LASER 2 IS DESELECTED");
            }
        }
        if (isHovered1 == true)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0) && isSelected == false)
            {
                outline1.OutlineWidth = 5f;
                isSelected1 = true;
                Debug.Log("LASER 1 IS SELECTED");

            }
            else if (Input.GetKeyDown(KeyCode.Mouse0) && isSelected == true)
            {
                outline1.OutlineWidth = 0f;
                isSelected1 = false;
                Debug.Log("LASER 1 IS DESELECTED");
            }
        }
    }
   
    void CheckIfRayCastHit()
    {
        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            if (isSelected == false)
            {
                if (hit.collider.gameObject.tag == "Laser2")
                {
                   outline.OutlineWidth = 5f;
                    isHovered = true;
                    Debug.Log("IS HOVERED");
                }
                else if (hit.collider.gameObject.tag != "Laser2")
                {
                    outline.OutlineWidth = 0f;
                    isHovered = false;
                    Debug.Log("LASER 2 IS NO LONGER HOVERED");
                }
            }
            if (isSelected1 == false)
            {
                if (hit.collider.gameObject.tag == "Laser1")
                {
                    outline1.OutlineWidth = 5f;
                    isHovered1 = true;
                    Debug.Log("LASER 1 IS HOVERED");
                }
                else if (hit.collider.gameObject.tag != "Laser1")
                {
                    outline1.OutlineWidth = 0f;
                    isHovered1 = false;
                    Debug.Log("LASER 1 IS NO LONGER HOVERED");
                }
            }
        }
    }
}

/*
public class Time_Control_2 : MonoBehaviour
{
    #region

    private float xDirection;
    private float yDirection;
    private RaycastHit hit;
    private bool isSelectedL1;
    private bool isSelectedL2;

    public Outline laser1Outline;
    public Outline laser2Outline;
    #endregion

    void Update()
    {

        //raycasting
        xDirection = Input.GetAxis("Mouse X");
        yDirection = Input.GetAxis("Mouse Y");

        CheckIfRayCastHit();
        transform.Rotate(-yDirection, xDirection, 0);

       if (isSelectedL1)
        {
            Clock clock = Timekeeper.instance.Clock("Laser1");
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
        else if (isSelectedL2)
        {
            Clock clock = Timekeeper.instance.Clock("Laser2");
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
       else
        {
            Clock clock = null;
        }

    }

    void CheckIfRayCastHit()
    {
        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            if (hit.collider.gameObject.tag == "Laser1")
            {
                laser1Outline.OutlineWidth = 5f;
                Debug.Log("LASER 1 HOVERED");

                if (Input.GetKeyDown(KeyCode.Mouse0) && !isSelectedL1)
                {
                    laser1Outline.OutlineWidth = 5f;
                    isSelectedL1 = true;
                }
                else
                {
                    isSelectedL1 = false;
                }
                
            }
            else if (hit.collider.gameObject.tag == "Laser2")
            {
                Debug.Log("LASER 2 HOVERED");
                laser2Outline.OutlineWidth = 5f;
                if (Input.GetKeyDown(KeyCode.Mouse0) && !isSelectedL2)
                {
                    laser2Outline.OutlineWidth = 5f;
                    isSelectedL2 = true;
                }
                else
                {
                    isSelectedL2 = false;
                }
                
            }
            else
            {
                if (!isSelectedL1)
                {

                    Debug.Log("Hit nothing");
                    laser1Outline.OutlineWidth = 0f;
                }
                else if (!isSelectedL2)
                {

                    Debug.Log("Hit nothing");
                    laser2Outline.OutlineWidth = 0f;
                }
                else
                {
                    Debug.Log("Hit nothing");
                    laser1Outline.OutlineWidth = 0f;
                    laser2Outline.OutlineWidth = 0f;
                }
               
            }

        }
        
    }

}
*/
