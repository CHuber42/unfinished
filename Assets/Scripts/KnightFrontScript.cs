using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightFrontScript : MonoBehaviour
{
    public GameObject byknighttext2;
    public GameObject byknighttext;
    public PlayerController PlayerScript;

    // Start is called before the first frame update
    void Start()
    {
        PlayerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
   
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player" && PlayerController.instance.gamestate < 8 && PlayerController.instance.gamestate > 5) 
        {
            byknighttext.SetActive(true);
            PlayerController.instance.gamestate = 7;
     
        }
        else if (other.tag == "Player" && PlayerController.instance.gamestate > 7)
        {   
            if (PlayerController.instance.gamestate < 9)
            {
                PlayerController.instance.gamestate = 9;
            }
            byknighttext2.SetActive(true);
        }
    }
     void OnTriggerExit2D(Collider2D other)
    {
        if(other.tag == "Player") 
        {
            byknighttext.SetActive(false);
            byknighttext2.SetActive(false);
        }
    }
}
