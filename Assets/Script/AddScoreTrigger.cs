using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddScoreTrigger : MonoBehaviour
{
    public int PointValue = 100;
    public int ScoreT;
    NewScoreManager NewScoreManagerScript;
    void Start()
    {
       NewScoreManagerScript = GameObject.Find("ScoreText").GetComponent<NewScoreManager>();
    }

    void OnTriggerEnter()
    {
        NewScoreManagerScript.score += PointValue;
    }
}
