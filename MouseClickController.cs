using UnityEngine;

public class MouseClickController : MonoBehaviour
{
    public GameObject seeds;
    public GameObject packet;
    public GameObject info;

    public SeasonManager seasonManager;

    [SerializeField] Sprite[] infoSprites;
    public Sprite newSprite;

    public Vector3 mousePosition;

    public RaycastHit2D raycastHit2D;

    public Transform packetTransform;
    public Transform clickObjectLeft;
    public Transform clickObjectRight;
 
    public int infoNumber;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        mousePosition = Input.mousePosition;

        Ray mouseRay = Camera.main.ScreenPointToRay(mousePosition);

        if (Input.GetMouseButtonDown(0))
        {
            raycastHit2D = Physics2D.Raycast(mouseRay.origin, mouseRay.direction);
            //clickObject = raycastHit2D ? raycastHit2D.collider.transform : null;

            if (raycastHit2D.collider != null && raycastHit2D.collider.transform == packetTransform)
            {
                clickObjectLeft = raycastHit2D.collider.transform;
            }

            else
            {
                clickObjectLeft = null;
            }


            if (clickObjectLeft)
            {
                Instantiate(seeds, new Vector3(0, 0, 0), Quaternion.identity);

            }
        }

        if (Input.GetMouseButtonDown(1))
        {
            raycastHit2D = Physics2D.Raycast(mouseRay.origin, mouseRay.direction);
            //clickObject = raycastHit2D ? raycastHit2D.collider.transform : null;

            if (raycastHit2D.collider != null && raycastHit2D.collider.transform == packetTransform)
            {
                clickObjectRight = raycastHit2D.collider.transform;
            }

            else
            {
                clickObjectRight = null;
            }


            if (clickObjectRight)
            {
                newSprite = infoSprites[infoNumber];
                info.GetComponent<SpriteRenderer>().sprite = newSprite;
            }
        }

        else if (Input.GetMouseButtonUp(1))
        {
            newSprite = infoSprites[0];
            info.GetComponent<SpriteRenderer>().sprite = newSprite;
        }

    }

   
}

