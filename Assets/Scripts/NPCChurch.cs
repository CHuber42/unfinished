using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCChurch : MonoBehaviour
{
  public bool visible = false;
  public AudioSource spookySound;
  // Start is called before the first frame update
  void Start()
  {

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
        if (visible)
        {
          visible = false;
        }
        else
        {
          visible = true;
          spookySound.Play();
        }
      }
    }
  }

  void OnTriggerExit2D(Collider2D other)
  {
    visible = false;
  }

  void OnGUI()
  {
    if (visible)
    {
      GUIStyle myBoxStyle = new GUIStyle(GUI.skin.box);
      myBoxStyle.fontSize = 20;
      Font myFont = (Font)Resources.Load("../Fonts/Pixelnauts.ttf", typeof(Font));
      myBoxStyle.font = myFont;
      myBoxStyle.normal.textColor = Color.white;
      GUI.Box(new Rect(Screen.width / 4, 2 * Screen.height / 3, Screen.width / 2, Screen.height / 3), "Don't mind me. Just hanging out.", myBoxStyle);
    }
  }
}
