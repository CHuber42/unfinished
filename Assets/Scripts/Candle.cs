using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Candle : MonoBehaviour
{
  public SpriteRenderer candleSprite;
  public Sprite candleOut;
  public Sprite candleLit;

  public PlayerController PlayerScript;


  // Start is called before the first frame update
  void Start()
  {
    candleSprite.sprite = candleLit;
    PlayerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
  }

  // Update is called once per frame
  void Update()
  {

  }

  void OnTriggerStay2D(Collider2D other)
  {
    if (other.tag == "Player")
    {
      if (Input.GetKeyDown("j") && PlayerScript.candle != true)
      {
        PlayerScript.candle = true;
        candleSprite.sprite = candleOut;
      }
    }
  }

}
