using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clonScript : MonoBehaviour
{
    public GameObject apple;
    public float timer=0;
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
        if (timer < 3)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
           
            Clone();
            timer = 0;
        }
       
        
    }
    public void Clone()
    {
       
            Instantiate(apple, new Vector2(spawn, transform.position.y), apple.transform.rotation);
            timer = 0;
        
    }
}
