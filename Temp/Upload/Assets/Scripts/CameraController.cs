using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class CameraController : MonoBehaviour
{
  public Transform target;
  //set to largest tilemap
  public Tilemap gameMap;
  private Vector3 bottomLeftLimit;
  private Vector3 topRightLimit;
  //camera offset from edge NOT WORKING
  private float halfHeight;
  private float halfWidth;

  public int musicToPlay;
  private bool musicStarted;

  // Start is called before the first frame update
  void Start()
  {
    target = FindObjectOfType<PlayerController>().transform;
    halfHeight = Camera.main.orthographicSize;
    halfWidth = halfHeight * Camera.main.aspect;
    bottomLeftLimit = gameMap.localBounds.min - new Vector3(halfWidth, halfHeight, 0);
    topRightLimit = gameMap.localBounds.max - new Vector3(-halfWidth, -halfHeight, 0);
  }

  // LateUpdate is called once per frame after update
  void LateUpdate()
  {
    transform.position = new Vector3(target.position.x, target.position.y, transform.position.z);

    //camera stays within level bounds
    transform.position = new Vector3(Mathf.Clamp(transform.position.x, bottomLeftLimit.x, topRightLimit.x), Mathf.Clamp(transform.position.y, bottomLeftLimit.y, topRightLimit.y), transform.position.z);

    if (!musicStarted)
    {
      musicStarted = true;
      AudioManager.instance.PlayBGM(musicToPlay);
    }
  }
}
