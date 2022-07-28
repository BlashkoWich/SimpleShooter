using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_MouseController : MonoBehaviour
{
    [SerializeField]
    private Player _player;
    [SerializeField]
    float _camSens = 0.25f; //How sensitive it with mouse
    private float yaw = 0.0f;
    private float pitch = 0.0f;
    public float maxLookAngle = 50f;

    void Update()
    {
        yaw = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * _camSens;

        pitch -= _camSens * Input.GetAxis("Mouse Y");

        pitch = Mathf.Clamp(pitch, -maxLookAngle, maxLookAngle);

        _player.Rotator.localEulerAngles = new Vector3(pitch, yaw, 0);
    }
}
