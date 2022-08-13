using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddle : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D RB;
    float playerInput;
    public int speed;
    
    
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();



    }

    // Update is called once per frame
    void FixedUpdate()
    {
        playerInput = Input.GetAxis("Horizontal");
        RB.velocity = new Vector2(playerInput * speed, 0);


    }
}
