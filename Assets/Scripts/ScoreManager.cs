using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;

    private int score;

    public void AddScore(int scoreYouGet)
    {
        score += scoreYouGet;

        scoreText.SetText($"Score: {score}");
    }

    public static ScoreManager Instance {
        get {
            if (instance == null)
            {
                instance = FindObjectOfType<ScoreManager>();
                
                if (instance == null)
                {
                    var go = new GameObject();
                    instance = go.AddComponent<ScoreManager>();
                }
            }
            return instance;
        }
    }
    private static ScoreManager instance;
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

}
