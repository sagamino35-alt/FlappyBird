using TMPro;
using UnityEngine;

public class ScoreScript : MonoBehaviour
{
    [SerializeField] GameObject scoreArea;
    [SerializeField] int points;
    [SerializeField] TextMeshProUGUI PointsText;
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D scoreArea)
    {
        points++;
        PointsText.text = "Points: " + points.ToString();
    }
}
