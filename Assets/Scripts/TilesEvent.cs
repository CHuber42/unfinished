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
      GUI.Box(new Rect(0, 0, Screen.width, Screen.height), "There are some loose tiles here...");
    }
  }
}
