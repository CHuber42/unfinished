using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintingScript : MonoBehaviour
{
  public PlayerController PlayerScript;
  public SpriteRenderer WallSprite;
  public Sprite replacementSprite;
  public AudioSource soundEffect;
  // Start is called before the first frame update
  void Start()
  {
    PlayerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    if (PlayerScript.paintingFlipped == true)
    {
      PlayerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
      if (PlayerScript.gameState > 0)
      {
        WallSprite.sprite = replacementSprite;
      }

      WallSprite.sprite = replacementSprite;
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
      if (other.tag == "Player")
      {
        if (Input.GetKeyDown("j"))
        {
          var player = other.GetComponentInParent<PlayerController>();
          player.gameState += 1;
          WallSprite.sprite = replacementSprite;
        }
      }
    }
  }
}
