using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreenControls : MonoBehaviour
{

    public void Play()
    {
        SceneManager.LoadScene("Level1");
    }

    public void Rules()
    {
        SceneManager.LoadScene("Rules");
    }

    public void Back()
    {
        SceneManager.LoadScene("TitleScreen");
    }

}