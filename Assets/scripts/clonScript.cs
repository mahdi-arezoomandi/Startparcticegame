using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clonScript : MonoBehaviour
{
    public GameObject apple;
    public float timer=0;
    public float rateclone = 3;
    private float spawn;
    public float realTimer = 0;
    private logicscript logic;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("object").GetComponent<logicscript>();

        Instantiate(apple, new Vector2(spawn, transform.position.y), apple.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        if (logic.Win.active == false)
        {
            if (realTimer < 60)
                realTimer = realTimer + Time.deltaTime;

            if (realTimer > 20)
                rateclone = 2;


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
        
    }
    public void Clone()
    {
       
            Instantiate(apple, new Vector2(spawn, transform.position.y), apple.transform.rotation);
            timer = 0;
        
    }
}
