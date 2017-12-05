using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameMaster : MonoBehaviour {

    public float timeRemaining = 40.0f;
    public int level;

    public Text timeText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timeRemaining -= Time.deltaTime;
        timeText.text = "Time remaining: " + timeRemaining;
        if(timeRemaining <= 0)
        {
            ReloadCurrentLevel();
        }
	}

    public void LoadNextLevel()
    {
        if(level == 1)
        {
            SceneManager.LoadScene("Level2");
        }
        if(level == 2)
        {
            SceneManager.LoadScene("Level3");
        }
        if (level == 3)
        {
            SceneManager.LoadScene("Level4");
        }
        if(level == 4)
        {
            SceneManager.LoadScene("Level5");
        }
    }

    public void ReloadCurrentLevel()
    {
        if(level == 1)
        {
            SceneManager.LoadScene("Level1");
        }
        if(level == 2)
        {
            SceneManager.LoadScene("Level2");
        }
        if(level == 3)
        {
            SceneManager.LoadScene("Level3");
        }
        if(level == 4)
        {
            SceneManager.LoadScene("Level4");
        }
        if(level == 5)
        {
            SceneManager.LoadScene("Level5");
        }
    }

    public void ShowWinScreen()
    {
        SceneManager.LoadScene("win");
    }
}
