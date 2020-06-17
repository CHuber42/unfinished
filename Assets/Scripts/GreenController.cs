using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenController : MonoBehaviour
{
  public Rigidbody2D GreenRB;
  public Animator greenAnim;
  public static GreenController instance;

  // Start is called before the first frame update
  void Start()
  {
    DontDestroyOnLoad(gameObject);

    if (instance == null)
    {
      instance = this;
    }
    else
    {
      if (instance != this)
      {
        Destroy(gameObject);
      }
    }

  }

  // Update is called once per frame
  void Update()
  {
    // GreenRB.velocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
  }
};
