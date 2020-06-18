using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameReset : MonoBehaviour
{
  public PlayerController PlayerScript;
  public GameObject Player;
  public GameObject AudioManager;
  public GameObject UIManager;

  void OnEnable()
  {
    PlayerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    PlayerScript.areaTransitionName = null;
    PlayerScript.gamestate = 0;
    PlayerScript.atticTile1 = false;
    PlayerScript.atticTile2 = false;
    PlayerScript.atticTile3 = false;
    PlayerScript.candle = false;
    PlayerScript.hallwayCutscenePlayed = false;
    PlayerScript.downstairs5CutscenePlayed = false;
    Destroy(PlayerScript);
    Destroy(AudioManager);
    Destroy(Player);
    Destroy(UIManager);
  }
}