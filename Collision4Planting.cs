using UnityEngine;

public class Collision4Planting : MonoBehaviour
{
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

    public bool peasReady = false;
    public bool carrotsReady = false;
    public bool peppersReady = false;
    public bool potatoesReady = false;
    public bool lettucesReady = false;
    public bool cucsReady = false;
    public bool onionsReady = false;
    public bool squashesReady = false;
    public bool cornsReady = false;
    public bool pumpkinsReady = false;
    public bool turnipsReady = false;
    public bool tomatoesReady = false;
    public bool pintosReady = false;
    public bool greenBeansReady = false;
    public bool broccoliesReady = false;
    public bool celeriesReady = false;
    public bool brusselsReady = false;
    public bool kalesReady = false;
    public bool cabbagesReady = false;

    public float plantsInGarden = 0;

    public int peasInGarden = 0;
    public int carrotsInGarden = 0;
    public int peppersInGarden = 0;
    public int potatoesInGarden = 0;
    public int lettucesInGarden = 0;
    public int cucsInGarden = 0;
    public int onionsInGarden = 0;
    public int squashesInGarden = 0;
    public int cornsInGarden = 0;
    public int pumpkinsInGarden = 0;
    public int turnipsInGarden = 0;
    public int tomatoesInGarden = 0;
    public int pintosInGarden = 0;
    public int greenBeansInGarden = 0;
    public int broccoliesInGarden = 0;
    public int celeriesInGarden = 0;
    public int brusselsInGarden = 0;
    public int kalesInGarden = 0;
    public int cabbagesInGarden = 0;

   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        plantsInGarden++;

        if (collision.gameObject.CompareTag("pea"))
        {
            peasInGarden++;

            if (peaMouseClick.allPeas == peasInGarden)
            {
                peasReady = true;
            }
        }

        if (collision.gameObject.CompareTag("carrot"))
        {
            carrotsInGarden++;

            if (carrotMouseClick.allCarrots == carrotsInGarden)
            {
                carrotsReady = true;
            }
        }

        if (collision.gameObject.CompareTag("bellPepper"))
        {
            peppersInGarden++;

            if (pepperMouseClick.allPeppers == peppersInGarden)
            {
                peppersReady = true;
            }
        }

        if (collision.gameObject.CompareTag("potato"))
        {
            potatoesInGarden++;

            if (potatoMouseClick.allPotatoes == potatoesInGarden)
            {
                potatoesReady = true;
            }
        }

        if (collision.gameObject.CompareTag("lettuce"))
        {
            lettucesInGarden++;

            if (lettuceMouseClick.allLettuces == lettucesInGarden)
            {
                lettucesReady = true;
            }
        }

        if (collision.gameObject.CompareTag("cucumber"))
        {
            cucsInGarden++;
            if (cucMouseClick.allCucs == cucsInGarden)
            {
                cucsReady = true;
            }
        }

        if (collision.gameObject.CompareTag("onion"))
        {
            onionsInGarden++;
            if (onionMouseClick.allOnions == onionsInGarden)
            {
                onionsReady = true;
            }
        }

        if (collision.gameObject.CompareTag("squash"))
        {
            squashesInGarden++;
            if (squashMouseClick.allSquashes == squashesInGarden)
            {
                squashesReady = true;
            }
        }

        if (collision.gameObject.CompareTag("corn"))
        {
            cornsInGarden++;
            if (cornMouseClick.allCorns == cornsInGarden)
            {
                cornsReady = true;
            }
        }

        if (collision.gameObject.CompareTag("pumpkin"))
        {
            pumpkinsInGarden++;
            if (pumpkinMouseClick.allPumpkins == pumpkinsInGarden)
            {
                pumpkinsReady = true;
            }
        }

        if (collision.gameObject.CompareTag("turnip"))
        {
            turnipsInGarden++;
            if (turnipMouseClick.allTurnips == turnipsInGarden)
            {
                turnipsReady = true;
            }
        }

        if (collision.gameObject.CompareTag("tomato"))
        {
            tomatoesInGarden++;
            if (tomatoMouseClick.allTomatoes == tomatoesInGarden)
            {
                tomatoesReady = true;
            }
        }

