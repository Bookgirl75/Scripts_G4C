using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;
using static Unity.Burst.Intrinsics.Arm;

public class GrowthController : MonoBehaviour
{
    public BoxCollider2D peaBoxCollider;
    public BoxCollider2D pepperBoxCollider;
    public BoxCollider2D potatoBoxCollider;
    public BoxCollider2D lettuceBoxCollider;
    public BoxCollider2D cucBoxCollider;
    public BoxCollider2D carrotBoxCollider;
    public BoxCollider2D tomatoBoxCollider;
    public BoxCollider2D onionBoxCollider;
    public BoxCollider2D squashBoxCollider;
    public BoxCollider2D cornBoxCollider;
    public BoxCollider2D pumpkinBoxCollider;
    public BoxCollider2D turnipBoxCollider;
    public BoxCollider2D pintoBoxCollider;
    public BoxCollider2D greenBeanBoxCollider;
    public BoxCollider2D broccoliBoxCollider;
    public BoxCollider2D celeryBoxCollider;
    public BoxCollider2D brusselBoxCollider;
    public BoxCollider2D kaleBoxCollider;
    public BoxCollider2D cabbageBoxCollider;
    public BoxCollider2D eggplantBoxCollider;
    public BoxCollider2D mustardGreenBoxCollider;

    public SpriteRenderer peaSpriteRenderer;
    public SpriteRenderer carrotSpriteRenderer;
    public SpriteRenderer pepperSpriteRenderer;
    public SpriteRenderer potatoSpriteRenderer;
    public SpriteRenderer lettuceSpriteRenderer;
    public SpriteRenderer cucSpriteRenderer;
    public SpriteRenderer onionSpriteRenderer;
    public SpriteRenderer squashSpriteRenderer;
    public SpriteRenderer cornSpriteRenderer;
    public SpriteRenderer pumpkinSpriteRenderer;
    public SpriteRenderer turnipSpriteRenderer;
    public SpriteRenderer tomatoSpriteRenderer;
    public SpriteRenderer pintoSpriteRenderer;
    public SpriteRenderer greenBeanSpriteRenderer;
    public SpriteRenderer broccoliSpriteRenderer;
    public SpriteRenderer celerySpriteRenderer;
    public SpriteRenderer brusselSpriteRenderer;
    public SpriteRenderer kaleSpriteRenderer;
    public SpriteRenderer cabbageSpriteRenderer;
    public SpriteRenderer eggplantSpriteRenderer;
    public SpriteRenderer mustardGreensSpriteRenderer;

    [SerializeField] Sprite[] peaSprites;
    [SerializeField] Sprite[] carrotSprites;
    [SerializeField] Sprite[] pepperSprites;
    [SerializeField] Sprite[] potatoSprites;
    [SerializeField] Sprite[] lettuceSprites;
    [SerializeField] Sprite[] cucSprites;
    [SerializeField] Sprite[] onionSprites;
    [SerializeField] Sprite[] squashSprites;
    [SerializeField] Sprite[] cornSprites;
    [SerializeField] Sprite[] pumpkinSprites;
    [SerializeField] Sprite[] turnipSprites;
    [SerializeField] Sprite[] tomatoSprites;
    [SerializeField] Sprite[] pintoSprites;
    [SerializeField] Sprite[] greenBeanSprites;
    [SerializeField] Sprite[] broccoliSprites;
    [SerializeField] Sprite[] celerySprites;
    [SerializeField] Sprite[] brusselSprites;
    [SerializeField] Sprite[] kaleSprites;
    [SerializeField] Sprite[] cabbageSprites;
    [SerializeField] Sprite[] eggplantSprites;
    [SerializeField] Sprite[] mustardGreensSprites;


    [SerializeField] GameObject[] peas;
    [SerializeField] GameObject[] carrots;
    [SerializeField] GameObject[] peppers;
    [SerializeField] GameObject[] potatoes;
    [SerializeField] GameObject[] lettuces;
    [SerializeField] GameObject[] cucs;
    [SerializeField] GameObject[] onions;
    [SerializeField] GameObject[] corns;
    [SerializeField] GameObject[] squashes;
    [SerializeField] GameObject[] pumpkins;
    [SerializeField] GameObject[] turnips;
    [SerializeField] GameObject[] tomatoes;
    [SerializeField] GameObject[] pintos;
    [SerializeField] GameObject[] greenBeans;
    [SerializeField] GameObject[] broccolies;
    [SerializeField] GameObject[] celeries;
    [SerializeField] GameObject[] brussels;
    [SerializeField] GameObject[] kales;
    [SerializeField] GameObject[] cabbages;
    [SerializeField] GameObject[] eggplants;
    [SerializeField] GameObject[] mustardGreens;

    public Sprite newSprite;


    public SeasonManager seasonManager;

    public Vector2 newPeaSize = new Vector2(1f, 1f);
    public Vector2 newCarrotSize = new Vector2(1f, 1f);
    public Vector2 newPepperSize = new Vector2(1f, 1f);
    public Vector2 newPotatoSize = new Vector2(1f, 1f);
    public Vector2 newLettuceSize = new Vector2(1f, 1f);
    public Vector2 newCucSize = new Vector2(1f, 1f);
    public Vector2 newOnionSize = new Vector2(1f, 1f);
    public Vector2 newCornSize = new Vector2(1f, 1f);
    public Vector2 newSquashSize = new Vector2(1f, 1f);
    public Vector2 newTurnipSize = new Vector2(1f, 1f);
    public Vector2 newTomatoSize = new Vector2(1f, 1f);
    public Vector2 newPintoSize = new Vector2(1f, 1f);
    public Vector2 newGreenBeanSize = new Vector2(1f, 1f);
    public Vector2 newBroccoliSize = new Vector2(1f, 1f);
    public Vector2 newCelerySize = new Vector2(1f, 1f);
    public Vector2 newKaleSize = new Vector2(1f, 1f);
    public Vector2 newPumpkinSize = new Vector2(1f, 1f);
    public Vector2 newCabbageSize = new Vector2(1f, 1f);
    public Vector2 newEggplantSize = new Vector2(1f, 1f);
    public Vector2 newBrusselSize = new Vector2(1f, 1f);
    public Vector2 newMustardGreensSize = new Vector2(1f, 1f);

    public int peaMonthsCounted;
    public int peaSpriteStart;
    public int peaMonthPlanted;
    public int peaBestMonth;
    public int peaFallBestMonth;

    public int carrotMonthsCounted;
    public int carrotSpriteStart;
    public int carrotMonthPlanted;
    public int carrotBestMonth;
    public int carrotFallBestMonth;

    public int pepperMonthsCounted;
    public int pepperSpriteStart;
    public int pepperMonthPlanted;
    public int pepperBestMonth;

    public int potatoMonthsCounted;
    public int potatoSpriteStart;
    public int potatoMonthPlanted;
    public int potatoBestMonth;

    public int lettuceMonthsCounted;
    public int lettuceSpriteStart;
    public int lettuceMonthPlanted;
    public int lettuceBestMonth;
    public int lettuceFallBestMonth;

    public int cucMonthsCounted;
    public int cucSpriteStart;
    public int cucMonthPlanted;
    public int cucBestMonth;

    public int onionMonthsCounted;
    public int onionSpriteStart;
    public int onionMonthPlanted;
    public int onionBestMonth;
    public int onionFallBestMonth;

    public int squashMonthsCounted;
    public int squashSpriteStart;
    public int squashMonthPlanted;
    public int squashBestMonth;
    public int squashFallBestMonth;

