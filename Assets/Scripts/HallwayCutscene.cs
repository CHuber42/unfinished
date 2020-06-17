using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HallwayCutscene : MonoBehaviour
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
    if (other.tag == "Player" && PlayerScript.hallwayCutscenePlayed == false)
    {
      var player = other.GetComponentInParent<PlayerController>();
      player.hallwayCutscenePlayed = true;
      SceneManager.LoadScene("CutsceneHallway");
    }
  }
}
