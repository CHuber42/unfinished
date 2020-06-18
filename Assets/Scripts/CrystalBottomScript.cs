using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrystalBottomScript : MonoBehaviour
{
  public AudioSource StairsAppear;
  public GameObject StairsAppearMessage;

  public PlayerController PlayerScript;
  public SpriteRenderer CrystalSprite;
  public SpriteRenderer TreeSprite;
  public SpriteRenderer TreeTopRight;
  public SpriteRenderer TreeTopLeft;
  public SpriteRenderer TreeBottomRight;
  public Sprite ReplaceStump;
  public Sprite replacementCrystal;
  public Sprite ReplaceTopRight;
  public Sprite ReplaceTopLeft;
  public Sprite ReplaceBottomRight;

  public bool Activated = false;
  // Start is called before the first frame update
  void Start()
  {
    PlayerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    if (PlayerScript.gamestate >= 6)
    {
      CrystalSprite.sprite = replacementCrystal;
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
      if (Input.GetKeyDown("j") && PlayerController.instance.gamestate == 12)
      {
        var player = other.GetComponentInParent<PlayerController>();
        player.gamestate += 1;
        Activated = true;
        CrystalSprite.sprite = replacementCrystal;
        TreeSprite.sprite = ReplaceStump;
        TreeBottomRight.sprite = ReplaceBottomRight;
        TreeTopRight.sprite = ReplaceTopRight;
        TreeTopLeft.sprite = ReplaceTopLeft;
        StairsAppear.Play();
        StairsAppearMessage.SetActive(true);

      }
    }
  }

  void OnTriggerExit2D(Collider2D other)
  {
    if (other.tag == "Player")
    {
      StairsAppearMessage.SetActive(false);
    }
  }
}
