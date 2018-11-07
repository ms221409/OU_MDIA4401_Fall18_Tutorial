using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class StartButton : MonoBehaviour 
{
    public Text titleText;


    // Called when start button is pressed
    public void OnStartButtonPressed ()
    {
        SceneManager.LoadSceneAsync (1, LoadSceneMode.Single);
    }


    public void OnToggleToggled (bool wasToggled)
    {
        titleText.color = Random.ColorHSV();
    }
}
