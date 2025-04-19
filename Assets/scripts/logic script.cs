using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class logicscript : MonoBehaviour
{
    public int Score=0;
    public float timer = 0;
    public GameObject task;
    public GameObject Win;
    public Text playerScore;
    private soundManager Audiomanager;
    private void Start()
    {
        Audiomanager = GameObject.FindGameObjectWithTag("sound").GetComponent<soundManager>();
    }
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
    public void restart()
    {
        SceneManager.LoadScene("SampleScene");
    }

    private void Update()
    {
        if (timer < 3)
            timer = timer + Time.deltaTime;
        else
            task.SetActive(false);
        if (Score == 60)
        {
            Win.SetActive(true);
            Audiomanager.Playsfx(Audiomanager.win);
            Audiomanager.puse();
        }
    }
}
