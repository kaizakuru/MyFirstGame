using UnityEngine;
using UnityEngine.UI;

public class TextScou : MonoBehaviour
{
    public Text scoreText;
    //public int gameObject;

    private int score;
    // Use this for initialization

    void Start()
    {
        score = 0;
        UpdateScore();
    }
    void OnMouseDown()
    {
       // score += gameObject;
        UpdateScore();
    }
    // Update is called once per frame
    void UpdateScore()
    {
        scoreText.text = "Score:\n" + score;

    }

}

