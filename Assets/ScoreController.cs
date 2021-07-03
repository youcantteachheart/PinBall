using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    //private float visiblePosZ = -6.5f;

    private int largeCloudScore = 20;
    private int smallCloudScore = 10;
    private int largeStarScore = 15;
    private int smallStarScore = 5;

    //private Text scoreText;
    private int score = 0;

    private GameObject scoreBoardText;

    // Start is called before the first frame update
    void Start()
    {
        this.scoreBoardText = GameObject.Find("ScoreBoard") ;
    }

    // Update is called once per frame
    void Update()
    {
        this.scoreBoardText.GetComponent<Text>().text = string.Format("Score:{0}",this.score);
    }

    void OnCollisionEnter(Collision collision)
    {
        string tag = collision.gameObject.tag;
        
        if (tag == "LargeCloudTag")
        {
            this.score += largeCloudScore;
            Debug.Log("score"+largeCloudScore);
        }
        else if (tag == "SmallCloudTag")
        {
            this.score += smallCloudScore;
            Debug.Log("score"+smallCloudScore);
        }
        else if (tag == "LargeStarTag")
        {
            this.score += largeStarScore;
            Debug.Log("score"+largeStarScore);
        }
        else if (tag == "SmallStarTag")
        {
            this.score += smallStarScore;
            Debug.Log("score"+smallStarScore);
        }
    }
}
