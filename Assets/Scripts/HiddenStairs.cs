using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HiddenStairs : MonoBehaviour
{
    public GameObject StairsHider;
    public PlayerController PlayerScript;
    public string areaToLoad;
    public SpriteRenderer SpriteHolder;
    public Sprite StairsSprite;
    public string areaTransitionName;
    public AreaEntrance theEntrance;
    public float waitToLoad = 1f;
    private bool shouldLoadAfterFade;

    // Start is called before the first frame update
    void Start()
    {
        PlayerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();  
        if (PlayerScript.gamestate > 0)
        {
            theEntrance.transitionName = areaTransitionName;
            SpriteHolder.sprite = StairsSprite;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerScript.gamestate > 12)
        {
            StairsHider.SetActive(false);
        }
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
    if (other.tag == "Player" && PlayerScript.gamestate > 12)
    {
      shouldLoadAfterFade = true;
      UIFade.instance.FadeToBlack();
      PlayerController.instance.areaTransitionName = areaTransitionName;
    }
  }
}
