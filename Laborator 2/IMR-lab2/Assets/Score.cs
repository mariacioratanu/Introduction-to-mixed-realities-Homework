using UnityEngine;
using TMPro; 

public class GolfScore : MonoBehaviour
{
    public TextMeshProUGUI hitsText; 
    public TextMeshProUGUI scoreText; 
    public int numberOfHits=0;
    public int score=0;
    void Start()
    {
        UpdateScoreboard();
    }
    public void IncrementHits()
    {
        numberOfHits++;
        score=numberOfHits*5;
        UpdateScoreboard();
    }
    void UpdateScoreboard()
    {
        hitsText.text="-Number of HITS: "+numberOfHits;
        scoreText.text="-Your SCORE is: "+score;
    }
}
