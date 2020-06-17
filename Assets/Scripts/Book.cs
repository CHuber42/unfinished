using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Book : MonoBehaviour
{
    public Texture inventoryBook;
    public GameObject book;
    public PlayerController PlayerScript;
    // Start is called before the first frame update
    void Start()
    {
      
        PlayerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        if (PlayerScript.gamestate > 1)
        {
            book.SetActive(false);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerScript.gamestate > 1)
        {
            book.SetActive(false);
        }
    }

    void OnTriggerStay2D(Collider2D other)
  {
    if (other.tag == "Player")
    {
      if (Input.GetKeyDown("j") && PlayerScript.gamestate < 2)
      {
        PlayerScript.gamestate = 2;
        PlayerScript.Inventory.Add(inventoryBook);
        book.SetActive(false);
      }
    }
  }
}
