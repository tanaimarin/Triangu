using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriangleScript : MonoBehaviour
{
    public Rigidbody2D myRigidBody2D;
    public float JumpStrength;
    public logicScript logic;
    private float outOfScreenLeft = -10.0f;
    private float outOfScreenRight = 10.0f;
    private float outOfScreenTop = 5.5f;
    private float outOfScreenBottom = -5.5f;
    public bool gameIsNotOver = true;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<logicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)==true && gameIsNotOver)
        {
            myRigidBody2D.velocity = Vector2.up * JumpStrength;
        }

        if (transform.position.x < outOfScreenLeft | transform.position.x > outOfScreenRight |
            transform.position.y < outOfScreenBottom | transform.position.y > outOfScreenTop)
        {
            logic.gameOver();
            gameIsNotOver = false;
        }
    }
}
