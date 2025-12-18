using System;
using TMPro;
using UnityEngine;

public class SeasonManager : MonoBehaviour
{
    public int season = 1;

    public int badThing;
    public int goodThing;

    public float amountAfterLoss;

    public TextMeshProUGUI seasonText;
    public TextMeshProUGUI goodEventText;
    public TextMeshProUGUI badEventText;

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

    public float dataTimer = 3;

    public bool textOn = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        season = 1;

        badThing = (UnityEngine.Random.Range(0, 13));
        goodThing = (UnityEngine.Random.Range(0, 13));
    }

    // Update is called once per frame
    void Update()
    {

        if (season == 1)
        {
            seasonText.text = "January";

            if (goodThing == 1)
            {
                GoodThingJan();
            }

            if (badThing == 1)
            {
                BadThingJan();
            }

            else
            {
                ResetText();
            }
        }

        if (season == 2)
        {
            seasonText.text = "February";

            if (goodThing == 2)
            {
                GoodThingFeb();
            }

            if (badThing == 2)
            {
                BadThingFeb();
            }

            else
            {
                ResetText();
            }
        }

        if (season == 3)
        {
            seasonText.text = "March";

            if (goodThing == 3)
            {
                GoodThingMar();
            }

            if (badThing == 3)
            {
                BadThingMar();
            }

            else
            {
                ResetText();
            }
        }

        if (season == 4)
        {
            seasonText.text = "April";

            if (goodThing == 4)
            {
                GoodThingApr();
            }

            if (badThing == 4)
            {
                BadThingApr();
            }

            else
            {
                ResetText();
            }
        }

        if (season == 5)
        {
            seasonText.text = "May";

            if (goodThing == 5)
            {
                GoodThingMay();
            }

            if (badThing == 5)
            {
                BadThingMay();
            }

            else
            {
                ResetText();
            }
        }

        if (season == 6)
        {
            seasonText.text = "June";

            if (goodThing == 6)
            {
                GoodThingJun();
            }

            if (badThing == 6)
            {
                BadThingJun();
            }

            else
            {
                ResetText();
            }
        }

        if (season == 7)
        {
            seasonText.text = "July";

            if (goodThing == 7)
            {
                GoodThingJul();
            }

            if (badThing == 7)
            {
                BadThingJul();
            }

            else
            {
                ResetText();
            }
        }

        if (season == 8)
        {
            seasonText.text = "August";

            if (goodThing == 8)
            {
                GoodThingAug();
            }

            if (badThing == 8)
            {
                BadThingAug();
            }

            else
            {
                ResetText();
            }
        }

        if (season == 9)
        {
            seasonText.text = "September";

            if (goodThing == 9)
            {
                GoodThingSep();
            }

            if (badThing == 9)
            {
                BadThingSep();
            }

            else
            {
                ResetText();
            }
        }

        if (season == 10)
        {
            seasonText.text = "October";

            if (goodThing == 10)
            {
                GoodThingOct();
            }

            if (badThing == 10)
            {
                BadThingOct();
            }

            else
            {
                ResetText();
            }
        }

        if (season == 11)
        {
            seasonText.text = "November";

            if (goodThing == 11)
            {
                GoodThingNov();
            }

            if (badThing == 11)
            {
                BadThingNov();
            }

            else
            {
                ResetText();
            }
        }

        if (season == 12)
        {
            seasonText.text = "December";

            if (goodThing == 12)
            {
                GoodThingDec();
            }

            if (badThing == 12)
            {
                BadThingDec();
            }

            else
            {
                ResetText();
            }
        }

        if (season == 13)
        {
            scenesManager.LoadGameResults();
        }

        
    }

    public void GoodThingJan()
    {
        
    }
    public void BadThingJan()
    {
    }


    public void GoodThingFeb()
    {
    }
    public void BadThingFeb()
    {
        badEventText.text = "The ground is too frozen to plant early crops. Nothing gets planted this month.";
    }


    public void GoodThingMar()
    {
    }
    public void BadThingMar()
    {
    }


    public void GoodThingApr()
    {
    }
    public void BadThingApr()
    {
    }


    public void GoodThingMay()
    {
    }
    public void BadThingMay()
    {
        badEventText.text = "A family of deer sneak under the fence and eat half of everything planted before you can stop them.";
        amountAfterLoss = collision4Planting.plantsInGarden * .5f;
    }


    public void GoodThingJun()
    {
    }
    public void BadThingJun()
    {
        badEventText.text = "The bugs are plentiful this year. All plants decrease production by 40%";
    }


    public void GoodThingJul()
    {
        goodEventText.text = "A suprise rainfall increase plant production by 25%.";

    }
    public void BadThingJul()
    {
        badEventText.text = "A lack of rainfall causes a drought that kills all sensitive plants and decreases harvest";
    }


    public void GoodThingAug()
    {
    }
    public void BadThingAug()
    {
        badEventText.text = "Temperatures spike due to climate change. All plants that can't survive at over 80 degrees die.";
        foreach (GameObject celery in celeries)
        {
            Destroy(gameObject);
        }
    }


    public void GoodThingSep()
    {
    }
    public void BadThingSep()
    {
        badEventText.text = "A lightning strike causes the dry brush to ignite, starting a forest fire. All crops in the garden and any remaining seed packets are destroyed.";
        amountAfterLoss = 0;

        foreach (GameObject pepper in peppers)
        {
            Destroy(gameObject);
        }
        foreach (GameObject pea in peas)
        {
            Destroy(gameObject);
        }
        foreach (GameObject potato in potatoes)
        {
            Destroy(gameObject);
        }
        foreach (GameObject lettuce in lettuces)
        {
            Destroy(gameObject);
        }
        foreach (GameObject cuc in cucs)
        {
            Destroy(gameObject);
        }
        foreach (GameObject carrot in carrots)
        {
            Destroy(gameObject);
        }
        foreach (GameObject tomato in tomatoes)
        {
            Destroy(gameObject);
        }
        foreach (GameObject onion in onions)
        {
            Destroy(gameObject);
        }
        foreach (GameObject squash in squashes)
        {
            Destroy(gameObject);
        }
        foreach (GameObject celery in celeries)
        {
            Destroy(gameObject);
        }
        foreach (GameObject celery in celeries)
        {
            Destroy(gameObject);
        }
        foreach (GameObject celery in celeries)
        {
            Destroy(gameObject);
        }
    }


    public void GoodThingOct()
    {
    }
    public void BadThingOct()
    {
    }


    public void GoodThingNov()
    {
    }
    public void BadThingNov()
    {
        badEventText.text = "Rainfalls begin in earnest, causing flooding and mudslides. All crops in the garden die.";
        amountAfterLoss = 0;
    }


    public void GoodThingDec()
    {
    }
    public void BadThingDec()
    {
        badEventText.text = "A suprise freeze kills all late harvest plants.";
    }

    public void ResetText()
    {
        badEventText.text = "";
        goodEventText.text = "";
    }


    public void CountDownTimer()
    {
        dataTimer -= Time.deltaTime;

        if (dataTimer <= 0)
        {
            ResetText();
            dataTimer = 3;
        }
    }



    public void SeasonButtonChange()
    {
        season++;

        if (plantButton.peaPlanted == true)
        {
            growthController.peaMonthsCounted = growthController.peaMonthsCounted + 1;
            growthController.peaSpriteStart = growthController.peaMonthsCounted + 1;
            growthController.GrowPeaSprite();
        }

        if (plantButton.carrotPlanted == true)
        {
            growthController.carrotMonthsCounted = growthController.carrotMonthsCounted + 1;
            growthController.carrotSpriteStart = growthController.carrotMonthsCounted + 1;
            growthController.GrowCarrotSprite();
        }

        if (plantButton.pepperPlanted == true)
        {
            growthController.pepperMonthsCounted = growthController.pepperMonthsCounted + 1;
            growthController.pepperSpriteStart = growthController.pepperMonthsCounted + 1;
            growthController.GrowPepperSprite();
        }

        if (plantButton.potatoPlanted == true)
        {
            growthController.potatoMonthsCounted = growthController.potatoMonthsCounted + 1;
            growthController.potatoSpriteStart = growthController.potatoMonthsCounted + 1;
            growthController.GrowPotatoSprite();
        }

        if (plantButton.lettucePlanted == true)
        {
            growthController.lettuceMonthsCounted = growthController.lettuceMonthsCounted + 1;
            growthController.lettuceSpriteStart = growthController.lettuceMonthsCounted + 1;
            growthController.GrowLettuceSprite();
        }

        if (plantButton.cucPlanted == true)
        {
            growthController.cucMonthsCounted = growthController.cucMonthsCounted + 1;
            growthController.cucSpriteStart = growthController.cucMonthsCounted + 1;
            growthController.GrowCucSprite();
        }

        if (plantButton.onionPlanted == true)
        {
            growthController.onionMonthsCounted = growthController.onionMonthsCounted + 1;
            growthController.onionSpriteStart = growthController.onionMonthsCounted + 1;
            growthController.GrowOnionSprite();
        }

        if (plantButton.squashPlanted == true)
        {
            growthController.squashMonthsCounted = growthController.squashMonthsCounted + 1;
            growthController.squashSpriteStart = growthController.squashMonthsCounted + 1;
            growthController.GrowSquashSprite();
        }

        if (plantButton.cornPlanted == true)
        {
            growthController.cornMonthsCounted = growthController.cornMonthsCounted + 1;
            growthController.cornSpriteStart = growthController.cornMonthsCounted + 1;
            growthController.GrowCornSprite();
        }

        if (plantButton.pumpkinPlanted == true)
        {
            growthController.pumpkinMonthsCounted = growthController.pumpkinMonthsCounted + 1;
            growthController.pumpkinSpriteStart = growthController.pumpkinMonthsCounted + 1;
            growthController.GrowPumpkinSprite();
        }

        if (plantButton.turnipPlanted == true)
        {
            growthController.turnipMonthsCounted = growthController.turnipMonthsCounted + 1;
            growthController.turnipSpriteStart = growthController.turnipMonthsCounted + 1;
            growthController.GrowTurnipSprite();
        }

        if (plantButton.tomatoPlanted == true)
        {
            growthController.tomatoMonthsCounted = growthController.tomatoMonthsCounted + 1;
            growthController.tomatoSpriteStart = growthController.tomatoMonthsCounted + 1;
            growthController.GrowTomatoSprite();
        }

        if (plantButton.pintoPlanted == true)
        {
            growthController.pintoMonthsCounted = growthController.pintoMonthsCounted + 1;
            growthController.pintoSpriteStart = growthController.pintoMonthsCounted + 1;
            growthController.GrowPintoSprite();
        }

        if (plantButton.greenBeanPlanted == true)
        {
            growthController.greenBeanMonthsCounted = growthController.greenBeanMonthsCounted + 1;
            growthController.greenBeanSpriteStart = growthController.greenBeanMonthsCounted + 1;
            growthController.GrowGreenBeanSprite();
        }


        if (plantButton.broccoliPlanted == true)
        {
            growthController.broccoliMonthsCounted = growthController.broccoliMonthsCounted + 1;
            growthController.broccoliSpriteStart = growthController.broccoliMonthsCounted + 1;
            growthController.GrowBroccoliSprite();
        }

        if (plantButton.celeryPlanted == true)
        {
            growthController.celeryMonthsCounted = growthController.celeryMonthsCounted + 1;
            growthController.celerySpriteStart = growthController.celeryMonthsCounted + 1;
            growthController.GrowCelerySprite();
        }

        if (plantButton.brusselPlanted == true)
        {
            growthController.brusselMonthsCounted = growthController.brusselMonthsCounted + 1;
            growthController.brusselSpriteStart = growthController.brusselMonthsCounted + 1;
            growthController.GrowBrusselSprite();
        }

        if (plantButton.kalePlanted == true)
        {
            growthController.kaleMonthsCounted = growthController.kaleMonthsCounted + 1;
            growthController.kaleSpriteStart = growthController.kaleMonthsCounted + 1;
            growthController.GrowKaleSprite();
        }

        if (plantButton.cabbagePlanted == true)
        {
            growthController.cabbageMonthsCounted = growthController.cabbageMonthsCounted + 1;
            growthController.cabbageSpriteStart = growthController.cabbageMonthsCounted + 1;
            growthController.GrowCabbageSprite();
        }
    }
}
