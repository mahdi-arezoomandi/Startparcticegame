using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Applescript : MonoBehaviour
{
    public logicscript logic;
    public GameObject apple;
    private soundManager Audiomanager;
    // Start is called before the first frame update
    void Start()
    {
        Audiomanager = GameObject.FindGameObjectWithTag("sound").GetComponent<soundManager>();
        logic = GameObject.FindGameObjectWithTag("object").GetComponent<logicscript>();
    }

    
    void Update()
    {
        if (transform.position.y < -7)
            GameObject.Destroy(apple);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Audiomanager.Playsfx(Audiomanager.hitAplle);
            GameObject.Destroy(apple);
            logic.addscore(1);
        }

    }
}
