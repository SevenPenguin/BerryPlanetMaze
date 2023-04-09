using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levels : MonoBehaviour
{
    //Load Scene
    public void Level()
    {
        SceneManager.LoadScene("Level_1");
    }

    public void Levell()
    {
        SceneManager.LoadScene("Level_2");
    }

    public void Levelll()
    {
        SceneManager.LoadScene("Level_3");
    }

    public void Levellll()
    {
        SceneManager.LoadScene("Level_4");
    }

    //Quit Game
    public void Back()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
