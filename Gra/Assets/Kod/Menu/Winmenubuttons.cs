using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Winmenubuttons : MonoBehaviour
{
    public void NextLevel()
    {
        SceneManager.LoadScene("Next Level");
    }
    public void Back()
    {
        SceneManager.LoadScene("Menu");
    }
}
