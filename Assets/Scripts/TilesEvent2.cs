using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TilesEvent2 : MonoBehaviour
{
  public bool visible2 = false;
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
      visible2 = true;
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
      visible2 = false;
    }
  }

  void OnGUI()
  {
    if (visible2)
    {
      GUIStyle myBoxStyle = new GUIStyle(GUI.skin.box);
      myBoxStyle.fontSize = 20;
      Font myFont = (Font)Resources.Load("../Fonts/Pixelnauts.ttf", typeof(Font));
      myBoxStyle.font = myFont;
      myBoxStyle.normal.textColor = Color.white;
      GUI.Box(new Rect(Screen.width / 4, 2 * Screen.height / 3, Screen.width / 2, Screen.height / 3), "There it goes again...", myBoxStyle);
    }
  }
}
