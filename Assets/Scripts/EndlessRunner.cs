using UnityEngine;

public class EndlessRunner : MonoBehaviour
{
    public float g = -10f;
    public float vbegin = 10f;
    public float hbegin = 0f;

    [SerializeField] GameObject Runner;
    Animator animator;

    enum State { grounded, airborne};
    State myState = State.grounded;

    QuadraticFunction jumpduration;

    //float time = 0;

    Vector3 velocity = Vector3.zero;
    Vector3 gravity = Vector3.zero;

    float y0;

    void Start()
    {
        animator = GetComponent<Animator>();
        y0 = Runner.transform.position.y;
        jumpduration = new QuadraticFunction(-5, 10, -3);

        print(jumpduration.findZero());
    }

    
    void Update()
    {
        if (myState == State.grounded) 
        {
            if (Input.GetMouseButtonUp(0)) 
            {
                animator.Play("Jump2");
                velocity = new Vector3(0,20f,0);
                gravity = new Vector3(0,-40,0);
                myState = State.airborne;
                animator.speed = 0.75f;
            }
            
        }

        if (myState == State.airborne)
        {
            velocity += gravity * Time.deltaTime; 
            Runner.transform.position += velocity * Time.deltaTime;
            if(Runner.transform.position.y < y0)
            {
                velocity = Vector3.zero;
                gravity = Vector3.zero;
                animator.Play("Run2");
                Runner.transform.position = new Vector3(Runner.transform.position.x, y0, -1);
                myState = State.grounded;
            }
        }
    }   
}
