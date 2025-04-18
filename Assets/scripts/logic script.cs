using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class logicscript : MonoBehaviour
{
    public int Score=0;
    public Text playerScore;
    // Start is called before the first frame update
    [ContextMenu("increase score")]
    public void addscore(int s)
    {
       
        Score = Score + s;
        playerScore.text = Score.ToString();
    }
}
