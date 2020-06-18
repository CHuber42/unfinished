using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AtticSparkle : MonoBehaviour
{
  public Texture sparkleSprite;
  public AudioSource soundEffect;
  public GameObject sparkle;
  public PlayerController PlayerScript;
  // Start is called before the first frame update
  void Start()
  {
    PlayerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    if (PlayerScript.gamestate > 3)
    {
      sparkle.SetActive(false);
    }
  }

  // Update is called once per frame
  void Update()
  {
    if (PlayerScript.gamestate > 3)
    {
      sparkle.SetActive(false);
    }
    // if (PlayerScript.gamestate == 4)
    // {
    //   SceneManager.LoadScene("CutsceneAttic");
    // }
  }

  void OnTriggerStay2D(Collider2D other)
  {
    if (other.tag == "Player")
    {
      if (Input.GetKeyDown("j") && PlayerScript.gamestate < 4)
      {
        soundEffect.Play();
        PlayerScript.Inventory.Add(sparkleSprite);
        PlayerScript.gamestate = 4;
        PlayerScript.areaTransitionName = null;
        SceneManager.LoadScene("CutsceneAttic");
      }
    }
  }
}
