using UnityEngine;

public class BouncingBall : MonoBehaviour
{
    Vector3 velocity = new Vector3(1,3,0);
    [SerializeField] Vector3 acceleration = new Vector3(0, -1, 0);

    Vector2 min, max; 

    void Start()
    {
        min = Camera.main.ScreenToWorldPoint(Vector2.zero);
        max = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));

        
    }

    
    void Update()
    {
        
        velocity += acceleration * Time.deltaTime;

        this.transform.position += velocity * Time.deltaTime;

        if (this.transform.position.y > max.y)
        {     
           velocity = new Vector3(velocity.x, -velocity.y, 0);
        }

        if (this.transform.position.x > max.x)
        {
            velocity = new Vector3(-velocity.x, velocity.y, 0);
        }

        if (this.transform.position.y < min.y)
        {
            velocity = new Vector3(velocity.x, -velocity.y, 0);
        }

        if (this.transform.position.x < min.x)
        {
            velocity = new Vector3(-velocity.x, velocity.y, 0);
        }
    }
}
