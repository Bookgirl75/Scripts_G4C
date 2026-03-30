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
    public int allEggplants;
    public int allMustardGreens;

    public float dataTimer = 2;

    public bool textOn = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        seedText.text = "";
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

                if (seeds.CompareTag("pea"))
                {
                    allPeas++;

                    seedText.text = "Pea seeds: " + allPeas;
                    textOn = true;
                }

                else if (seeds.CompareTag("bellPepper"))
                {
                    allPeppers++;

                    seedText.text = "Pepper starts: " + allPeppers;
                    textOn = true;
                }

                else if (seeds.CompareTag("potato"))
                {
                    allPotatoes++;

                    seedText.text = "Potato tubers: " + allPotatoes;
                    textOn = true;
                }

                else if (seeds.CompareTag("lettuce"))
                {
                    allLettuces++;

                    seedText.text = "Lettuce seeds: " + allLettuces;
                    textOn = true;
                }

                else if (seeds.CompareTag("cucumber"))
                {
                    allCucs++;

                    seedText.text = "Cucumber seeds: " + allCucs;
                    textOn = true;
                }

                else if (seeds.CompareTag("carrot"))
                {
                    allCarrots++;

                    seedText.text = "Carrot seeds: " + allCarrots;
                    textOn = true;
                }

                else if (seeds.CompareTag("tomato"))
                {
                    allTomatoes++;

                    seedText.text = "Tomato starts: " + allTomatoes;
                    textOn = true;
                }

                else if (seeds.CompareTag("onion"))
                {
                    allOnions++;

                    seedText.text = "Onion seeds: " + allOnions;
                    textOn = true;
                }

                else if (seeds.CompareTag("squash"))
                {
                    allSquashes++;

                    seedText.text = "Squash seeds: " + allSquashes;
                    textOn = true;
                }

                else if (seeds.CompareTag("corn"))
                {
                    allCorns++;

                    seedText.text = "Corn seeds: " + allCorns;
                    textOn = true;
                }

                else if (seeds.CompareTag("pumpkin"))
                {
                    allPumpkins++;

                    seedText.text = "Pumpkin seeds: " + allPumpkins;
                    textOn = true;
                }

                else if (seeds.CompareTag("turnip"))
                {
                    allTurnips++;

                    seedText.text = "Turnip seeds: " + allTurnips;
                    textOn = true;
                }

                else if (seeds.CompareTag("pintoBean"))
                {
                    allPintos++;

                    seedText.text = "Pinto bean seeds: " + allPintos;
                    textOn = true;
                }

                else if (seeds.CompareTag("greenBean"))
                {
                    allGreenBeans++;

                    seedText.text = "Green bean seeds: " + allGreenBeans;
                    textOn = true;
                }

                else if (seeds.CompareTag("broccoli"))
                {
                    allBroccolies++;

                    seedText.text = "Broccoli seeds: " + allBroccolies;
                    textOn = true;
                }

                else if (seeds.CompareTag("celery"))
                {
                    allCeleries++;

                    seedText.text = "Celery starts: " + allCeleries;
                    textOn = true;
                }

                else if (seeds.CompareTag("brusselSprout"))
                {
                    allBrussels++;

                    seedText.text = "Brussel sprout seeds: " + allBrussels;
                    textOn = true;
                }

                else if (seeds.CompareTag("kale"))
                {
                    allKales++;

                    seedText.text = "Kale starts: " + allKales;
                    textOn = true;
                }

                else if (seeds.CompareTag("cabbage"))
                {
                    allCabbages++;

                    seedText.text = "Cabbage seeds: " + allCabbages;
                    textOn = true;
                }

                else if (seeds.CompareTag("eggplant"))
                {
                    allEggplants++;

                    seedText.text = "Eggplant starts: " + allEggplants;
                    textOn = true;
                }

                else if (seeds.CompareTag("mustardGreens"))
                {
                    allMustardGreens++;

                    seedText.text = "Mustard greens seeds: " + allMustardGreens;
                    textOn = true;
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

