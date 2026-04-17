using UnityEngine;

public class CollisionScript : MonoBehaviour
{

    [SerializeField] GameObject gameOverPanel;

    void Start()
    {
        gameOverPanel.SetActive(false);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Time.timeScale = 0;
            gameOverPanel.SetActive(true);
        }




    }
}




