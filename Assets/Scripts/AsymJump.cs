using UnityEngine;

public class AsymJump : MonoBehaviour
{
    [SerializeField] float vb = 5;
    [SerializeField] float g = 10;
    enum States { wait, jump, finish};
    States myState = States.wait; 
    Animator animator;

    Vector3 velocity = Vector3.zero;
    Vector3 acceleretion = Vector3.zero;

    float t;
    float tmax;


    void Start()
    {
        animator = GetComponent<Animator>();
    }

    
    void Update()
    {
        if (myState == States.wait)
        {
            animator.speed = 0;
            if (Input.GetMouseButtonUp(0)) 
            { 
                velocity = new Vector3 (0, vb, 0);
                acceleretion = new Vector3 (0, -g, 0);
                animator.Play("Jump2");
                
                myState = States.jump;
                t = 0;
                tmax = 2 * vb / g;
                //print (tmax);
                animator.speed = 0.75f/tmax;
            }
        }

        if (myState == States.jump) 
        {
            t += Time.deltaTime;
            velocity += acceleretion * Time.deltaTime;
            transform.position += velocity * Time.deltaTime;
            if(t > tmax)
            {
                velocity = Vector3.zero;
                acceleretion = Vector3.zero;
                myState = States.finish;
            }
        }

        if (myState == States.finish)
        {
            myState = States.wait;
        }
    }
}
