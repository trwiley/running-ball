/***************************************************************************
 * Name: TitleScreenControls.cs
 * Class: CSCI-C 490
 * Project: Final
 * Purpose: Control buttons on the title screen.
 ***************************************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreenControls : MonoBehaviour
{

    /****************************************************************
    * Name: Play
    * Purpose: Switch to the first level scene.
    **************************************************************/
    public void Play()
    {
        SceneManager.LoadScene("Level1");
    }

    /****************************************************************
    * Name: Rules
    * Purpose: Display the rules.
    **************************************************************/
    public void Rules()
    {
        SceneManager.LoadScene("Rules");
    }

   /****************************************************************
    * Name: Back
    * Purpose: Go back to the title screen from the rules screen.
    **************************************************************/
    public void Back()
    {
        SceneManager.LoadScene("TitleScreen");
    }

}