using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePlayer : MonoBehaviour
{
    public Rigidbody2D Apple;
    public float speed;
    private float move;
    
    private logicscript logic;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("object").GetComponent<logicscript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (logic.Score < 60)
        {
            move = Input.GetAxis("Horizontal");
            Move(move);
        }
    }
    public void Move(float s)
    {
        Apple.velocity = new Vector2(move * speed, Apple.velocity.y);
    }
}
