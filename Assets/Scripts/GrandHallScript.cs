using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrandHallScript : MonoBehaviour
{
    public bool readable = false;
    public PlayerController PlayerScript;
    public SpriteRenderer TableSprite;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
        readable = true;
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
        myBoxStyle.alignment = TextAnchor.MiddleCenter;
        myBoxStyle.normal.textColor = Color.white;
        GUI.Box(new Rect(Screen.width / 4, 2 * Screen.height / 3, Screen.width / 2, Screen.height / 3), "I Just saw this  letter, it reads ... \nTo my Beloved William, It was many fortnights ago since I have seen you last. \nI came here looking for answers, All I have found is cobwebs and dead ends. \nI am going to check the basement for clues...", myBoxStyle);
    }
  }

}