    public int cornMonthsCounted;
    public int cornSpriteStart;
    public int cornMonthPlanted;
    public int cornBestMonth;

    public int pumpkinMonthsCounted;
    public int pumpkinSpriteStart;
    public int pumpkinMonthPlanted;
    public int pumpkinBestMonth;

    public int turnipMonthsCounted;
    public int turnipSpriteStart;
    public int turnipMonthPlanted;
    public int turnipBestMonth;
    public int turnipFallBestMonth;

    public int tomatoMonthsCounted;
    public int tomatoSpriteStart;
    public int tomatoMonthPlanted;
    public int tomatoBestMonth;

    public int pintoMonthsCounted;
    public int pintoSpriteStart;
    public int pintoMonthPlanted;
    public int pintoBestMonth;
    public int pintoBestMonth2;

    public int greenBeanMonthsCounted;
    public int greenBeanSpriteStart;
    public int greenBeanMonthPlanted;
    public int greenBeanBestMonth;
    public int greenBeanBestMonth2;

    public int broccoliMonthsCounted;
    public int broccoliSpriteStart;
    public int broccoliMonthPlanted;
    public int broccoliBestMonth;
    public int broccoliFallBestMonth;

    public int celeryMonthsCounted;
    public int celerySpriteStart;
    public int celeryMonthPlanted;
    public int celeryBestMonth;
    public int celeryBestMonth2;

    public int brusselMonthsCounted;
    public int brusselSpriteStart;
    public int brusselMonthPlanted;
    public int brusselBestMonth;
    public int brusselFallBestMonth;

    public int kaleMonthsCounted;
    public int kaleSpriteStart;
    public int kaleMonthPlanted;
    public int kaleBestMonth;

    public int cabbageMonthsCounted;
    public int cabbageSpriteStart;
    public int cabbageMonthPlanted;
    public int cabbageBestMonth;
    public int cabbageFallBestMonth;

    public int eggplantMonthsCounted;
    public int eggplantSpriteStart;
    public int eggplantMonthPlanted;
    public int eggplantBestMonth;

    public int mustardGreensMonthsCounted;
    public int mustardGreensSpriteStart;
    public int mustardGreensMonthPlanted;
    public int mustardGreensBestMonth;

    public int peaCurrentSpriteCount;
    public int carrotCurrentSpriteCount;
    public int pepperCurrentSpriteCount;
    public int potatoCurrentSpriteCount;
    public int lettuceCurrentSpriteCount;
    public int cucCurrentSpriteCount;
    public int onionCurrentSpriteCount;
    public int squashCurrentSpriteCount;
    public int cornCurrentSpriteCount;
    public int pumpkinCurrentSpriteCount;
    public int turnipCurrentSpriteCount;
    public int tomatoCurrentSpriteCount;
    public int pintoCurrentSpriteCount;
    public int greenBeanCurrentSpriteCount;
    public int broccoliCurrentSpriteCount;
    public int celeryCurrentSpriteCount;
    public int brusselCurrentSpriteCount;
    public int kaleCurrentSpriteCount;
    public int cabbageCurrentSpriteCount;
    public int eggplantCurrentSpriteCount;
    public int mustardGreensCurrentSpriteCount;


