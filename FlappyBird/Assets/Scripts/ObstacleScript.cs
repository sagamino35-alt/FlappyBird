using UnityEngine;

public class ObstacleScript : MonoBehaviour
{
    Rigidbody2D oRb;
    public float MoveSpeed = 10;



    [SerializeField] float MoveSpeedOT = 1;
    //lägger till .1 för varje sekund 


    void Start()
    {
        oRb = GetComponent<Rigidbody2D>();

        oRb.linearVelocity = -transform.right * MoveSpeed;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("End"))
        {
            Destroy(gameObject);
        }




    }


    //Move obstacle left at set speed with rigidbody2D? or transform

}
