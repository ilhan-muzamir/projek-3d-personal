using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LerpExample : MonoBehaviour
{
    private bool flag = false;
    private Vector3 destinationCoordinate;
    public float speed = 5.0f;
    private float yAxis;
    public GameObject targetObject;

    private void Start()
    {
        // Set initial destination (replace this with your own logic)

        yAxis = targetObject.transform.position.y; // Assign the y-coordinate of targetObject's position to yAxis
    }

    private void Update()
    {
        // Check for input to set a new destination coordinate
        if ((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began) ||
            (Input.GetMouseButtonDown(0)))
        {
            RaycastHit hit;
            Ray ray;
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                flag = true;
                destinationCoordinate = hit.point;
                destinationCoordinate.y = yAxis;
                Debug.Log(destinationCoordinate);
            }
        }

        // Smoothly move towards the destination coordinate using Vector3.Lerp
        if (flag && !Mathf.Approximately(targetObject.transform.position.magnitude,
            destinationCoordinate.magnitude))
        {
            targetObject.transform.position =
                Vector3.Lerp(targetObject.transform.position, destinationCoordinate,
                    1 / (speed * (Vector3.Distance(gameObject.transform.position, destinationCoordinate))));
        }
        else if (flag && Mathf.Approximately(targetObject.transform.position.magnitude,
            destinationCoordinate.magnitude))
        {
            flag = false;
            Debug.Log("I am here. Click on some other point");
        }
    }
}