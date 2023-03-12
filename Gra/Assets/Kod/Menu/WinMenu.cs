using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.SceneManagement;

public class WinMenu : MonoBehaviour
{
    public GameObject Winscrean;
    
    private void OnTriggerEnter(Collider other)
    {
        Winscrean.SetActive(true);
        Time.timeScale = 0;
        Cursor.lockState = CursorLockMode.None;
    }
    
}
