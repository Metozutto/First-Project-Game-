using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pausemenu : MonoBehaviour
{
    public GameObject pausemenu;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pausemenu.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Time.timeScale = 0;
        }
    }
    public void Resume()
    {
        pausemenu.SetActive(false);
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.Locked;
    }
    public void backtomenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void restart()
    {
        SceneManager.LoadScene("Maze Runner");
        Time.timeScale = 1;
    }
}
