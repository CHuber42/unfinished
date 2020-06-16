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
<<<<<<< HEAD
        PlayerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        if (PlayerScript.gameState > 0)
        {
            WallSprite.sprite = replacementSprite;
        }
        
=======
      WallSprite.sprite = replacementSprite;
>>>>>>> a483a3b51dac97668b6242a8c95f2b0652388ed0
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
<<<<<<< HEAD
        if (other.tag == "Player")
        {
            if (Input.GetKeyDown("j"))
            {
              var player = other.GetComponentInParent<PlayerController>();
              player.gameState += 1;
              WallSprite.sprite = replacementSprite;
            }
        }
=======
      if (Input.GetKeyDown("j") && PlayerScript.paintingFlipped == false)
      {
        var player = other.GetComponentInParent<PlayerController>();
        player.paintingFlipped = true;
        WallSprite.sprite = replacementSprite;
        soundEffect.Play();
      }
>>>>>>> a483a3b51dac97668b6242a8c95f2b0652388ed0
    }
  }
}
