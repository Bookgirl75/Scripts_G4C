using UnityEngine;

public class TestResizing : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;

    public Vector2 newSize = new Vector2(500f, 300f);

    void Awake()
    {
        spriteRenderer.drawMode = SpriteDrawMode.Sliced;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spriteRenderer.size = newSize;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
