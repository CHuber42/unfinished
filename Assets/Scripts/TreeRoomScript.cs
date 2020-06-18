using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeRoomScript : MonoBehaviour
{
  public PlayerController PlayerScript;
  public SpriteRenderer PaperSprite;
  public Sprite replacementSprite;
  public GameObject floornote;
  // Start is called before the first frame update
  void Start()
  {
    PlayerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    if (PlayerScript.gamestate > 5)
    {
      PaperSprite.sprite = replacementSprite;
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
      if (Input.GetKeyDown("j"))
      {
        var player = other.GetComponentInParent<PlayerController>();
        player.gamestate += 1;
        floornote.SetActive(true);
        PaperSprite.sprite = replacementSprite;
      }
    }
  }
  void OnTriggerExit2D(Collider2D other)
  {
    if (other.tag == "Player")
    {
      floornote.SetActive(false);
    }
  }
}
