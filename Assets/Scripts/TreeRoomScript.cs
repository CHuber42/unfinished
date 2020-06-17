using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeRoomScript : MonoBehaviour
{
  public PlayerController PlayerScript;
  public SpriteRenderer PaperSprite;
  public Sprite replacementSprite;


  public bool readable = false;
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
        readable = true;
        PaperSprite.sprite = replacementSprite;
      }
    }
  }
  void OnTriggerExit2D(Collider2D other)
  {
    if (other.tag == "Player")
    {
      readable = false;
    }
  }

  void OnGUI()
  {
    if (readable)
    {
      GUIStyle myBoxStyle = new GUIStyle(GUI.skin.box);
      myBoxStyle.fontSize = 20;
      Font myFont = (Font)Resources.Load("../Fonts/Pixelnauts.ttf", typeof(Font));
      myBoxStyle.font = myFont;
      myBoxStyle.normal.textColor = Color.white;
      GUI.Box(new Rect(Screen.width / 4, 2 * Screen.height / 3, Screen.width / 2, Screen.height / 3), "A Knights word is as true as his steel.. \nIt is rumored the knights have stood in the corners of this room... \nProtecting the trees from any danger.\nThey were here from the begininning, and are the only ones to remain...\nListen to them, their word is bound to shed some light....", myBoxStyle);
    }
  }
}
