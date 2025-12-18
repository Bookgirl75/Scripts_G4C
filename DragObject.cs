using UnityEngine;
using static UnityEditor.U2D.ScriptablePacker;

public class DragObject : MonoBehaviour
{
    public Vector3 offset;
    public Vector3 mousePosition;

    public RaycastHit2D raycastHit2D;

    public Transform seedTransform;
    public Transform clickObject;

    public bool dragging = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (dragging)
        {
            transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition) + offset;
        }

        mousePosition = Input.mousePosition;

        Ray mouseRay = Camera.main.ScreenPointToRay(mousePosition);

        if (Input.GetMouseButtonDown(0))
        {
            raycastHit2D = Physics2D.Raycast(mouseRay.origin, mouseRay.direction);

            if (raycastHit2D.collider != null && raycastHit2D.collider.transform == seedTransform)
            {
                clickObject = raycastHit2D.collider.transform;
            }
            else
            {
                clickObject = null;
            }

            if (clickObject)
            {
                offset = transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
                dragging = true;
            }
        }

        else if (Input.GetMouseButtonUp(0))
        {
            dragging = false;
        }
    }
}
