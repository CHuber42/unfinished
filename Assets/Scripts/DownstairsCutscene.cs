using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DownstairsCutscene : MonoBehaviour
{
  public PlayerController PlayerScript;
  // Start is called before the first frame update
  void Start()
  {
    PlayerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
  }

  // Update is called once per frame
  void Update()
  {

  }

  void OnTriggerStay2D(Collider2D other)
  {
    if (other.tag == "Player" && PlayerScript.downstairs5CutscenePlayed == false && PlayerScript.gamestate >= 4)
    {
      var player = other.GetComponentInParent<PlayerController>();
      player.downstairs5CutscenePlayed = true;
      SceneManager.LoadScene("CutsceneDownstairs5");
    }
  }
}
