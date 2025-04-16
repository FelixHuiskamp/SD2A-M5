using UnityEngine;
using TMPro;
public class Jump : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI myText;
    [SerializeField] GameObject Anton;

    Vector3 velocity;
    Vector3 acceleration; 
    float t;
    float timer; 
    float t0 = 0f;
    enum state { wait,active,finished };
    state myState = state.wait;
    float y0;
    
    void Start()
    {
        myText.text = t0.ToString();
        t = t0;
        y0 = Anton.transform.position.y;
    }

    
    void Update()
    {
        if (myState == state.wait) 
        {
            if (Input.GetMouseButtonUp(0)) 
            {
                velocity = new Vector3(0, 5, 0);
                acceleration = new Vector3 (0, -2, 0); 
                myState = state.active;
            }
        }

        if (myState == state.active) 
        {
            velocity += acceleration * Time.deltaTime;
            Anton.transform.position += velocity * Time.deltaTime; 
            t += Time.deltaTime;
            timer = t;
            myText.text = timer.ToString("F3");
            /*
            if (Input.GetMouseButtonUp(1))
            {
                myState = state.finished;
            }
            */
            if (Anton.transform.position.y < y0) 
            { 
                velocity = Vector3.zero;
                acceleration = Vector3.zero;
                myState = state.finished;
                Anton.transform.position = new Vector3(Anton.transform.position.x, y0, 0);
            }
        }

        if(myState == state.finished)
        {
            t = 0;
            myState = state.wait;
        }

    }
}
