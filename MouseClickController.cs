using System;
using TMPro;
using UnityEngine;

public class MouseClickController : MonoBehaviour
{
    public GameObject seeds;
    public GameObject packet;
    public GameObject info;

    public TextMeshProUGUI seedText;

    public SeasonManager seasonManager;

    [SerializeField] Sprite[] infoSprites;
    public Sprite newSprite;

    public Vector3 mousePosition;

    public RaycastHit2D raycastHit2D;

    public Transform packetTransform;
    public Transform clickObjectLeft;
    public Transform clickObjectRight;
 
    public int infoNumber;

    public int allPeas;
    public int allPeppers;
    public int allPotatoes;
    public int allLettuces;
    public int allCucs;
    public int allCarrots;
    public int allTomatoes;
    public int allOnions;
    public int allSquashes;
    public int allCorns;
    public int allPumpkins;
    public int allTurnips;
    public int allPintos;
    public int allGreenBeans;
    public int allBroccolies;
    public int allCeleries;
    public int allBrussels;
    public int allKales;
    public int allCabbages;

    public float dataTimer = 1;

    public bool textOn = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (textOn == true)
        {
            CountDownTimer();
        }

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

                if (seeds.tag == "pea")
                {
                    allPeas++;

                    seedText.text = "Pea seeds:" + allPeas;
                    textOn = true;
                }

                else if (seeds.tag == "bellPepper")
                {
                    allPeppers++;
                }

                else if (seeds.tag == "potato")
                {
                    allPotatoes++;
                }

                else if (seeds.tag == "lettuce")
                {
                    allPeppers++;
                }

                else if (seeds.tag == "cucumber")
                {
                    allCucs++;
                }

                else if (seeds.tag == "carrot")
                {
                    allCarrots++;
                }

                else if (seeds.tag == "tomato")
                {
                    allTomatoes++;
                }

                else if (seeds.tag == "onion")
                {
                    allOnions++;
                }

                else if (seeds.tag == "squash")
                {
                    allSquashes++;
                }

                else if (seeds.tag == "corn")
                {
                    allCorns++;
                }

                else if (seeds.tag == "pumpkin")
                {
                    allPumpkins++;
                }

                else if (seeds.tag == "turnip")
                {
                    allTurnips++;
                }

                else if (seeds.tag == "pintoBean")
                {
                    allPintos++;
                }

                else if (seeds.tag == "greenBean")
                {
                    allGreenBeans++;
                }

                else if (seeds.tag == "broccoli")
                {
                    allBroccolies++;
                }

                else if (seeds.tag == "celery")
                {
                    allCeleries++;
                }

                else if (seeds.tag == "brusselSprout")
                {
                    allBrussels++;
                }

                else if (seeds.tag == "kale")
                {
                    allKales++;
                }

                else if (seeds.tag == "cabbage")
                {
                    allCabbages++;
                }
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

    public void CountDownTimer()
    {
        dataTimer -= Time.deltaTime;

        if (dataTimer <= 0)
        {
            seedText.text = "";
            textOn = false;
            dataTimer = 1;
        }
    }


}

