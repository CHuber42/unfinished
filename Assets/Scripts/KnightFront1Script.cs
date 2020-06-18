using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightFront1Script : MonoBehaviour
{
    public GameObject byknighttextNE;
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
        if(other.tag == "Player" && PlayerController.instance.gamestate < 9) 
        {
            byknighttextNE.SetActive(true);
            PlayerController.instance.gamestate = 8;
        }
    }
 
     void OnTriggerExit2D(Collider2D other)
    {
        if(other.tag == "Player") 
        {
            byknighttextNE.SetActive(false);
        }
    }
}
