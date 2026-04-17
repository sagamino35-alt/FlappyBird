using UnityEngine;

public class ScreenBoundsScript : MonoBehaviour
{
    private Vector2 screenBounds;
    private float objectWidth;
    private float objectHeight;
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
        objectWidth = transform.GetComponent<SpriteRenderer>().bounds.size.x / 2;
        objectHeight = transform.GetComponent<SpriteRenderer>().bounds.size.y / 2;
    }

    void Update()
    {
        //if player tuth screen bounds y, reset player velocity to 0

        if (transform.position.y > screenBounds.y - objectHeight || transform.position.y < -screenBounds.y + objectHeight)
        {
            GetComponent<Rigidbody2D>().linearVelocity = Vector2.zero;
        }

    }



    // Update is called once per frame
    void LateUpdate()
    {
       
    
        float clampedY = Mathf.Clamp(transform.position.y, -screenBounds.y + objectHeight, screenBounds.y - objectHeight);
        Vector2 pos = transform.position;
        pos.y = clampedY;
        transform.position = pos;



    }


}
