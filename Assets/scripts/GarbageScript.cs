using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarbageScript : MonoBehaviour
{
    public logicscript logic;
    public GameObject Garbage;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("object").GetComponent<logicscript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -7)
            GameObject.Destroy(Garbage);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameObject.Destroy(Garbage);
            logic.minosscore(1);
        }
    }
}
