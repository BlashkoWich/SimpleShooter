using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private Player _player;
    [SerializeField]
    private CharacterController _characterController;
    [SerializeField]
    private float _speed;

    private void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 direction = _player.Rotator.right * x + _player.Rotator.forward * z;
        _characterController.SimpleMove(direction * _speed);
    }
}
