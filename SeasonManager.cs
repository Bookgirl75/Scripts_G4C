using System;
using TMPro;
using UnityEngine;

public class SeasonManager : MonoBehaviour
{
    public int season = 1;

    public int badThing = 1;
    public int goodThing = 1;

    public float percentGain;
    public float percentLoss;

    public TextMeshProUGUI seasonText;
    public TextMeshProUGUI goodEventText;
    public TextMeshProUGUI badEventText;

    public GameObject peaPacket;
    public GameObject pepperPacket;
    public GameObject carrotPacket;
    public GameObject potatoPacket;
    public GameObject lettucePacket;
    public GameObject cucPacket;
    public GameObject onionPacket;
    public GameObject cornPacket;
    public GameObject squashPacket;
    public GameObject pumpkinPacket;
    public GameObject turnipPacket;
    public GameObject tomatoPacket;
    public GameObject pintoPacket;
    public GameObject greenBeanPacket;
    public GameObject broccoliPacket;
    public GameObject celeryPacket;
    public GameObject brusselPacket;
    public GameObject kalePacket;
    public GameObject cabbagePacket;
    public GameObject eggplantPacket;
    public GameObject mustardGreensPacket;

    public MouseClickController peaMouseClick;
    public MouseClickController pepperMouseClick;
    public MouseClickController potatoMouseClick;
    public MouseClickController lettuceMouseClick;
    public MouseClickController cucMouseClick;
    public MouseClickController carrotMouseClick;
    public MouseClickController tomatoMouseClick;
    public MouseClickController onionMouseClick;
    public MouseClickController pumpkinMouseClick;
    public MouseClickController turnipMouseClick;
    public MouseClickController pintoMouseClick;
    public MouseClickController greenBeanMouseClick;
    public MouseClickController broccoliMouseClick;
    public MouseClickController celeryMouseClick;
    public MouseClickController brusselMouseClick;
    public MouseClickController kaleMouseClick;
    public MouseClickController cabbageMouseClick;
    public MouseClickController squashMouseClick;
    public MouseClickController cornMouseClick;
    public MouseClickController eggplantMouseClick;
    public MouseClickController mustardGreensMouseClick;

    public GameObject eventButton;
    public GameObject plantButtonButton;

    public PlantButton plantButton;
    public GrowthController growthController;
    public Collision4Planting collision4Planting;
    public ScenesManager scenesManager;

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

    public float dataTimer = 3;

    public bool textOn = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        season = 1;

        badThing = (UnityEngine.Random.Range(0, 13));
        goodThing = (UnityEngine.Random.Range(0, 13));

        if (goodThing == badThing)
        {
            badThing = (UnityEngine.Random.Range(0, 13));
            goodThing = (UnityEngine.Random.Range(0, 13));
        }

        CheckGoodAndBad();
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


        if (season == 1)
        {
            seasonText.text = "January";

        }

        if (season == 2)
        {
            seasonText.text = "February";

        }

        if (season == 3)
        {
            seasonText.text = "March";

        }

        if (season == 4)
        {
            seasonText.text = "April";

        }

        if (season == 5)
        {
            seasonText.text = "May";

        }

        if (season == 6)
        {
            seasonText.text = "June";

        }

        if (season == 7)
        {
            seasonText.text = "July";

        }

        if (season == 8)
        {
            seasonText.text = "August";

        }

        if (season == 9)
        {
            seasonText.text = "September";

        }

        if (season == 10)
        {
            seasonText.text = "October";

        }

        if (season == 11)
        {
            seasonText.text = "November";

        }

        if (season == 12)
        {
            seasonText.text = "December";
            
        }

