using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TilesEvent3 : MonoBehaviour
{
  public GameObject dialogue3;
  public AudioSource soundeffect;
  public PlayerController PlayerScript;
  public SpriteRenderer atticSprite3;
  public Sprite blueSpriteTwo;
  public SpriteRenderer lockedDesk;
  public GameObject treasure;


  // Start is called before the first frame update
  void Start()
  {
    treasure.SetActive(false);
    PlayerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    if (PlayerScript.atticTile3 == true)
    {
      atticSprite3.sprite = blueSpriteTwo;
    }
  }

  // Update is called once per frame
  void Update()
  {

  }

  void OnTriggerEnter2D(Collider2D other)
  {
    PlayerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    if (other.tag == "Player" && PlayerScript.atticTile1 == true && PlayerScript.atticTile2 == true)
    {
      dialogue3.SetActive(true); //<--
      var player = other.GetComponentInParent<PlayerController>();
      player.atticTile3 = true;
      atticSprite3.sprite = blueSpriteTwo;
      treasure.SetActive(true);
      soundeffect.Play();
    }
  }

  void OnTriggerExit2D(Collider2D other)
  {
    if (other.tag == "Player")
    {
      dialogue3.SetActive(false); //<---
    }
  }
}