        if (collision.gameObject.CompareTag("pintoBean"))
        {
            pintosInGarden++;
            if (pintoMouseClick.allPintos == pintosInGarden)
            {
                pintosReady = true;
            }
        }

        if (collision.gameObject.CompareTag("greenBean"))
        {
            greenBeansInGarden++;
            if (greenBeanMouseClick.allGreenBeans == greenBeansInGarden)
            {
                greenBeansReady = true;
            }
        }

        if (collision.gameObject.CompareTag("broccoli"))
        {
            broccoliesInGarden++;
            if (broccoliMouseClick.allBroccolies == broccoliesInGarden)
            {
                broccoliesReady = true;
            }
        }

        if (collision.gameObject.CompareTag("celery"))
        {
            celeriesInGarden++;
            if (celeryMouseClick.allCeleries == celeriesInGarden)
            {
                celeriesReady = true;
            }
        }

        if (collision.gameObject.CompareTag("brusselSprout"))
        {
            brusselsInGarden++;
            if (brusselMouseClick.allBrussels == brusselsInGarden)
            {
                brusselsReady = true;
            }
        }

        if (collision.gameObject.CompareTag("kale"))
        {
            kalesInGarden++;
            if (kaleMouseClick.allKales == kalesInGarden)
            {
                kalesReady = true;
            }
        }

        if (collision.gameObject.CompareTag("cabbage"))
        {
            cabbagesInGarden++;
            if (cabbageMouseClick.allCabbages == cabbagesInGarden)
            {
                cabbagesReady = true;
            }
        }
    }


    public void OnTriggerExit2D(Collider2D collision)
    {
        plantsInGarden--;

        if (collision.gameObject.CompareTag("pea"))
        {
            peasInGarden--;
            peasReady = false;
        }

        if (collision.gameObject.CompareTag("carrot"))
        {
            carrotsInGarden--;
            carrotsReady = false;
        }

        if (collision.gameObject.CompareTag("bellPepper"))
        {
            peppersInGarden--;
            peppersReady = false;
        }

        if (collision.gameObject.CompareTag("potato"))
        {
            potatoesInGarden--;
            potatoesReady = false;
        }

        if (collision.gameObject.CompareTag("lettuce"))
        {
            lettucesInGarden--;
            lettucesReady = false;
        }

        if (collision.gameObject.CompareTag("cucumber"))
        {
            cucsInGarden--;
            cucsReady = false;
        }

        if (collision.gameObject.CompareTag("onion"))
        {
            onionsInGarden--;
            onionsReady = false;
        }

        if (collision.gameObject.CompareTag("squash"))
        {
            squashesInGarden--;
            squashesReady = false;
        }

        if (collision.gameObject.CompareTag("corn"))
        {
            cornsInGarden--;
            cornsReady = false;
        }

        if (collision.gameObject.CompareTag("pumpkin"))
        {
            pumpkinsInGarden--;
            pumpkinsReady = false;
        }

        if (collision.gameObject.CompareTag("turnip"))
        {
            turnipsInGarden--;
            turnipsReady = false;
        }

        if (collision.gameObject.CompareTag("tomato"))
        {
            tomatoesInGarden--;
            tomatoesReady = false;
        }

        if (collision.gameObject.CompareTag("pintoBean"))
        {
            pintosInGarden--;
            pintosReady = false;
        }

        if (collision.gameObject.CompareTag("greenBean"))
        {
            greenBeansInGarden--;
            greenBeansReady = false;
        }

        if (collision.gameObject.CompareTag("broccoli"))
        {
            broccoliesInGarden--;
            broccoliesReady = false;
        }

        if (collision.gameObject.CompareTag("celery"))
        {
            celeriesInGarden--;
            celeriesReady = false;
        }

        if (collision.gameObject.CompareTag("brusselSprout"))
        {
            brusselsInGarden--;
            brusselsReady = false;
        }

        if (collision.gameObject.CompareTag("kale"))
        {
            kalesInGarden--;
            kalesReady = false;
        }

        if (collision.gameObject.CompareTag("cabbage"))
        {
            cabbagesInGarden--;
            cabbagesReady = false;
        }
    }
}
