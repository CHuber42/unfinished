using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EssentialsLoader : MonoBehaviour
{
  public GameObject UIScreen;
  public GameObject player;
  public GameObject audio;
  // Start is called before the first frame update
  void Start()
  {
    if (UIFade.instance == null)
    {
      UIFade.instance = Instantiate(UIScreen).GetComponent<UIFade>();
    }
    if (PlayerController.instance == null)
    {
      PlayerController clone = Instantiate(player).GetComponent<PlayerController>();
      PlayerController.instance = clone;
    }
    if (AudioManager.instance == null)
    {
      AudioManager clone = Instantiate(audio).GetComponent<AudioManager>();
      AudioManager.instance = clone;
    }
  }

  // Update is called once per frame
  void Update()
  {

  }
}
