using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Applescript : MonoBehaviour
{
    public logicscript logic;
    public GameObject apple;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("object").GetComponent<logicscript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -7)
            GameObject.Destroy(apple);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject.Destroy(apple);
        logic.addscore(1);

    }
}
