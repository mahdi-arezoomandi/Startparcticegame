using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clonScript : MonoBehaviour
{
    public GameObject apple;
    public int timer=0;
    private float spawn;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(apple, new Vector2(spawn, transform.position.y), apple.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        spawn = Random.Range(-9, 9);
        increseTime();
       
        
    }
    public void increseTime()
    {
        if (timer > 72)
        {
            Instantiate(apple, new Vector2(spawn, transform.position.y), apple.transform.rotation);
            timer = 0;
        }
        timer++;
    }
}
