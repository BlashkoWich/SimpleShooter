using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_MouseController : MonoBehaviour
{
    [SerializeField]
    private Transform _rotate;
    [SerializeField]
    float _camSens = 0.25f; //How sensitive it with mouse
    private Vector3 lastMouse = new Vector3(255, 255, 255); //kind of in the middle of the screen, rather than at the top (play)

    void Update()
    {
        lastMouse = new Vector3(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"), 0);
        lastMouse = new Vector3(-lastMouse.y * _camSens, lastMouse.x * _camSens, 0);
        lastMouse = new Vector3(transform.eulerAngles.x + lastMouse.x, transform.eulerAngles.y + lastMouse.y, 0);
        transform.eulerAngles = lastMouse;
        lastMouse = Input.mousePosition;
    }
}