        if (season == 13)
        {
            scenesManager.LoadGameResults();
        }
        
    }

    public void SeasonButtonChange()
    {
        season++;

        ResetText();
        CheckGoodAndBad();

        if ((plantButton.peaPlanted == true) && (peaMouseClick.allPeas == collision4Planting.peasInGarden))
        {
            growthController.peaMonthsCounted = growthController.peaMonthsCounted + 1;
            growthController.peaSpriteStart = growthController.peaMonthsCounted + 1;
            growthController.GrowPeaSprite();
        }

        if ((plantButton.carrotPlanted == true) && (carrotMouseClick.allCarrots == collision4Planting.carrotsInGarden))
        {
            growthController.carrotMonthsCounted = growthController.carrotMonthsCounted + 1;
            growthController.carrotSpriteStart = growthController.carrotMonthsCounted + 1;
            growthController.GrowCarrotSprite();
        }

        if ((plantButton.pepperPlanted == true) && (pepperMouseClick.allPeppers == collision4Planting.peppersInGarden))
        {
            growthController.pepperMonthsCounted = growthController.pepperMonthsCounted + 1;
            growthController.pepperSpriteStart = growthController.pepperMonthsCounted + 1;
            growthController.GrowPepperSprite();
        }

        if ((plantButton.potatoPlanted == true) && (potatoMouseClick.allPotatoes == collision4Planting.potatoesInGarden))
        {
            growthController.potatoMonthsCounted = growthController.potatoMonthsCounted + 1;
            growthController.potatoSpriteStart = growthController.potatoMonthsCounted + 1;
            growthController.GrowPotatoSprite();
        }

        if ((plantButton.lettucePlanted == true) && (lettuceMouseClick.allLettuces == collision4Planting.lettucesInGarden))
        {
            growthController.lettuceMonthsCounted = growthController.lettuceMonthsCounted + 1;
            growthController.lettuceSpriteStart = growthController.lettuceMonthsCounted + 1;
            growthController.GrowLettuceSprite();
        }

        if ((plantButton.cucPlanted == true) && (cucMouseClick.allCucs == collision4Planting.cucsInGarden))
        {
            growthController.cucMonthsCounted = growthController.cucMonthsCounted + 1;
            growthController.cucSpriteStart = growthController.cucMonthsCounted + 1;
            growthController.GrowCucSprite();
        }

        if ((plantButton.onionPlanted == true) && (onionMouseClick.allOnions == collision4Planting.onionsInGarden))
        {
            growthController.onionMonthsCounted = growthController.onionMonthsCounted + 1;
            growthController.onionSpriteStart = growthController.onionMonthsCounted + 1;
            growthController.GrowOnionSprite();
        }

        if ((plantButton.squashPlanted == true) && (squashMouseClick.allSquashes == collision4Planting.squashesInGarden))
        {
            growthController.squashMonthsCounted = growthController.squashMonthsCounted + 1;
            growthController.squashSpriteStart = growthController.squashMonthsCounted + 1;
            growthController.GrowSquashSprite();
        }

        if ((plantButton.cornPlanted == true) && (cornMouseClick.allCorns == collision4Planting.cornsInGarden))
        {
            growthController.cornMonthsCounted = growthController.cornMonthsCounted + 1;
            growthController.cornSpriteStart = growthController.cornMonthsCounted + 1;
            growthController.GrowCornSprite();
        }

        if ((plantButton.pumpkinPlanted == true) && (pumpkinMouseClick.allPumpkins == collision4Planting.pumpkinsInGarden))
        {
            growthController.pumpkinMonthsCounted = growthController.pumpkinMonthsCounted + 1;
            growthController.pumpkinSpriteStart = growthController.pumpkinMonthsCounted + 1;
            growthController.GrowPumpkinSprite();
        }

        if ((plantButton.turnipPlanted == true) && (turnipMouseClick.allTurnips == collision4Planting.turnipsInGarden))
        {
            growthController.turnipMonthsCounted = growthController.turnipMonthsCounted + 1;
            growthController.turnipSpriteStart = growthController.turnipMonthsCounted + 1;
            growthController.GrowTurnipSprite();
        }

        if ((plantButton.tomatoPlanted == true) && (tomatoMouseClick.allTomatoes == collision4Planting.tomatoesInGarden))
        {
            growthController.tomatoMonthsCounted = growthController.tomatoMonthsCounted + 1;
            growthController.tomatoSpriteStart = growthController.tomatoMonthsCounted + 1;
            growthController.GrowTomatoSprite();
        }

        if ((plantButton.pintoPlanted == true) && (pintoMouseClick.allPintos == collision4Planting.pintosInGarden))
        {
            growthController.pintoMonthsCounted = growthController.pintoMonthsCounted + 1;
            growthController.pintoSpriteStart = growthController.pintoMonthsCounted + 1;
            growthController.GrowPintoSprite();
        }

        if ((plantButton.greenBeanPlanted == true) && (greenBeanMouseClick.allGreenBeans == collision4Planting.greenBeansInGarden))
        {
            growthController.greenBeanMonthsCounted = growthController.greenBeanMonthsCounted + 1;
            growthController.greenBeanSpriteStart = growthController.greenBeanMonthsCounted + 1;
            growthController.GrowGreenBeanSprite();
        }


        if ((plantButton.broccoliPlanted == true) && (broccoliMouseClick.allBroccolies == collision4Planting.broccoliesInGarden))
        {
            growthController.broccoliMonthsCounted = growthController.broccoliMonthsCounted + 1;
            growthController.broccoliSpriteStart = growthController.broccoliMonthsCounted + 1;
            growthController.GrowBroccoliSprite();
        }

        if ((plantButton.celeryPlanted == true) && (celeryMouseClick.allCeleries == collision4Planting.celeriesInGarden))
        {
            growthController.celeryMonthsCounted = growthController.celeryMonthsCounted + 1;
            growthController.celerySpriteStart = growthController.celeryMonthsCounted + 1;
            growthController.GrowCelerySprite();
        }

        if ((plantButton.brusselPlanted == true) && (brusselMouseClick.allBrussels == collision4Planting.brusselsInGarden))
        {
            growthController.brusselMonthsCounted = growthController.brusselMonthsCounted + 1;
            growthController.brusselSpriteStart = growthController.brusselMonthsCounted + 1;
            growthController.GrowBrusselSprite();
        }

        if ((plantButton.kalePlanted == true) && (kaleMouseClick.allKales == collision4Planting.kalesInGarden))
        {
            growthController.kaleMonthsCounted = growthController.kaleMonthsCounted + 1;
            growthController.kaleSpriteStart = growthController.kaleMonthsCounted + 1;
            growthController.GrowKaleSprite();
        }

        if ((plantButton.cabbagePlanted == true) && (cabbageMouseClick.allCabbages == collision4Planting.cabbagesInGarden))
        {
            growthController.cabbageMonthsCounted = growthController.cabbageMonthsCounted + 1;
            growthController.cabbageSpriteStart = growthController.cabbageMonthsCounted + 1;
            growthController.GrowCabbageSprite();
        }

        if ((plantButton.eggplantPlanted == true) && (eggplantMouseClick.allEggplants == collision4Planting.eggplantsInGarden))
        {
            growthController.eggplantMonthsCounted = growthController.eggplantMonthsCounted + 1;
            growthController.eggplantSpriteStart = growthController.eggplantMonthsCounted + 1;
            growthController.GrowEggplantSprite();
        }

        if ((plantButton.mustardGreensPlanted == true) && (mustardGreensMouseClick.allMustardGreens == collision4Planting.mustardGreensInGarden))
        {
            growthController.mustardGreensMonthsCounted = growthController.mustardGreensMonthsCounted + 1;
            growthController.mustardGreensSpriteStart = growthController.mustardGreensMonthsCounted + 1;
            growthController.GrowMustardGreensSprite();
        }
    }

    public void CheckGoodAndBad()
    {
        if (season == 1)
        {
            if (goodThing == 1)
            {
                GoodThingJan();
            }

            if (badThing == 1)
            {
                BadThingJan();
            }
        }

        if (season == 2)
        {
            if (goodThing == 2)
            {
                GoodThingFeb();

            }

            if (badThing == 2)
            {
                BadThingFeb();
            }

            
        }

        if (season == 3)
        {
            if (badThing == 2)
            {
                plantButtonButton.transform.gameObject.SetActive(true);
            }
            if (goodThing == 3)
            {
                GoodThingMar();
            }

            if (badThing == 3)
            {
                BadThingMar();
            }

        }

        if (season == 4)
        {
            if (goodThing == 4)
            {
                GoodThingApr();
            }

            if (badThing == 4)
            {
                BadThingApr();
            }

        }

        if (season == 5)
        {
            if (goodThing == 5)
            {
                GoodThingMay();
            }

            if (badThing == 5)
            {
                BadThingMay();
            }

        }

        if (season == 6)
        {
            if (goodThing == 6)
            {
                GoodThingJun();
            }

            if (badThing == 6)
            {
                BadThingJun();
            }

        }

        if (season == 7)
        {
            if (goodThing == 7)
            {
                GoodThingJul();
            }

            if (badThing == 7)
            {
                BadThingJul();
            }
        }

        if (season == 8)
        {
            if (goodThing == 8)
            {
                GoodThingAug();
            }

            if (badThing == 8)
            {
                BadThingAug();
            }

        }

        if (season == 9)
        {
            if (goodThing == 9)
            {
                GoodThingSep();
            }

            if (badThing == 9)
            {
                BadThingSep();
            }

        }

        if (season == 10)
        {
            if (goodThing == 10)
            {
                GoodThingOct();
            }

            if (badThing == 10)
            {
                BadThingOct();
            }

        }

        if (season == 11)
        {
            if (badThing == 10)
            {
                plantButtonButton.transform.gameObject.SetActive(true);
            }
            if (goodThing == 11)
            {
                GoodThingNov();
            }

            if (badThing == 11)
            {
                BadThingNov();
            }

        }

        if (season == 12)
        {
            if (goodThing == 12)
            {
                GoodThingDec();
            }

            if (badThing == 12)
            {
                BadThingDec();
            }

            
        }
    }


    public void GoodThingJan()
    {
        goodEventText.text = "This is a test";
        eventButton.transform.gameObject.SetActive(true);
        badEventText.transform.gameObject.SetActive(true);
        goodEventText.transform.gameObject.SetActive(true);
    }
    public void BadThingJan()
    {
        badEventText.text = "The ground is too frozen to plant early crops. Nothing gets planted this month.";
        plantButtonButton.transform.gameObject.SetActive(false);
        eventButton.transform.gameObject.SetActive(true);
        badEventText.transform.gameObject.SetActive(true);
        goodEventText.transform.gameObject.SetActive(true);
    }


    public void GoodThingFeb()
    {
        goodEventText.text = "This is a test";
        eventButton.transform.gameObject.SetActive(true);
        badEventText.transform.gameObject.SetActive(true);
        goodEventText.transform.gameObject.SetActive(true);
    }
    public void BadThingFeb()
    {
        badEventText.text = "The good weather caused weeds to sprout that choke and kill everything you've planted so far.";
        foreach (GameObject pepper in peppers)
        {
            Destroy(pepper);
        }
        foreach (GameObject pea in peas)
        {
            Destroy(pea);
        }
        foreach (GameObject potato in potatoes)
        {
            Destroy(potato);
        }
        foreach (GameObject lettuce in lettuces)
        {
            Destroy(lettuce);
        }
        foreach (GameObject cuc in cucs)
        {
            Destroy(cuc);
        }
        foreach (GameObject carrot in carrots)
        {
            Destroy(carrot);
        }
        foreach (GameObject tomato in tomatoes)
        {
            Destroy(tomato);
        }
        foreach (GameObject onion in onions)
        {
            Destroy(onion);
        }
        foreach (GameObject squash in squashes)
        {
            Destroy(squash);
        }
        foreach (GameObject corn in corns)
        {
            Destroy(corn);
        }
        foreach (GameObject pumpkin in pumpkins)
        {
            Destroy(pumpkin);
        }
        foreach (GameObject turnip in turnips)
        {
            Destroy(turnip);
        }
        foreach (GameObject pinto in pintos)
        {
            Destroy(pinto);
        }
        foreach (GameObject greenBean in greenBeans)
        {
            Destroy(greenBean);
        }
        foreach (GameObject broccoli in broccolies)
        {
            Destroy(broccoli);
        }
        foreach (GameObject celery in celeries)
        {
            Destroy(celery);
        }
        foreach (GameObject brussel in brussels)
        {
            Destroy(brussel);
        }
        foreach (GameObject kale in kales)
        {
            Destroy(kale);
        }
        foreach (GameObject cabbage in cabbages)
        {
            Destroy(cabbage);
        }
        foreach (GameObject eggplant in eggplants)
        {
            Destroy(eggplant);
        }
        foreach (GameObject mustardGreen in mustardGreens)
        {
            Destroy(mustardGreen);
        }
        eventButton.transform.gameObject.SetActive(true);
        badEventText.transform.gameObject.SetActive(true);
        goodEventText.transform.gameObject.SetActive(true);
    }


    public void GoodThingMar()
    {
        goodEventText.text = "When cleaning out the garden shed, you find an old bag of fertilizer. All plants increase production by 30%";
        percentGain = .3f;
        eventButton.transform.gameObject.SetActive(true);
        badEventText.transform.gameObject.SetActive(true);
        goodEventText.transform.gameObject.SetActive(true);
    }
    public void BadThingMar()
    {
        badEventText.text = "This is a test";
        eventButton.transform.gameObject.SetActive(true);
        badEventText.transform.gameObject.SetActive(true);
        goodEventText.transform.gameObject.SetActive(true);
    }


    public void GoodThingApr()
    {
        goodEventText.text = "This is a test";
        eventButton.transform.gameObject.SetActive(true);
        badEventText.transform.gameObject.SetActive(true);
        goodEventText.transform.gameObject.SetActive(true);
    }
    public void BadThingApr()
    {
        badEventText.text = "This is a test";
        eventButton.transform.gameObject.SetActive(true);
        badEventText.transform.gameObject.SetActive(true);
        goodEventText.transform.gameObject.SetActive(true);
    }


    public void GoodThingMay()
    {
        goodEventText.text = "A local carpenter hears about your garden & makes a few bee boxes that " +
            "soon attracts a colony. Total food grown increases by jklafjkjfadhds";
        eventButton.transform.gameObject.SetActive(true);
        badEventText.transform.gameObject.SetActive(true);
        goodEventText.transform.gameObject.SetActive(true);
    }
    public void BadThingMay()
    {
        badEventText.text = "Naughty squirrels decide the garden is for them, and eat jifdakjdsafkjjdfks";
        eventButton.transform.gameObject.SetActive(true);
        badEventText.transform.gameObject.SetActive(true);
        goodEventText.transform.gameObject.SetActive(true);
    }


    public void GoodThingJun()
    {
        goodEventText.text = "A neighbor donates pollinator flowers that attract bees and butterflies, increasing plant polination by 5%";
        percentGain = .05f;
        eventButton.transform.gameObject.SetActive(true);
        badEventText.transform.gameObject.SetActive(true);
        goodEventText.transform.gameObject.SetActive(true);
    }
    public void BadThingJun()
    {
        badEventText.text = "The bugs are plentiful this year. All plants decrease production by 40%";
        percentLoss = .4f;
        eventButton.transform.gameObject.SetActive(true);
        badEventText.transform.gameObject.SetActive(true);
        goodEventText.transform.gameObject.SetActive(true);
    }


    public void GoodThingJul()
    {
        goodEventText.text = "A suprise rainfall increase plant production by 25%.";
        percentGain = .25f;
        eventButton.transform.gameObject.SetActive(true);
        badEventText.transform.gameObject.SetActive(true);
        goodEventText.transform.gameObject.SetActive(true);

    }
    public void BadThingJul()
    {
        badEventText.text = "A lack of rainfall causes a drought that kills all sensitive plants and decreases harvest by 25%";
        percentLoss = .25f;
        eventButton.transform.gameObject.SetActive(true);
        badEventText.transform.gameObject.SetActive(true);
        goodEventText.transform.gameObject.SetActive(true);
    }


    public void GoodThingAug()
    {
        goodEventText.text = "This is a test";
        eventButton.transform.gameObject.SetActive(true);
        badEventText.transform.gameObject.SetActive(true);
        goodEventText.transform.gameObject.SetActive(true);
    }
    public void BadThingAug()
    {
        badEventText.text = "Temperatures spike due to climate change. All plants that can't survive at over 90 degrees die.";
        foreach (GameObject celery in celeries)
        {
            Destroy(celery);
        }
        foreach (GameObject tomato in tomatoes)
        {
            Destroy(tomato);
        }
        foreach (GameObject squash in squashes)
        {
            Destroy(squash);
        }
        foreach (GameObject cuc in cucs)
        {
            Destroy(cuc);
        }
        foreach (GameObject broccoli in broccolies)
        {
            Destroy(broccoli);
        }
        foreach (GameObject lettuce in lettuces)
        {
            Destroy(lettuce);
        }
        foreach (GameObject carrot in carrots)
        {
            Destroy(carrot);
        }
        eventButton.transform.gameObject.SetActive(true);
        badEventText.transform.gameObject.SetActive(true);
        goodEventText.transform.gameObject.SetActive(true);
    }


    public void GoodThingSep()
    {
        goodEventText.text = "This is a test";
        eventButton.transform.gameObject.SetActive(true);
        badEventText.transform.gameObject.SetActive(true);
        goodEventText.transform.gameObject.SetActive(true);
    }
    public void BadThingSep()
    {
        badEventText.text = "A group of kids set off some old fireworks they found. Things go wrong, a fire starts, and everything burns down.";
        foreach (GameObject pepper in peppers)
        {
            Destroy(pepper);
        }
        foreach (GameObject pea in peas)
        {
            Destroy(pea);
        }
        foreach (GameObject potato in potatoes)
        {
            Destroy(potato);
        }
        foreach (GameObject lettuce in lettuces)
        {
            Destroy(lettuce);
        }
        foreach (GameObject cuc in cucs)
        {
            Destroy(cuc);
        }
        foreach (GameObject carrot in carrots)
        {
            Destroy(carrot);
        }
        foreach (GameObject tomato in tomatoes)
        {
            Destroy(tomato);
        }
        foreach (GameObject onion in onions)
        {
            Destroy(onion);
        }
        foreach (GameObject squash in squashes)
        {
            Destroy(squash);
        }
        foreach (GameObject corn in corns)
        {
            Destroy(corn);
        }
        foreach (GameObject pumpkin in pumpkins)
        {
            Destroy(pumpkin);
        }
        foreach (GameObject turnip in turnips)
        {
            Destroy(turnip);
        }
        foreach (GameObject pinto in pintos)
        {
            Destroy(pinto);
        }
        foreach (GameObject greenBean in greenBeans)
        {
            Destroy(greenBean);
        }
        foreach (GameObject broccoli in broccolies)
        {
            Destroy(broccoli);
        }
        foreach (GameObject celery in celeries)
        {
            Destroy(celery);
        }
        foreach (GameObject brussel in brussels)
        {
            Destroy(brussel);
        }
        foreach (GameObject kale in kales)
        {
            Destroy(kale);
        }
        foreach (GameObject cabbage in cabbages)
        {
            Destroy(cabbage);
        }
        foreach (GameObject eggplant in eggplants)
        {
            Destroy(eggplant);
        }
        foreach (GameObject mustardGreen in mustardGreens)
        {
            Destroy(mustardGreen);
        }

        Destroy(peaPacket);
        Destroy(pepperPacket);
        Destroy(potatoPacket);
        Destroy(lettucePacket);
        Destroy(cucPacket);
        Destroy(carrotPacket);
        Destroy(tomatoPacket);
        Destroy(onionPacket);
        Destroy(squashPacket);
        Destroy(cornPacket);
        Destroy(pumpkinPacket);
        Destroy(turnipPacket);
        Destroy(pintoPacket);
        Destroy(greenBeanPacket);
        Destroy(broccoliPacket);
        Destroy(celeryPacket);
        Destroy(brusselPacket);
        Destroy(kalePacket);
        Destroy(cabbagePacket);
        Destroy(eggplantPacket);
        Destroy(mustardGreensPacket);

        eventButton.transform.gameObject.SetActive(true);
        badEventText.transform.gameObject.SetActive(true);
        goodEventText.transform.gameObject.SetActive(true);
    }


    public void GoodThingOct()
    {
        goodEventText.text = "";
        eventButton.transform.gameObject.SetActive(true);
        badEventText.transform.gameObject.SetActive(true);
        goodEventText.transform.gameObject.SetActive(true);
    }
    public void BadThingOct()
    {
        badEventText.text = "Ash from forest fires in the North prevent you from planting and harvesting this month.";
        plantButtonButton.transform.gameObject.SetActive(false);
        eventButton.transform.gameObject.SetActive(true);
        badEventText.transform.gameObject.SetActive(true);
        goodEventText.transform.gameObject.SetActive(true);
    }


    public void GoodThingNov()
    {
        goodEventText.text = "This is a test";
        eventButton.transform.gameObject.SetActive(true);
        badEventText.transform.gameObject.SetActive(true);
        goodEventText.transform.gameObject.SetActive(true);
    }
    public void BadThingNov()
    {
        badEventText.text = "Rainfalls begin in earnest, causing flooding and mudslides. All crops in the garden die.";

        foreach (GameObject pepper in peppers)
        {
            Destroy(pepper);
        }
        foreach (GameObject pea in peas)
        {
            Destroy(pea);
        }
        foreach (GameObject potato in potatoes)
        {
            Destroy(potato);
        }
        foreach (GameObject lettuce in lettuces)
        {
            Destroy(lettuce);
        }
        foreach (GameObject cuc in cucs)
        {
            Destroy(cuc);
        }
        foreach (GameObject carrot in carrots)
        {
            Destroy(carrot);
        }
        foreach (GameObject tomato in tomatoes)
        {
            Destroy(tomato);
        }
        foreach (GameObject onion in onions)
        {
            Destroy(onion);
        }
        foreach (GameObject squash in squashes)
        {
            Destroy(squash);
        }
        foreach (GameObject corn in corns)
        {
            Destroy(corn);
        }
        foreach (GameObject pumpkin in pumpkins)
        {
            Destroy(pumpkin);
        }
        foreach (GameObject turnip in turnips)
        {
            Destroy(turnip);
        }
        foreach (GameObject pinto in pintos)
        {
            Destroy(pinto);
        }
        foreach (GameObject greenBean in greenBeans)
        {
            Destroy(greenBean);
        }
        foreach (GameObject broccoli in broccolies)
        {
            Destroy(broccoli);
        }
        foreach (GameObject celery in celeries)
        {
            Destroy(celery);
        }
        foreach (GameObject brussel in brussels)
        {
            Destroy(brussel);
        }
        foreach (GameObject kale in kales)
        {
            Destroy(kale);
        }
        foreach (GameObject cabbage in cabbages)
        {
            Destroy(cabbage);
        }
        foreach (GameObject eggplant in eggplants)
        {
            Destroy(eggplant);
        }
        foreach (GameObject mustardGreen in mustardGreens)
        {
            Destroy(mustardGreen);
        }

        eventButton.transform.gameObject.SetActive(true);
        badEventText.transform.gameObject.SetActive(true);
        goodEventText.transform.gameObject.SetActive(true);
    }


    public void GoodThingDec()
    {
        goodEventText.text = "This is a test";
        eventButton.transform.gameObject.SetActive(true);
        badEventText.transform.gameObject.SetActive(true);
        goodEventText.transform.gameObject.SetActive(true);
    }
    public void BadThingDec()
    {
        badEventText.text = "A suprise freeze kills all late harvest plants.";
        eventButton.transform.gameObject.SetActive(true);
        badEventText.transform.gameObject.SetActive(true);
        goodEventText.transform.gameObject.SetActive(true);

        foreach (GameObject pepper in peppers)
        {
            Destroy(pepper);
        }
        foreach (GameObject pea in peas)
        {
            Destroy(pea);
        }
        foreach (GameObject potato in potatoes)
        {
            Destroy(potato);
        }
        foreach (GameObject lettuce in lettuces)
        {
            Destroy(lettuce);
        }
        foreach (GameObject cuc in cucs)
        {
            Destroy(cuc);
        }
        foreach (GameObject carrot in carrots)
        {
            Destroy(carrot);
        }
        foreach (GameObject tomato in tomatoes)
        {
            Destroy(tomato);
        }
        foreach (GameObject onion in onions)
        {
            Destroy(onion);
        }
        foreach (GameObject squash in squashes)
        {
            Destroy(squash);
        }
        foreach (GameObject corn in corns)
        {
            Destroy(corn);
        }
        foreach (GameObject pumpkin in pumpkins)
        {
            Destroy(pumpkin);
        }
        foreach (GameObject turnip in turnips)
        {
            Destroy(turnip);
        }
        foreach (GameObject pinto in pintos)
        {
            Destroy(pinto);
        }
        foreach (GameObject greenBean in greenBeans)
        {
            Destroy(greenBean);
        }
        foreach (GameObject broccoli in broccolies)
        {
            Destroy(broccoli);
        }
        foreach (GameObject celery in celeries)
        {
            Destroy(celery);
        }
        foreach (GameObject brussel in brussels)
        {
            Destroy(brussel);
        }
        foreach (GameObject kale in kales)
        {
            Destroy(kale);
        }
        foreach (GameObject cabbage in cabbages)
        {
            Destroy(cabbage);
        }
        foreach (GameObject eggplant in eggplants)
        {
            Destroy(eggplant);
        }
        foreach (GameObject mustardGreen in mustardGreens)
        {
            Destroy(mustardGreen);
        }
    }

    public void ResetText()
    {
        badEventText.text = "";
        goodEventText.text = "";
        badEventText.transform.gameObject.SetActive(false);
        goodEventText.transform.gameObject.SetActive(false);

        ResetButton();
    }

    public void ResetButton()
    {
        eventButton.transform.gameObject.SetActive(false);
    }


    
}
