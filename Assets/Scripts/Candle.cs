using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Candle : MonoBehaviour
{
  public SpriteRenderer candle;
  public Sprite candleOut;
  public Sprite candleLit;

  public PlayerController PlayerScript;


  // Start is called before the first frame update
  void Start()
  {

    PlayerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();

    if (PlayerScript.candle == false)
    {
      candle.sprite = candleLit;
    }
  }

  // Update is called once per frame
  void Update()
  {

  }

  void OnTriggerStay2D(Collider2D other)
  {
    if (other.tag == "Player")
    {
      if (Input.GetKeyDown("j") && PlayerScript.candle == false)
      {
        var player = other.GetComponentInParent<PlayerController>();
        player.candle = true;
        PlayerScript.candle = true;
        SceneManager.LoadScene("CutsceneOpening2");
      }
    }
  }

}
