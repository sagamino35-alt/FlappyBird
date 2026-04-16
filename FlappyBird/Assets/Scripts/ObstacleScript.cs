using UnityEngine;

public class ObstacleScript : MonoBehaviour
{
    Rigidbody2D oRb;
    [SerializeField] float MoveSpeed = 100;
    void Start()
    {
        oRb = GetComponent<Rigidbody2D>();

        oRb.linearVelocity = -transform.right * MoveSpeed;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }

    //Move obstacle left at set speed with rigidbody2D? or transform

}
