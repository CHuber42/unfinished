using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TilesEvent3 : MonoBehaviour
{
  public AudioSource soundeffect;
  public bool visible3 = false;
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
      visible3 = true;
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
      visible3 = false;
    }
  }

  void OnGUI()
  {
    if (visible3)
    {
      GUIStyle myBoxStyle = new GUIStyle(GUI.skin.box);
      myBoxStyle.fontSize = 20;
      Font myFont = (Font)Resources.Load("../Fonts/Pixelnauts.ttf", typeof(Font));
      myBoxStyle.font = myFont;
      myBoxStyle.normal.textColor = Color.white;
      GUI.Box(new Rect(Screen.width / 4, 2 * Screen.height / 3, Screen.width / 2, Screen.height / 3), "Sounds like the desk might have opened?", myBoxStyle);
    }
  }
}
