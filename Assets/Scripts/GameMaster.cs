/*******************************************************************
* Name: GameMaster.cs
* Class: CSCI-C 490
* Project: Final
* Purpose: Control the game rules.
*******************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameMaster : MonoBehaviour {

    public float timeRemaining = 40.0f;
    public int level;

    public Text timeText;

	/********************************************************************
    * Name: Start
    * Purpose: Initialize the scene.
    ********************************************************************/
	void Start () {
		
	}
	
	/****************************************************************
    * Name: FixedUpdate
    * Purpose: Update at every frame.
    **************************************************************/
	void Update () {
        timeRemaining -= Time.deltaTime;
        timeText.text = "Time remaining: " + timeRemaining;
        if(timeRemaining <= 0)
        {
            ReloadCurrentLevel();
        }
	}

    /****************************************************************
    * Name: LoadNextLevel
    * Purpose: Load the next level.
    **************************************************************/
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

    /****************************************************************
    * Name: ReloadCurrentLevel
    * Purpose: Reload the current level.
    **************************************************************/
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

    /****************************************************************
    * Name: ShowWinScreen
    * Purpose: Load the win screen.
    **************************************************************/
    public void ShowWinScreen()
    {
        SceneManager.LoadScene("win");
    }
}
