using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clonegarbage : MonoBehaviour
{
    public GameObject apple;
    public float timer = 0;
    public float realTimer = 0;
    
    public float rateclone = 3;
    private float spawn;
    // Start is called before the first frame update
    void Start()
    {


       
    }

    // Update is called once per frame
    void Update()
    {
        if (realTimer < 60)
            realTimer = realTimer + Time.deltaTime;
       
        if (realTimer > 10)
        {
            spawn = Random.Range(-9, 9);
            if (timer < rateclone)
            {
                timer = timer + Time.deltaTime;
            }
            else
            {

                Clone();
                timer = 0;
            }


        }
        
        if (realTimer > 20)
            rateclone = 1;
        if (realTimer > 40)
            rateclone = 0.7f;
    }
    public void Clone()
    {

        Instantiate(apple, new Vector2(spawn, transform.position.y), apple.transform.rotation);
        timer = 0;

    }
}
