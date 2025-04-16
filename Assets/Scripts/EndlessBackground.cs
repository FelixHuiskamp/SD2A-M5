using UnityEngine;
using UnityEngine.UIElements;

public class EndlessBackground : MonoBehaviour
{
    private Renderer bgRenderer;
    [SerializeField] private float speed = 2f;
    
    void Start()
    {
        bgRenderer = GetComponent<Renderer>();
    }

    
    void Update()
    {
        bgRenderer.material.mainTextureOffset += new Vector2(speed * Time.deltaTime, 0);
    }
}
