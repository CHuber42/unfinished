using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TilesEvent2 : MonoBehaviour
{
  public GameObject dialogue2;
  public PlayerController PlayerScript;
  public SpriteRenderer atticSprite2;
  public SpriteRenderer atticSprite3;
  public Sprite blueSpriteThree;

  public Sprite redSpriteTwo;


  // Start is called before the first frame update
  void Start()
  {
    PlayerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    if (PlayerScript.atticTile2 == true)
    {
      atticSprite2.sprite = blueSpriteThree;
    }
  }

  // Update is called once per frame
  void Update()
  {

  }

  void OnTriggerEnter2D(Collider2D other)
  {
    PlayerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    if (other.tag == "Player" && PlayerScript.atticTile1 == true)
    {
      dialogue2.SetActive(true);
      var player = other.GetComponentInParent<PlayerController>();
      player.atticTile2 = true;
      atticSprite2.sprite = blueSpriteThree;
      atticSprite3.sprite = redSpriteTwo;
    }
  }

  void OnTriggerExit2D(Collider2D other)
  {
    if (other.tag == "Player")
    {
      dialogue2.SetActive(false);
    }
  }
}
