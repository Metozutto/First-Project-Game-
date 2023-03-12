using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movingobstacle : MonoBehaviour
{
    public GameObject KillMenu;
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            KillMenu.SetActive(true);
            Time.timeScale = 0;
            Cursor.lockState = CursorLockMode.None;
        }
        
    }
}
