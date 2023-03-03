using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeMovement : MonoBehaviour
{
    public logicScript logic;
    public float moveSpeed = 5.0f;
    public float outOfScreen = -10.0f;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<logicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        float newSpeed = moveSpeed * (1.0f + (float)logic.playerScore / 50.0f);
        Debug.Log($"new speed: {newSpeed}");
        transform.position += (Vector3.left * moveSpeed*(1.0f+(float)logic.playerScore/50.0f)) * Time.deltaTime;
        if (transform.position.x < outOfScreen)
        {
            Debug.Log("Pipe deleted");
            Destroy(gameObject);
        }
    }
}
