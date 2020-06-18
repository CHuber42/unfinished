using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCChurch : MonoBehaviour
{
  public GameObject GhostDialogue;
  public bool visible = false;
  public AudioSource spookySound;
  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    if (visible)
    {
      GhostDialogue.SetActive(true);
    }
    else
    {
      GhostDialogue.SetActive(false);
    }
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
}
