using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class logicscript : MonoBehaviour
{
    public int Score=0;
    public float timer = 0;
    public GameObject task;
    public GameObject Win;
    public Text playerScore;
    // Start is called before the first frame update
    [ContextMenu("increase score")]
    public void addscore(int s)
    {
       
        Score = Score + s;
        playerScore.text = Score.ToString();
    }
    public void minosscore(int s)
    {

        Score = Score - s;
        playerScore.text = Score.ToString();
    }
    
    private void Update()
    {
        if (timer < 3)
            timer = timer + Time.deltaTime;
        else
            task.SetActive(false);
        if (Score == 60)
            Win.SetActive(true);

    }
}
