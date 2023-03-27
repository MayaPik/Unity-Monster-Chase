using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
  [HideInInspector]
  public float speed;

    private Rigidbody2D myBody;

    void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        myBody.velocity = new Vector2(speed, myBody.velocity.y);
        if ( myBody.bodyType == RigidbodyType2D.Kinematic) {
            myBody.position = new Vector2(myBody.position.x, -2.8f);
        } 
    }
}
