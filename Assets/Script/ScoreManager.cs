using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int Score = 0;

    private void OnGUI()
    {
        GUILayout.Label("Score " + Score);        
    }
}
