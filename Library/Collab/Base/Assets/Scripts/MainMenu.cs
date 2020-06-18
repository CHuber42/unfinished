using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{   
    public bool controlsVisible;
    public string controls;
    public string newGameScene;
    // Start is called before the first frame update
    void Start()
    {
        controls = "Navigate using the up/down/left/right keys.\n'J' interacts with the environment.\nWarning: This game likes to drop inputs, so it may take many attempts before you successfully interact with an object.\n'J' to close this window!";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("j"))
        {
            controlsVisible = false;
        }
    }

    public void GameStart()
    {
        SceneManager.LoadScene(newGameScene);
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void Controls()
    {
        controlsVisible = true;
    }

    public void OnGUI()
    {
        if (controlsVisible)
        {
            GUI.Box(new Rect(0, 0, Screen.width, Screen.height), controls);
        }
    }
}
