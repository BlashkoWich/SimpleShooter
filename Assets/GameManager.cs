using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private void Awake()
    {
        PrepareGame();
    }
    private void PrepareGame()
    {
        CursorOff();


        void CursorOff()
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
}