    public float peaPlantTiming;
    public float carrotPlantTiming;
    public float pepperPlantTiming;
    public float potatoPlantTiming;
    public float lettucePlantTiming;
    public float cucPlantTiming;
    public float onionPlantTiming;
    public float squashPlantTiming;
    public float cornPlantTiming;
    public float pumpkinPlantTiming;
    public float turnipPlantTiming;
    public float tomatoPlantTiming;
    public float pintoPlantTiming;
    public float greenBeanPlantTiming;
    public float broccoliPlantTiming;
    public float celeryPlantTiming;
    public float brusselPlantTiming;
    public float kalePlantTiming;
    public float cabbagePlantTiming;
    public float eggplantPlantTiming;
    public float mustardGreensPlantTiming;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        peaPlantTiming = 0;
        carrotPlantTiming = 0;
        pepperPlantTiming = 0;
        potatoPlantTiming = 0;
        lettucePlantTiming = 0;
        cucPlantTiming = 0;
        onionPlantTiming = 0;
        squashPlantTiming = 0;
        cornPlantTiming = 0;
        pumpkinPlantTiming = 0;
        turnipPlantTiming = 0;
        tomatoPlantTiming = 0;
        pintoPlantTiming = 0;
        greenBeanPlantTiming = 0;
        broccoliPlantTiming = 0;
        celeryPlantTiming = 0;
        brusselPlantTiming = 0;
        kalePlantTiming = 0;
        cabbagePlantTiming = 0;
        eggplantPlantTiming = 0;
        mustardGreensPlantTiming = 0;
    }

    // Update is called once per frame
    void Update()
    {
        peas = GameObject.FindGameObjectsWithTag("pea");
        carrots = GameObject.FindGameObjectsWithTag("carrot");
        peppers = GameObject.FindGameObjectsWithTag("bellPepper");
        potatoes = GameObject.FindGameObjectsWithTag("potato");
        lettuces = GameObject.FindGameObjectsWithTag("lettuce");
        cucs = GameObject.FindGameObjectsWithTag("cucumber");
        onions = GameObject.FindGameObjectsWithTag("onion");
        squashes = GameObject.FindGameObjectsWithTag("squash");
        corns = GameObject.FindGameObjectsWithTag("corn");
        pumpkins = GameObject.FindGameObjectsWithTag("pumpkin");
        turnips = GameObject.FindGameObjectsWithTag("turnip");
        tomatoes = GameObject.FindGameObjectsWithTag("tomato");
        pintos = GameObject.FindGameObjectsWithTag("pintoBean");
        greenBeans = GameObject.FindGameObjectsWithTag("greenBean");
        broccolies = GameObject.FindGameObjectsWithTag("broccoli");
        celeries = GameObject.FindGameObjectsWithTag("celery");
        brussels = GameObject.FindGameObjectsWithTag("brusselSprout");
        kales = GameObject.FindGameObjectsWithTag("kale");
        cabbages = GameObject.FindGameObjectsWithTag("cabbage");
        eggplants = GameObject.FindGameObjectsWithTag("eggplant");
        mustardGreens = GameObject.FindGameObjectsWithTag("mustardGreens");
    }

    public void PlantPea()
    {
        SetPeaPlantedSprite();
        peaMonthPlanted = seasonManager.season;
        
        if ((peaMonthPlanted == peaBestMonth) || (peaBestMonth == peaFallBestMonth))
        {
            peaPlantTiming = 1;
        }

        if (((peaMonthPlanted == (peaBestMonth +1)) || (peaMonthPlanted == (peaBestMonth -1))) ||
            ((peaMonthPlanted == (peaFallBestMonth + 1)) || (peaMonthPlanted == (peaFallBestMonth - 1))))
        {
            peaPlantTiming = .8f;
        }
    }
    public void SetPeaPlantedSprite()
    {
        newSprite = peaSprites[1];
        peaCurrentSpriteCount = 1;
        foreach (GameObject pea in peas)
        {
            pea.GetComponent<SpriteRenderer>().sprite = newSprite;
        }
    }
    public void GrowPeaSprite()
    {
        newSprite = peaSprites[peaSpriteStart];
        peaCurrentSpriteCount++;
        foreach (GameObject pea in peas)
        {
            pea.GetComponent<SpriteRenderer>().sprite = newSprite;
            peaSpriteRenderer = pea.GetComponent<SpriteRenderer>();
            peaSpriteRenderer.drawMode = SpriteDrawMode.Sliced;
            peaBoxCollider = pea.GetComponent<BoxCollider2D>();
            peaBoxCollider.offset = new Vector2(0, 0);

            if (peaCurrentSpriteCount == 2)
            {
                peaSpriteRenderer.size = new Vector2(1, 1);
                peaBoxCollider.size = new Vector2(1, 1);
            }

            if (peaCurrentSpriteCount == 3)
            {
                peaSpriteRenderer.size = new Vector2(1, 1);
                peaBoxCollider.size = new Vector2(1, 1);
            }

            if (peaCurrentSpriteCount == 4)
            {
                peaSpriteRenderer.size = new Vector2(1, 1);
                peaBoxCollider.size = new Vector2(1, 1);
            }

        }
    }


    public void PlantCarrot()
    {
        SetCarrotPlantedSprite();
        carrotMonthPlanted = seasonManager.season;

        if ((carrotMonthPlanted == carrotBestMonth) || (carrotBestMonth == carrotFallBestMonth))
        {
            carrotPlantTiming = 1;
        }

        if (((carrotMonthPlanted == (carrotBestMonth + 1)) || (carrotMonthPlanted == (carrotBestMonth - 1))) ||
            ((carrotMonthPlanted == (carrotFallBestMonth + 1)) || (carrotMonthPlanted == (carrotFallBestMonth - 1))))
        {
            carrotPlantTiming = .8f;
        }
    }
    public void SetCarrotPlantedSprite()
    {
        newSprite = carrotSprites[1];
        carrotCurrentSpriteCount = 1;
        foreach (GameObject carrot in carrots)
        {
            carrot.GetComponent<SpriteRenderer>().sprite = newSprite;
        }
    }
    public void GrowCarrotSprite()
    {
        newSprite = carrotSprites[carrotSpriteStart];
        carrotCurrentSpriteCount++;
        foreach (GameObject carrot in carrots)
        {
            carrot.GetComponent<SpriteRenderer>().sprite = newSprite;
            carrotBoxCollider = carrot.GetComponent<BoxCollider2D>();
            
            if (carrotCurrentSpriteCount == 2)
            {
                carrotBoxCollider.offset = new Vector2(0, 0);
                DestroyImmediate(carrotBoxCollider);
                carrot.AddComponent<BoxCollider2D>();
                carrot.transform.localScale = newCarrotSize;
                carrotBoxCollider = carrot.GetComponent<BoxCollider2D>();
            }

            if (carrotCurrentSpriteCount == 3)
            {
                carrotBoxCollider.offset = new Vector2(0, 0);
                DestroyImmediate(carrotBoxCollider);
                carrot.AddComponent<BoxCollider2D>();
                carrot.transform.localScale = newCarrotSize;
                carrotBoxCollider = carrot.GetComponent<BoxCollider2D>();
            }

            /*if (carrotCurrentSpriteCount == 4)
            {
                carrotSpriteRenderer.size = new Vector2(1, 1);
                carrotBoxCollider.size = new Vector2(1, 1);
            }

            if (carrotCurrentSpriteCount == 5)
            {
                carrotSpriteRenderer.size = new Vector2(1, 1);
                carrotBoxCollider.size = new Vector2(1, 1);
            }

            if (carrotCurrentSpriteCount <= 6)
            {
                carrotSpriteRenderer.size = new Vector2(1, 1);
                carrotBoxCollider.size = new Vector2(1, 1);
            }*/
        }
    }


    public void PlantPepper()
    {
        SetPepperPlantedSprite();
        pepperMonthPlanted = seasonManager.season;

        if (pepperMonthPlanted == pepperBestMonth)
        {
            pepperPlantTiming = 1;
        }

        if ((pepperMonthPlanted == (pepperBestMonth + 1)) || (pepperMonthPlanted == (pepperBestMonth - 1)))
        {
            pepperPlantTiming = .8f;
        }
    }
    public void SetPepperPlantedSprite()
    {
        newSprite = pepperSprites[1];
        pepperCurrentSpriteCount = 1;
        foreach (GameObject pepper in peppers)
        {
            pepper.GetComponent<SpriteRenderer>().sprite = newSprite;
        }
    }
    public void GrowPepperSprite()
    {
        newSprite = pepperSprites[pepperSpriteStart];
        pepperCurrentSpriteCount++;
        foreach (GameObject pepper in peppers)
        {
            pepper.GetComponent<SpriteRenderer>().sprite = newSprite;
            pepperBoxCollider = pepper.GetComponent<BoxCollider2D>();
            
            if (pepperCurrentSpriteCount == 2)
            {
                pepperSpriteRenderer.size = new Vector2(1, 1);
                pepperBoxCollider.size = new Vector2(1, 1);
            }

            if (pepperCurrentSpriteCount == 3)
            {
                pepperSpriteRenderer.size = new Vector2(1, 1);
                pepperBoxCollider.size = new Vector2(1, 1);
            }

            if (pepperCurrentSpriteCount == 4)
            {
                pepperSpriteRenderer.size = new Vector2(1, 1);
                pepperBoxCollider.size = new Vector2(1, 1);
            }

            if (pepperCurrentSpriteCount == 5)
            {
                pepperSpriteRenderer.size = new Vector2(1, 1);
                pepperBoxCollider.size = new Vector2(1, 1);
            }

            if (pepperCurrentSpriteCount <= 6)
            {
                pepperSpriteRenderer.size = new Vector2(1, 1);
                pepperBoxCollider.size = new Vector2(1, 1);
            }
        }
    }


    public void PlantPotato()
    {
        SetPotatoPlantedSprite();
        potatoMonthPlanted = seasonManager.season;

        if (potatoMonthPlanted == potatoBestMonth)
        {
            potatoPlantTiming = 1;
        }

        if ((potatoMonthPlanted == (potatoBestMonth + 1)) || (potatoMonthPlanted == (potatoBestMonth - 1)))
        {
            potatoPlantTiming = .8f;
        }
    }
    public void SetPotatoPlantedSprite()
    {
        newSprite = potatoSprites[1];
        potatoCurrentSpriteCount = 1;
        foreach (GameObject potato in potatoes)
        {
            potato.GetComponent<SpriteRenderer>().sprite = newSprite;
        }
    }
    public void GrowPotatoSprite()
    {
        newSprite = potatoSprites[potatoSpriteStart];
        potatoCurrentSpriteCount++;
        foreach (GameObject potato in potatoes)
        {
            potato.GetComponent<SpriteRenderer>().sprite = newSprite;
            potatoBoxCollider = potato.GetComponent<BoxCollider2D>();

            if (potatoCurrentSpriteCount == 2)
            {
                potatoSpriteRenderer.size = new Vector2(1, 1);
                potatoBoxCollider.size = new Vector2(1, 1);
            }

            if (potatoCurrentSpriteCount == 3)
            {
                potatoSpriteRenderer.size = new Vector2(1, 1);
                potatoBoxCollider.size = new Vector2(1, 1);
            }

            if (potatoCurrentSpriteCount == 4)
            {
                potatoSpriteRenderer.size = new Vector2(1, 1);
                potatoBoxCollider.size = new Vector2(1, 1);
            }

            if (potatoCurrentSpriteCount == 5)
            {
                potatoSpriteRenderer.size = new Vector2(1, 1);
                potatoBoxCollider.size = new Vector2(1, 1);
            }

            if (potatoCurrentSpriteCount == 6)
            {
                potatoSpriteRenderer.size = new Vector2(1, 1);
                potatoBoxCollider.size = new Vector2(1, 1);
            }

            if (potatoCurrentSpriteCount <= 7)
            {
                potatoSpriteRenderer.size = new Vector2(1, 1);
                potatoBoxCollider.size = new Vector2(1, 1);
            }
        }
    }


    public void PlantLettuce()
    {
        SetLettucePlantedSprite();
        lettuceMonthPlanted = seasonManager.season;

        if ((lettuceMonthPlanted == lettuceBestMonth) || (lettuceBestMonth == lettuceFallBestMonth))
        {
            lettucePlantTiming = 1;
        }

        if (((lettuceMonthPlanted == (lettuceBestMonth + 1)) || (lettuceMonthPlanted == (lettuceBestMonth - 1))) ||
            ((lettuceMonthPlanted == (lettuceFallBestMonth + 1)) || (lettuceMonthPlanted == (lettuceFallBestMonth - 1))))
        {
            lettucePlantTiming = .8f;
        }
    }
    public void SetLettucePlantedSprite()
    {
        newSprite = lettuceSprites[1];
        lettuceCurrentSpriteCount = 1;
        foreach (GameObject lettuce in lettuces)
        {
            lettuce.GetComponent<SpriteRenderer>().sprite = newSprite;
        }
    }
    public void GrowLettuceSprite()
    {
        newSprite = lettuceSprites[lettuceSpriteStart];
        lettuceCurrentSpriteCount++;
        foreach (GameObject lettuce in lettuces)
        {
            lettuce.GetComponent<SpriteRenderer>().sprite = newSprite;
            lettuceBoxCollider = lettuce.GetComponent<BoxCollider2D>();

            if (lettuceCurrentSpriteCount == 2)
            {
                lettuceSpriteRenderer.size = new Vector2(1, 1);
                lettuceBoxCollider.size = new Vector2(1, 1);
            }

            if (lettuceCurrentSpriteCount == 3)
            {
                lettuceSpriteRenderer.size = new Vector2(1, 1);
                lettuceBoxCollider.size = new Vector2(1, 1);
            }

            if (lettuceCurrentSpriteCount == 4)
            {
                lettuceSpriteRenderer.size = new Vector2(1, 1);
                lettuceBoxCollider.size = new Vector2(1, 1);
            }

            if (lettuceCurrentSpriteCount == 5)
            {
                lettuceSpriteRenderer.size = new Vector2(1, 1);
                lettuceBoxCollider.size = new Vector2(1, 1);
            }

            if (lettuceCurrentSpriteCount <= 6)
            {
                lettuceSpriteRenderer.size = new Vector2(1, 1);
                lettuceBoxCollider.size = new Vector2(1, 1);
            }
        }
    }


    public void PlantCuc()
    {
        SetCucPlantedSprite();
        cucMonthPlanted = seasonManager.season;

        if (cucMonthPlanted == cucBestMonth)
        {
            cucPlantTiming = 1;
        }

        if ((cucMonthPlanted == (cucBestMonth + 1)) || (cucMonthPlanted == (cucBestMonth - 1)))
        {
            cucPlantTiming = .8f;
        }
    }
    public void SetCucPlantedSprite()
    {
        newSprite = cucSprites[1];
        cucCurrentSpriteCount = 1;
        foreach (GameObject cuc in cucs)
        {
            cuc.GetComponent<SpriteRenderer>().sprite = newSprite;
        }
    }
    public void GrowCucSprite()
    {
        newSprite = cucSprites[cucSpriteStart];
        cucCurrentSpriteCount++;
        foreach (GameObject cuc in cucs)
        {
            cuc.GetComponent<SpriteRenderer>().sprite = newSprite;
            cucBoxCollider = cuc.GetComponent<BoxCollider2D>();

            if (cucCurrentSpriteCount == 2)
            {
                cucSpriteRenderer.size = new Vector2(1, 1);
                cucBoxCollider.size = new Vector2(1, 1);
            }

            if (cucCurrentSpriteCount == 3)
            {
                cucSpriteRenderer.size = new Vector2(1, 1);
                cucBoxCollider.size = new Vector2(1, 1);
            }

            if (cucCurrentSpriteCount == 4)
            {
                cucSpriteRenderer.size = new Vector2(1, 1);
                cucBoxCollider.size = new Vector2(1, 1);
            }

            if (cucCurrentSpriteCount <= 5)
            {
                cucSpriteRenderer.size = new Vector2(1, 1);
                cucBoxCollider.size = new Vector2(1, 1);
            }
        }
    }


    public void PlantOnion()
    {
        SetOnionPlantedSprite();
        onionMonthPlanted = seasonManager.season;

        if ((onionMonthPlanted == onionBestMonth) || (onionBestMonth == onionFallBestMonth))
        {
            onionPlantTiming = 1;
        }

        if (((onionMonthPlanted == (onionBestMonth + 1)) || (onionMonthPlanted == (onionBestMonth - 1))) ||
            ((onionMonthPlanted == (onionFallBestMonth + 1)) || (onionMonthPlanted == (onionFallBestMonth - 1))))
        {
            onionPlantTiming = .8f;
        }
    }
    public void SetOnionPlantedSprite()
    {
        newSprite = onionSprites[1];
        onionCurrentSpriteCount = 1;
        foreach (GameObject onion in onions)
        {
            onion.GetComponent<SpriteRenderer>().sprite = newSprite;
        }
    }
    public void GrowOnionSprite()
    {
        newSprite = onionSprites[onionSpriteStart];
        onionCurrentSpriteCount++;
        foreach (GameObject onion in onions)
        {
            onion.GetComponent<SpriteRenderer>().sprite = newSprite;
            onionBoxCollider = onion.GetComponent<BoxCollider2D>();

            if (onionCurrentSpriteCount == 2)
            {
                onionSpriteRenderer.size = newOnionSize;
                onionBoxCollider.size = newOnionBoxSize;
            }

            if (onionCurrentSpriteCount == 3)
            {
                onionSpriteRenderer.size = new Vector2(1, 1);
                onionBoxCollider.size = new Vector2(1, 1);
            }

            if (onionCurrentSpriteCount == 4)
            {
                onionSpriteRenderer.size = new Vector2(1, 1);
                onionBoxCollider.size = new Vector2(1, 1);
            }

            if (onionCurrentSpriteCount == 5)
            {
                onionSpriteRenderer.size = new Vector2(1, 1);
                onionBoxCollider.size = new Vector2(1, 1);
            }

            if (onionCurrentSpriteCount <= 6)
            {
                onionSpriteRenderer.size = new Vector2(1, 1);
                onionBoxCollider.size = new Vector2(1, 1);
            }
        }
    }


    public void PlantSquash()
    {
        SetSquashPlantedSprite();
        squashMonthPlanted = seasonManager.season;

        if ((squashMonthPlanted == squashBestMonth) || (squashBestMonth == squashFallBestMonth))
        {
            squashPlantTiming = 1;
        }

        if (((squashMonthPlanted == (squashBestMonth + 1)) || (squashMonthPlanted == (squashBestMonth - 1))) ||
            ((squashMonthPlanted == (squashFallBestMonth + 1)) || (squashMonthPlanted == (squashFallBestMonth - 1))))
        {
            peaPlantTiming = .8f;
        }
    }
    public void SetSquashPlantedSprite()
    {
        newSprite = squashSprites[1];
        squashCurrentSpriteCount = 1;
        foreach (GameObject squash in squashes)
        {
            squash.GetComponent<SpriteRenderer>().sprite = newSprite;
        }
    }
    public void GrowSquashSprite()
    {
        newSprite = squashSprites[squashSpriteStart];
        squashCurrentSpriteCount++;
        foreach (GameObject squash in squashes)
        {
            squash.GetComponent<SpriteRenderer>().sprite = newSprite;
            squashBoxCollider = squash.GetComponent<BoxCollider2D>();

            if (squashCurrentSpriteCount == 2)
            {
                squashSpriteRenderer.size = new Vector2(1, 1);
                squashBoxCollider.size = new Vector2(1, 1);
            }

            if (squashCurrentSpriteCount == 3)
            {
                squashSpriteRenderer.size = new Vector2(1, 1);
                squashBoxCollider.size = new Vector2(1, 1);
            }

            if (squashCurrentSpriteCount == 4)
            {
                squashSpriteRenderer.size = new Vector2(1, 1);
                squashBoxCollider.size = new Vector2(1, 1);
            }

            if (squashCurrentSpriteCount == 5)
            {
                squashSpriteRenderer.size = new Vector2(1, 1);
                squashBoxCollider.size = new Vector2(1, 1);
            }

            if (squashCurrentSpriteCount == 6)
            {
                squashSpriteRenderer.size = new Vector2(1, 1);
                squashBoxCollider.size = new Vector2(1, 1);
            }
            
            if (squashCurrentSpriteCount <= 7)
            {
                squashSpriteRenderer.size = new Vector2(1, 1);
                squashBoxCollider.size = new Vector2(1, 1);
            }
        }
    }


    public void PlantCorn()
    {
        SetCornPlantedSprite();
        cornMonthPlanted = seasonManager.season;

        if (cornMonthPlanted == cornBestMonth)
        {
            cornPlantTiming = 1;
        }

        if ((cornMonthPlanted == (cornBestMonth + 1)) || (cornMonthPlanted == (cornBestMonth - 1)))
        {
            cornPlantTiming = .8f;
        }
    }
    public void SetCornPlantedSprite()
    {
        newSprite = cornSprites[1];
        cornCurrentSpriteCount = 1;
        foreach (GameObject corn in corns)
        {
            corn.GetComponent<SpriteRenderer>().sprite = newSprite;
        }
    }
    public void GrowCornSprite()
    {
        newSprite = cornSprites[cornSpriteStart];
        cornCurrentSpriteCount++;
        foreach (GameObject corn in corns)
        {
            corn.GetComponent<SpriteRenderer>().sprite = newSprite;
            cornBoxCollider = corn.GetComponent<BoxCollider2D>();

            if (cornCurrentSpriteCount == 2)
            {
                cornSpriteRenderer.size = new Vector2(1, 1);
                cornBoxCollider.size = new Vector2(1, 1);
            }

            if (cornCurrentSpriteCount == 3)
            {
                cornSpriteRenderer.size = new Vector2(1, 1);
                cornBoxCollider.size = new Vector2(1, 1);
            }

            if (cornCurrentSpriteCount == 4)
            {
                cornSpriteRenderer.size = new Vector2(1, 1);
                cornBoxCollider.size = new Vector2(1, 1);
            }

            if (cornCurrentSpriteCount <= 5)
            {
                cornSpriteRenderer.size = new Vector2(1, 1);
                cornBoxCollider.size = new Vector2(1, 1);
            }
        }
    }


    public void PlantPumpkin()
    {
        SetPumpkinPlantedSprite();
        pumpkinMonthPlanted = seasonManager.season;

        if (pumpkinMonthPlanted == pumpkinBestMonth)
        {
            pumpkinPlantTiming = 1;
        }

        if ((pumpkinMonthPlanted == (pumpkinBestMonth + 1)) || (pumpkinMonthPlanted == (pumpkinBestMonth - 1)))
        {
            pumpkinPlantTiming = .8f;
        }
    }
    public void SetPumpkinPlantedSprite()
    {
        newSprite = pumpkinSprites[1];
        pumpkinCurrentSpriteCount = 1;
        foreach (GameObject pumpkin in pumpkins)
        {
            pumpkin.GetComponent<SpriteRenderer>().sprite = newSprite;
        }
    }
    public void GrowPumpkinSprite()
    {
        newSprite = pumpkinSprites[pumpkinSpriteStart];
        pumpkinCurrentSpriteCount++;
        foreach (GameObject pumpkin in pumpkins)
        {
            pumpkin.GetComponent<SpriteRenderer>().sprite = newSprite;
            pumpkinBoxCollider = pumpkin.GetComponent<BoxCollider2D>();

            if (pumpkinCurrentSpriteCount == 2)
            {
                pumpkinSpriteRenderer.size = new Vector2(1, 1);
                pumpkinBoxCollider.size = new Vector2(1, 1);
            }

            if (pumpkinCurrentSpriteCount == 3)
            {
                pumpkinSpriteRenderer.size = new Vector2(1, 1);
                pumpkinBoxCollider.size = new Vector2(1, 1);
            }

            if (pumpkinCurrentSpriteCount == 4)
            {
                pumpkinSpriteRenderer.size = new Vector2(1, 1);
                pumpkinBoxCollider.size = new Vector2(1, 1);
            }

            if (pumpkinCurrentSpriteCount == 5)
            {
                pumpkinSpriteRenderer.size = new Vector2(1, 1);
                pumpkinBoxCollider.size = new Vector2(1, 1);
            }

            if (pumpkinCurrentSpriteCount == 6)
            {
                pumpkinSpriteRenderer.size = new Vector2(1, 1);
                pumpkinBoxCollider.size = new Vector2(1, 1);
            }

            if (pumpkinCurrentSpriteCount <= 7)
            {
                pumpkinSpriteRenderer.size = new Vector2(1, 1);
                pumpkinBoxCollider.size = new Vector2(1, 1);
            }
        }
    }


    public void PlantTurnip()
    {
        SetTurnipPlantedSprite();
        turnipMonthPlanted = seasonManager.season;

        if ((turnipMonthPlanted == turnipBestMonth) || (turnipBestMonth == turnipFallBestMonth))
        {
            turnipPlantTiming = 1;
        }

        if (((turnipMonthPlanted == (turnipBestMonth + 1)) || (turnipMonthPlanted == (turnipBestMonth - 1))) ||
            ((turnipMonthPlanted == (turnipFallBestMonth + 1)) || (turnipMonthPlanted == (turnipFallBestMonth - 1))))
        {
            turnipPlantTiming = .8f;
        }
    }
    public void SetTurnipPlantedSprite()
    {
        newSprite = turnipSprites[1];
        turnipCurrentSpriteCount = 1;
        foreach (GameObject turnip in turnips)
        {
            turnip.GetComponent<SpriteRenderer>().sprite = newSprite;
        }
    }
    public void GrowTurnipSprite()
    {
        newSprite = turnipSprites[turnipSpriteStart];
        turnipCurrentSpriteCount++;
        foreach (GameObject turnip in turnips)
        {
            turnip.GetComponent<SpriteRenderer>().sprite = newSprite;
            turnipBoxCollider = turnip.GetComponent<BoxCollider2D>();

            if (turnipCurrentSpriteCount == 2)
            {
                turnipSpriteRenderer.size = new Vector2(1, 1);
                turnipBoxCollider.size = new Vector2(1, 1);
            }

            if (turnipCurrentSpriteCount == 3)
            {
                turnipSpriteRenderer.size = new Vector2(1, 1);
                turnipBoxCollider.size = new Vector2(1, 1);
            }

            if (turnipCurrentSpriteCount == 4)
            {
                turnipSpriteRenderer.size = new Vector2(1, 1);
                turnipBoxCollider.size = new Vector2(1, 1);
            }

            if (turnipCurrentSpriteCount <= 5)
            {
                turnipSpriteRenderer.size = new Vector2(1, 1);
                turnipBoxCollider.size = new Vector2(1, 1);
            }
        }
    }


    public void PlantTomato()
    {
        SetTomatoPlantedSprite();
        tomatoMonthPlanted = seasonManager.season;

        if (tomatoMonthPlanted == tomatoBestMonth)
        {
            tomatoPlantTiming = 1;
        }

        if ((tomatoMonthPlanted == (tomatoBestMonth + 1)) || (tomatoMonthPlanted == (tomatoBestMonth - 1)))
        {
            tomatoPlantTiming = .8f;
        }
    }
    public void SetTomatoPlantedSprite()
    {
        newSprite = tomatoSprites[1];
        tomatoCurrentSpriteCount = 1;
        foreach (GameObject tomato in tomatoes)
        {
            tomato.GetComponent<SpriteRenderer>().sprite = newSprite;
        }
    }
    public void GrowTomatoSprite()
    {
        newSprite = tomatoSprites[tomatoSpriteStart];
        tomatoCurrentSpriteCount++;
        foreach (GameObject tomato in tomatoes)
        {
            tomato.GetComponent<SpriteRenderer>().sprite = newSprite;
            tomatoBoxCollider = tomato.GetComponent<BoxCollider2D>();

            if (tomatoCurrentSpriteCount == 2)
            {
                tomatoSpriteRenderer.size = new Vector2(1, 1);
                tomatoBoxCollider.size = new Vector2(1, 1);
            }

            if (tomatoCurrentSpriteCount == 3)
            {
                tomatoSpriteRenderer.size = new Vector2(1, 1);
                tomatoBoxCollider.size = new Vector2(1, 1);
            }

            if (tomatoCurrentSpriteCount == 4)
            {
                tomatoSpriteRenderer.size = new Vector2(1, 1);
                tomatoBoxCollider.size = new Vector2(1, 1);
            }

            if (tomatoCurrentSpriteCount == 5)
            {
                tomatoSpriteRenderer.size = new Vector2(1, 1);
                tomatoBoxCollider.size = new Vector2(1, 1);
            }

            if (tomatoCurrentSpriteCount <= 6)
            {
                tomatoSpriteRenderer.size = new Vector2(1, 1);
                tomatoBoxCollider.size = new Vector2(1, 1);
            }
        }
    }


    public void PlantPinto()
    {
        SetPintoPlantedSprite();
        pintoMonthPlanted = seasonManager.season;

        if ((pintoMonthPlanted == pintoBestMonth) || (pintoBestMonth == pintoBestMonth2))
        {
            pintoPlantTiming = 1;
        }

        if ((pintoBestMonth == (pintoBestMonth - 1)) || (pintoBestMonth2 == (pintoBestMonth2 + 1)))
        {
            pintoPlantTiming = .8f;
        }
    }
    public void SetPintoPlantedSprite()
    {
        newSprite = pintoSprites[1];
        pintoCurrentSpriteCount = 1;
        foreach (GameObject pinto in pintos)
        {
            pinto.GetComponent<SpriteRenderer>().sprite = newSprite;
        }
    }
    public void GrowPintoSprite()
    {
        newSprite = pintoSprites[pintoSpriteStart];
        pintoCurrentSpriteCount++;
        foreach (GameObject pinto in pintos)
        {
            pinto.GetComponent<SpriteRenderer>().sprite = newSprite;
            pintoBoxCollider = pinto.GetComponent<BoxCollider2D>();

            if (pintoCurrentSpriteCount == 2)
            {
                pintoSpriteRenderer.size = new Vector2(1, 1);
                pintoBoxCollider.size = new Vector2(1, 1);
            }

            if (pintoCurrentSpriteCount == 3)
            {
                pintoSpriteRenderer.size = new Vector2(1, 1);
                pintoBoxCollider.size = new Vector2(1, 1);
            }

            if (pintoCurrentSpriteCount == 4)
            {
                pintoSpriteRenderer.size = new Vector2(1, 1);
                pintoBoxCollider.size = new Vector2(1, 1);
            }

            if (pintoCurrentSpriteCount == 5)
            {
                pintoSpriteRenderer.size = new Vector2(1, 1);
                pintoBoxCollider.size = new Vector2(1, 1);
            }

            if (pintoCurrentSpriteCount == 6)
            {
                pintoSpriteRenderer.size = new Vector2(1, 1);
                pintoBoxCollider.size = new Vector2(1, 1);
            }

            if (pintoCurrentSpriteCount == 7)
            {
                pintoSpriteRenderer.size = new Vector2(1, 1);
                pintoBoxCollider.size = new Vector2(1, 1);
            }

            if (pintoCurrentSpriteCount <= 8)
            {
                pintoSpriteRenderer.size = new Vector2(1, 1);
                pintoBoxCollider.size = new Vector2(1, 1);
            }
        }
    }


    public void PlantGreenBean()
    {
        SetGreenBeanPlantedSprite();
        greenBeanMonthPlanted = seasonManager.season;

        if ((greenBeanMonthPlanted == greenBeanBestMonth) || (greenBeanBestMonth == greenBeanBestMonth2))
        {
            greenBeanPlantTiming = 1;
        }

        if ((greenBeanBestMonth == (greenBeanBestMonth - 1)) || (greenBeanBestMonth2 == (greenBeanBestMonth2 + 1)))
        {
            greenBeanPlantTiming = .8f;
        }
    }
    public void SetGreenBeanPlantedSprite()
    {
        newSprite = greenBeanSprites[1];
        greenBeanCurrentSpriteCount = 1;
        foreach (GameObject greenBean in greenBeans)
        {
            greenBean.GetComponent<SpriteRenderer>().sprite = newSprite;
        }
    }
    public void GrowGreenBeanSprite()
    {
        newSprite = greenBeanSprites[greenBeanSpriteStart];
        greenBeanCurrentSpriteCount++;
        foreach (GameObject greenBean in greenBeans)
        {
            greenBean.GetComponent<SpriteRenderer>().sprite = newSprite;
            greenBeanBoxCollider = greenBean.GetComponent<BoxCollider2D>();

            if (greenBeanCurrentSpriteCount == 2)
            {
                greenBeanSpriteRenderer.size = new Vector2(1, 1);
                greenBeanBoxCollider.size = new Vector2(1, 1);
            }

            if (greenBeanCurrentSpriteCount == 3)
            {
                greenBeanSpriteRenderer.size = new Vector2(1, 1);
                greenBeanBoxCollider.size = new Vector2(1, 1);
            }

            if (greenBeanCurrentSpriteCount == 4)
            {
                greenBeanSpriteRenderer.size = new Vector2(1, 1);
                greenBeanBoxCollider.size = new Vector2(1, 1);
            }

            if (greenBeanCurrentSpriteCount <= 5)
            {
                greenBeanSpriteRenderer.size = new Vector2(1, 1);
                greenBeanBoxCollider.size = new Vector2(1, 1);
            }
        }
    }


    public void PlantBroccoli()
    {
        SetBroccoliPlantedSprite();
        broccoliMonthPlanted = seasonManager.season;

        if ((broccoliMonthPlanted == broccoliBestMonth) || (broccoliBestMonth == broccoliFallBestMonth))
        {
            broccoliPlantTiming = 1;
        }

        if (((broccoliMonthPlanted == (broccoliBestMonth + 1)) || (broccoliMonthPlanted == (broccoliBestMonth - 1))) ||
            ((broccoliMonthPlanted == (broccoliFallBestMonth + 1)) || (broccoliMonthPlanted == (broccoliFallBestMonth - 1))))
        {
            broccoliPlantTiming = .8f;
        }
    }
    public void SetBroccoliPlantedSprite()
    {
        newSprite = broccoliSprites[1];
        broccoliCurrentSpriteCount = 1;
        foreach (GameObject broccoli in broccolies)
        {
            broccoli.GetComponent<SpriteRenderer>().sprite = newSprite;
        }
    }
    public void GrowBroccoliSprite()
    {
        newSprite = broccoliSprites[broccoliSpriteStart];
        broccoliCurrentSpriteCount++;
        foreach (GameObject broccoli in broccolies)
        {
            broccoli.GetComponent<SpriteRenderer>().sprite = newSprite;
            broccoliBoxCollider = broccoli.GetComponent<BoxCollider2D>();

            if (broccoliCurrentSpriteCount == 2)
            {
                broccoliSpriteRenderer.size = new Vector2(1, 1);
                broccoliBoxCollider.size = new Vector2(1, 1);
            }

            if (broccoliCurrentSpriteCount == 3)
            {
                broccoliSpriteRenderer.size = new Vector2(1, 1);
                broccoliBoxCollider.size = new Vector2(1, 1);
            }

            if (broccoliCurrentSpriteCount == 4)
            {
                broccoliSpriteRenderer.size = new Vector2(1, 1);
                broccoliBoxCollider.size = new Vector2(1, 1);
            }

            if (broccoliCurrentSpriteCount == 5)
            {
                broccoliSpriteRenderer.size = new Vector2(1, 1);
                broccoliBoxCollider.size = new Vector2(1, 1);
            }

            if (broccoliCurrentSpriteCount == 6)
            {
                broccoliSpriteRenderer.size = new Vector2(1, 1);
                broccoliBoxCollider.size = new Vector2(1, 1);
            }

            if (broccoliCurrentSpriteCount <= 7)
            {
                broccoliSpriteRenderer.size = new Vector2(1, 1);
                broccoliBoxCollider.size = new Vector2(1, 1);
            }
        }
    }


    public void PlantCelery()
    {
        SetCeleryPlantedSprite();
        celeryMonthPlanted = seasonManager.season;

        if ((celeryMonthPlanted == celeryBestMonth) || (celeryBestMonth == celeryBestMonth2))
        {
            celeryPlantTiming = 1;
        }

        if ((celeryBestMonth == (celeryBestMonth - 1)) || (celeryBestMonth2 == (celeryBestMonth2 + 1)))
        {
            celeryPlantTiming = .8f;
        }
    }
    public void SetCeleryPlantedSprite()
    {
        newSprite = celerySprites[1];
        celeryCurrentSpriteCount = 1;
        foreach (GameObject celery in celeries)
        {
            celery.GetComponent<SpriteRenderer>().sprite = newSprite;
        }
    }
    public void GrowCelerySprite()
    {
        newSprite = celerySprites[celerySpriteStart];
        celeryCurrentSpriteCount++;
        foreach (GameObject celery in celeries)
        {
            celery.GetComponent<SpriteRenderer>().sprite = newSprite;
            celeryBoxCollider = celery.GetComponent<BoxCollider2D>();

            if (celeryCurrentSpriteCount == 2)
            {
                celerySpriteRenderer.size = new Vector2(1, 1);
                celeryBoxCollider.size = new Vector2(1, 1);
            }

            if (celeryCurrentSpriteCount == 3)
            {
                celerySpriteRenderer.size = new Vector2(1, 1);
                celeryBoxCollider.size = new Vector2(1, 1);
            }

            if (celeryCurrentSpriteCount == 4)
            {
                celerySpriteRenderer.size = new Vector2(1, 1);
                celeryBoxCollider.size = new Vector2(1, 1);
            }

            if (celeryCurrentSpriteCount == 5)
            {
                celerySpriteRenderer.size = new Vector2(1, 1);
                celeryBoxCollider.size = new Vector2(1, 1);
            }

            if (celeryCurrentSpriteCount == 6)
            {
                celerySpriteRenderer.size = new Vector2(1, 1);
                celeryBoxCollider.size = new Vector2(1, 1);
            }

            if (celeryCurrentSpriteCount <= 7)
            {
                celerySpriteRenderer.size = new Vector2(1, 1);
                celeryBoxCollider.size = new Vector2(1, 1);
            }
        }
    }


    public void PlantBrussel()
    {
        SetBrusselPlantedSprite();
        brusselMonthPlanted = seasonManager.season;

        if ((brusselMonthPlanted == brusselBestMonth) || (brusselBestMonth == brusselFallBestMonth))
        {
            brusselPlantTiming = 1;
        }

        if (((brusselMonthPlanted == (brusselBestMonth + 1)) || (brusselMonthPlanted == (brusselBestMonth - 1))) ||
            ((brusselMonthPlanted == (brusselFallBestMonth + 1)) || (brusselMonthPlanted == (brusselFallBestMonth - 1))))
        {
            brusselPlantTiming = .8f;
        }
    }
    public void SetBrusselPlantedSprite()
    {
        newSprite = brusselSprites[1];
        brusselCurrentSpriteCount = 1;
        foreach (GameObject brussel in brussels)
        {
            brussel.GetComponent<SpriteRenderer>().sprite = newSprite;
        }
    }
    public void GrowBrusselSprite()
    {
        newSprite = brusselSprites[brusselSpriteStart];
        brusselCurrentSpriteCount++;
        foreach (GameObject brussel in brussels)
        {
            brussel.GetComponent<SpriteRenderer>().sprite = newSprite;
            brusselBoxCollider = brussel.GetComponent<BoxCollider2D>();

            if (brusselCurrentSpriteCount == 2)
            {
                brusselSpriteRenderer.size = new Vector2(1, 1);
                brusselBoxCollider.size = new Vector2(1, 1);
            }

            if (brusselCurrentSpriteCount == 3)
            {
                brusselSpriteRenderer.size = new Vector2(1, 1);
                brusselBoxCollider.size = new Vector2(1, 1);
            }

            if (brusselCurrentSpriteCount == 4)
            {
                brusselSpriteRenderer.size = new Vector2(1, 1);
                brusselBoxCollider.size = new Vector2(1, 1);
            }

            if (brusselCurrentSpriteCount == 5)
            {
                brusselSpriteRenderer.size = new Vector2(1, 1);
                brusselBoxCollider.size = new Vector2(1, 1);
            }

            if (brusselCurrentSpriteCount == 6)
            {
                brusselSpriteRenderer.size = new Vector2(1, 1);
                brusselBoxCollider.size = new Vector2(1, 1);
            }

            if (brusselCurrentSpriteCount <= 7)
            {
                brusselSpriteRenderer.size = new Vector2(1, 1);
                brusselBoxCollider.size = new Vector2(1, 1);
            }
        }
    }


    public void PlantKale()
    {
        SetKalePlantedSprite();
        kaleMonthPlanted = seasonManager.season;

        if (kaleMonthPlanted == kaleBestMonth)
        {
            kalePlantTiming = 1;
        }

        if ((kaleMonthPlanted == (kaleBestMonth + 1)) || (kaleMonthPlanted == (kaleBestMonth - 1)))
        {
            kalePlantTiming = .8f;
        }
    }
    public void SetKalePlantedSprite()
    {
        newSprite = kaleSprites[1];
        kaleCurrentSpriteCount = 1;
        foreach (GameObject kale in kales)
        {
            kale.GetComponent<SpriteRenderer>().sprite = newSprite;
        }
    }
    public void GrowKaleSprite()
    {
        newSprite = kaleSprites[kaleSpriteStart];
        kaleCurrentSpriteCount++;
        foreach (GameObject kale in kales)
        {
            kale.GetComponent<SpriteRenderer>().sprite = newSprite;
            kaleBoxCollider = kale.GetComponent<BoxCollider2D>();

            if (kaleCurrentSpriteCount == 2)
            {
                kaleSpriteRenderer.size = new Vector2(1, 1);
                kaleBoxCollider.size = new Vector2(1, 1);
            }

            if (kaleCurrentSpriteCount == 3)
            {
                kaleSpriteRenderer.size = new Vector2(1, 1);
                kaleBoxCollider.size = new Vector2(1, 1);
            }

            if (kaleCurrentSpriteCount == 4)
            {
                kaleSpriteRenderer.size = new Vector2(1, 1);
                kaleBoxCollider.size = new Vector2(1, 1);
            }

            if (kaleCurrentSpriteCount <= 5)
            {
                kaleSpriteRenderer.size = new Vector2(1, 1);
                kaleBoxCollider.size = new Vector2(1, 1);
            }
        }
    }


    public void PlantCabbage()
    {
        SetCabbagePlantedSprite();
        cabbageMonthPlanted = seasonManager.season;

        if ((cabbageMonthPlanted == cabbageBestMonth) || (cabbageBestMonth == cabbageFallBestMonth))
        {
            cabbagePlantTiming = 1;
        }

        if (((cabbageMonthPlanted == (cabbageBestMonth + 1)) || (cabbageMonthPlanted == (cabbageBestMonth - 1))) ||
            ((cabbageMonthPlanted == (cabbageFallBestMonth + 1)) || (cabbageMonthPlanted == (cabbageFallBestMonth - 1))))
        {
            cabbagePlantTiming = .8f;
        }
    }
    public void SetCabbagePlantedSprite()
    {
        newSprite = cabbageSprites[1];
        cabbageCurrentSpriteCount = 1;
        foreach (GameObject cabbage in cabbages)
        {
            cabbage.GetComponent<SpriteRenderer>().sprite = newSprite;
        }
    }
    public void GrowCabbageSprite()
    {
        newSprite = cabbageSprites[cabbageSpriteStart];
        cabbageCurrentSpriteCount++;
        foreach (GameObject cabbage in cabbages)
        {
            cabbage.GetComponent<SpriteRenderer>().sprite = newSprite;
            cabbageBoxCollider = cabbage.GetComponent<BoxCollider2D>();

            if (cabbageCurrentSpriteCount == 2)
            {
                cabbageSpriteRenderer.size = new Vector2(1, 1);
                cabbageBoxCollider.size = new Vector2(1, 1);
            }

            if (cabbageCurrentSpriteCount == 3)
            {
                cabbageSpriteRenderer.size = new Vector2(1, 1);
                cabbageBoxCollider.size = new Vector2(1, 1);
            }

            if (cabbageCurrentSpriteCount == 4)
            {
                cabbageSpriteRenderer.size = new Vector2(1, 1);
                cabbageBoxCollider.size = new Vector2(1, 1);
            }

            if (cabbageCurrentSpriteCount == 5)
            {
                cabbageSpriteRenderer.size = new Vector2(1, 1);
                cabbageBoxCollider.size = new Vector2(1, 1);
            }

            if (cabbageCurrentSpriteCount <= 6)
            {
                cabbageSpriteRenderer.size = new Vector2(1, 1);
                cabbageBoxCollider.size = new Vector2(1, 1);
            }
        }
    }


    public void PlantEggplant()
    {
        SetEggplantPlantedSprite();
        eggplantMonthPlanted = seasonManager.season;

        if (eggplantMonthPlanted == eggplantBestMonth)
        {
            eggplantPlantTiming = 1;
        }

        if ((eggplantMonthPlanted == (eggplantBestMonth + 1)) || (eggplantMonthPlanted == (eggplantBestMonth - 1)))
        {
            eggplantPlantTiming = .8f;
        }
    }
    public void SetEggplantPlantedSprite()
    {
        newSprite = eggplantSprites[1];
        eggplantCurrentSpriteCount = 1;
        foreach (GameObject eggplant in eggplants)
        {
            eggplant.GetComponent<SpriteRenderer>().sprite = newSprite;
        }
    }
    public void GrowEggplantSprite()
    {
        newSprite = eggplantSprites[eggplantSpriteStart];
        eggplantCurrentSpriteCount++;
        foreach (GameObject eggplant in eggplants)
        {
            eggplant.GetComponent<SpriteRenderer>().sprite = newSprite;
            eggplantBoxCollider = eggplant.GetComponent<BoxCollider2D>();

            if (eggplantCurrentSpriteCount == 2)
            {
                eggplantSpriteRenderer.size = new Vector2(1, 1);
                eggplantBoxCollider.size = new Vector2(1, 1);
            }

            if (eggplantCurrentSpriteCount == 3)
            {
                eggplantSpriteRenderer.size = new Vector2(1, 1);
                eggplantBoxCollider.size = new Vector2(1, 1);
            }

            if (eggplantCurrentSpriteCount == 4)
            {
                eggplantSpriteRenderer.size = new Vector2(1, 1);
                eggplantBoxCollider.size = new Vector2(1, 1);
            }

            if (eggplantCurrentSpriteCount == 5)
            {
                eggplantSpriteRenderer.size = new Vector2(1, 1);
                eggplantBoxCollider.size = new Vector2(1, 1);
            }

            if (eggplantCurrentSpriteCount <= 6)
            {
                eggplantSpriteRenderer.size = new Vector2(1, 1);
                eggplantBoxCollider.size = new Vector2(1, 1);
            }
        }
    }


    public void PlantMustardGreens()
    {
        SetMustardGreensPlantedSprite();
        mustardGreensMonthPlanted = seasonManager.season;

        if (mustardGreensMonthPlanted == mustardGreensBestMonth)
        {
            mustardGreensPlantTiming = 1;
        }

        if ((mustardGreensMonthPlanted == (mustardGreensBestMonth + 1)) || (mustardGreensMonthPlanted == (mustardGreensBestMonth - 1)))
        {
            mustardGreensPlantTiming = .8f;
        }
    }
    public void SetMustardGreensPlantedSprite()
    {
        newSprite = mustardGreensSprites[1];
        mustardGreensCurrentSpriteCount = 1;
        foreach (GameObject mustardGreen in mustardGreens)
        {
            mustardGreen.GetComponent<SpriteRenderer>().sprite = newSprite;
        }
    }
    public void GrowMustardGreensSprite()
    {
        newSprite = mustardGreensSprites[mustardGreensSpriteStart];
        mustardGreensCurrentSpriteCount++;
        foreach (GameObject mustardGreen in mustardGreens)
        {
            
        }
    }
}

