using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshCollider))]

public class Movement : MonoBehaviour
{

    private Vector3 screenPoint;
    private Vector3 offset;
    public bool IsDragable = true;

    void OnMouseDown()
    {
        if (IsDragable)    // Only do if IsDraggable == true
        {
            screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);

            offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
        }
    }

    void OnMouseDrag()
    {
        if (IsDragable)    // Only do if IsDraggable == true
        {
            if (Input.mousePosition.x < 100.0f)
            {
                transform.position = new Vector3(150.0f, transform.position.y, screenPoint.z);
            }
            else if (Input.mousePosition.x > 2300.0f)
            {
                transform.position = new Vector3(2250.0f, transform.position.y, screenPoint.z);
            }
            else if (Input.mousePosition.y > 1100.0f)
            {
                transform.position = new Vector3(transform.position.x, 1000.0f, screenPoint.z);
            }
            else if (Input.mousePosition.y < 50.0f)
            {
                transform.position = new Vector3(transform.position.x, 150.0f, screenPoint.z);
            }
            else
            {
                Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z); // hardcode the y and z for your use

                Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
                transform.position = curPosition;
            }
        }
    }

}