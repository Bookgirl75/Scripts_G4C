using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.U2D.ScriptablePacker;

public class MoveToPackets : MonoBehaviour
{
    [SerializeField] GameObject[] peaNumber;
    public Vector3 mousePosition;

    public RaycastHit2D raycastHit2D;

    public Transform allPacketTransform;
    public Transform clickObjectLeft;
    public Transform mainCamera;

    public GameObject gardenCanvas;
    public GameObject packetCanvas;

    public float distanceThere = 50;
    public float distanceBack = -50;

    public int totalPeas;
    public bool inGarden = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mainCamera = Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    {
        peaNumber = GameObject.FindGameObjectsWithTag("pea");

        mousePosition = Input.mousePosition;

        Ray mouseRay = Camera.main.ScreenPointToRay(mousePosition);

        if (Input.GetMouseButtonDown(0))
        {
            raycastHit2D = Physics2D.Raycast(mouseRay.origin, mouseRay.direction);
            //clickObject = raycastHit2D ? raycastHit2D.collider.transform : null;

            if (raycastHit2D.collider != null && raycastHit2D.collider.transform == allPacketTransform)
            {
                clickObjectLeft = raycastHit2D.collider.transform;
            }

            else
            {
                clickObjectLeft = null;
            }


            if (clickObjectLeft)
            {
                if (inGarden == true)
                {
                    MoveToPacketArea();
                }
            }
        }
    }

    public void MoveToPacketArea()
    {
        mainCamera.transform.Translate(distanceThere, 0, -10);
        gardenCanvas.transform.gameObject.SetActive(false);
        packetCanvas.transform.gameObject.SetActive(true);
        inGarden = false;
    }

    public void MoveBack()
    {
        mainCamera.transform.Translate(distanceBack, 0, -10);
        gardenCanvas.transform.gameObject.SetActive(true);
        packetCanvas.transform.gameObject.SetActive(false);
        inGarden = true;
    }
}
