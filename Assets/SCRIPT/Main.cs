using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour
{
    //Load Scene
    public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Levels()
    {
        SceneManager.LoadScene("level");
    }

    //Quit Game
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Player has quit the game.");
    }
}
