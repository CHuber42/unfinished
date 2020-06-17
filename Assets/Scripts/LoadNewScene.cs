using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNewScene : MonoBehaviour
{
  public PlayerController PlayerScript;
  public string sceneToLoad;
  void OnEnable()
  {
    PlayerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    //Spawn in same location;
    PlayerScript.areaTransitionName = null;
    SceneManager.LoadScene(sceneToLoad);
  }
}