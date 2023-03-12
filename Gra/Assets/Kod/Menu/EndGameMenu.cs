using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameMenu : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TryAgain()
    {
        SceneManager.LoadScene("Maze Runner");
        Time.timeScale = 1;
    }
    public void Exit()
    {
        SceneManager.LoadScene("Menu");
    }
}
