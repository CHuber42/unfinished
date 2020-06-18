using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AreaExit : MonoBehaviour
{
  public GameObject lockedMessage;
  public AudioSource keyFail;
  public AudioSource keySuccess;
  public Texture key;
  public string areaToLoad;
  public string areaTransitionName;
  public AreaEntrance theEntrance;
  public float waitToLoad = 1f;
  private bool shouldLoadAfterFade;
  // Start is called before the first frame update
  void Start()
  {
    theEntrance.transitionName = areaTransitionName;
  }

  // Update is called once per frame
  void Update()
  {
    if (shouldLoadAfterFade)
    {
      waitToLoad -= Time.deltaTime;
      if (waitToLoad <= 0)
      {
        shouldLoadAfterFade = false;
        SceneManager.LoadScene(areaToLoad);
      }
    }
  }

  private void OnTriggerEnter2D(Collider2D other)
  {
    if (other.tag == "Player")
    {
      if (PlayerController.instance.gamestate < 5 && areaTransitionName == "Downstairs5to6")
      {
        if (PlayerController.instance.Inventory.Contains(key))
        {
          PlayerController.instance.gamestate = 5;
          keySuccess.Play();
          shouldLoadAfterFade = true;
          UIFade.instance.FadeToBlack();
          PlayerController.instance.areaTransitionName = areaTransitionName;
        }
        else
        {
          StartCoroutine(DoorLocked());
          keyFail.Play();
        }
      }
      else
      {
        shouldLoadAfterFade = true;
        UIFade.instance.FadeToBlack();
        PlayerController.instance.areaTransitionName = areaTransitionName;
      }
    }
  }

  IEnumerator DoorLocked()
  {
    lockedMessage.SetActive(true);
    yield return new WaitForSeconds(3);
    lockedMessage.SetActive(false);
  }
}
