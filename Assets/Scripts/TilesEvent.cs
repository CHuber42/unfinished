using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TilesEvent : MonoBehaviour
{
  public GameObject dialogue1;
  public bool visible1 = false;
  public PlayerController PlayerScript;
  public SpriteRenderer atticSprite;

  public SpriteRenderer atticSprite2;
  public Sprite blueSpriteThree;

  public Sprite redSpriteThree;
  // Start is called before the first frame update
  void Start()
  {
    PlayerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    if (PlayerScript.atticTile1 == true)
    {
      atticSprite.sprite = blueSpriteThree;
    }
  }

  // Update is called once per frame
  void Update()
  {

  }

  void OnTriggerEnter2D(Collider2D other)
  {
    if (other.tag == "Player" && PlayerScript.gamestate == 3)
    {
      visible1 = true;
      dialogue1.SetActive(true);
      var player = other.GetComponentInParent<PlayerController>();
      player.atticTile1 = true;
      atticSprite.sprite = blueSpriteThree;
      atticSprite2.sprite = redSpriteThree;
    }
  }

  void OnTriggerExit2D(Collider2D other)
  {
    if (other.tag == "Player")
    {
      visible1 = false;
      dialogue1.SetActive(false);
    }
  }
}
