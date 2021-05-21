using UnityEngine;
using Chronos;

public class TimeControl : MonoBehaviour
{
    #region
    public GameObject[] iconList;
    private float xDirection;
    private float yDirection;
    public LayerMask IgnoreMe;
    public Outline outline;
    private RaycastHit hit;
    private GameObject lastObjectHit;
    private bool isHovered = false;
    private bool isSelected = false;
    #endregion

    void Update()
    {   
     
        //raycasting
        xDirection = Input.GetAxis("Mouse X");
        yDirection = Input.GetAxis("Mouse Y");


        transform.Rotate(-yDirection, xDirection, 0);

        CheckIfRayCastHit();
        AbilityControl();

        // Get the Enemies global clock
        Clock clock = Timekeeper.instance.Clock("Scientist");

        if (isSelected == true)
        {
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
    private void AbilityControl()
    {
        if (isHovered==true)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0) && isSelected == false)
            {
                lastObjectHit = hit.collider.gameObject;
                isSelected = true;
                lastObjectHit.GetComponent<Outline>().OutlineWidth = 5f;
               
            }
            else if (Input.GetKeyDown(KeyCode.Mouse0) && isSelected == true){
                lastObjectHit.GetComponent<Outline>().OutlineWidth = 0f;
                isSelected = false;
            }
        }
    }
    void CheckIfRayCastHit()
    {
        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            Debug.DrawRay(transform.position, transform.forward, Color.green);
            if (isSelected == false)
            {
                if (hit.collider.gameObject.tag == "Scientist")
                {
                    hit.collider.gameObject.GetComponent<Outline>().OutlineWidth = 5f;
                    isHovered = true;
                    lastObjectHit = hit.collider.gameObject;
                }
                else if (hit.collider.gameObject.tag != "Scientist")
                {
                    lastObjectHit.GetComponent<Outline>().OutlineWidth = 0f;
                    isHovered = false;
                }
            }
        }     
    }
}