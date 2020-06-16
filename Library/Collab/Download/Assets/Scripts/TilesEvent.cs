using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TilesEvent : MonoBehaviour
{
  public bool visible = false;

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
      visible = true;
    }
  }

  void OnTriggerExit2D(Collider2D other)
  {
    if (other.tag == "Player")
    {
      visible = false;
    }
  }

  void OnGUI()
  {
    if (visible)
    {
      GUI.Box(new Rect(Screen.width / 4, 2*Screen.height / 3, Screen.width / 2, Screen.height / 3), "There are some loose tiles here...");
    }
  }
}
