using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Collider_Interaction : MonoBehaviour
{
  public GameObject PossessionText;
  public GameObject DialogBox;

  public GameObject NPCDialogBox;

  // Start is called before the first frame update
  void Start()
  {
    PossessionText.SetActive(false);
  }

  // Update is called once per frame
  void Update()
  {

  }
  void OnTriggerStay2D(Collider2D player)
  {
    if (player.tag == "Player" && Input.GetKeyDown("j"))
    {
      if (NPCDialogBox.activeSelf == false)
      {
        StartCoroutine(PossessionCoroutine());
      }
    }
  }

  IEnumerator PossessionCoroutine()
  {
    PossessionText.SetActive(true);
    DialogBox.SetActive(true);
    yield return new WaitForSeconds(3);
    PossessionText.SetActive(false);
    DialogBox.SetActive(false);
  }
}
