using UnityEngine;

public class Collision4Planting : MonoBehaviour
{
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
            peasReady = true;
            peasInGarden++;
        }

        if (collision.gameObject.CompareTag("carrot"))
        {
            carrotsReady = true;
            carrotsInGarden++;
        }

        if (collision.gameObject.CompareTag("bellPepper"))
        {
            peppersReady = true;
            peppersInGarden++;
        }

        if (collision.gameObject.CompareTag("potato"))
        {
            potatoesReady = true;
            potatoesInGarden++;
        }

        if (collision.gameObject.CompareTag("lettuce"))
        {
            lettucesReady = true;
            lettucesInGarden++;
        }

        if (collision.gameObject.CompareTag("cucumber"))
        {
            cucsReady = true;
            cucsInGarden++;
        }

        if (collision.gameObject.CompareTag("onion"))
        {
            onionsReady = true;
            onionsInGarden++;
        }

        if (collision.gameObject.CompareTag("squash"))
        {
            squashesReady = true;
            squashesInGarden++;
        }

        if (collision.gameObject.CompareTag("corn"))
        {
            cornsReady = true;
            cornsInGarden++;
        }

        if (collision.gameObject.CompareTag("pumpkin"))
        {
            pumpkinsReady = true;
            pumpkinsInGarden++;
        }

        if (collision.gameObject.CompareTag("turnip"))
        {
            turnipsReady = true;
            turnipsInGarden++;
        }

        if (collision.gameObject.CompareTag("tomato"))
        {
            tomatoesReady = true;
            tomatoesInGarden++;
        }

        if (collision.gameObject.CompareTag("pintoBean"))
        {
            pintosReady = true;
            pintosInGarden++;
        }

        if (collision.gameObject.CompareTag("greenBean"))
        {
            greenBeansReady = true;
            greenBeansInGarden++;
        }

        if (collision.gameObject.CompareTag("broccoli"))
        {
            broccoliesReady = true;
            broccoliesInGarden++;
        }

        if (collision.gameObject.CompareTag("celery"))
        {
            celeriesReady = true;
            celeriesInGarden++;
        }

        if (collision.gameObject.CompareTag("brusselSprout"))
        {
            brusselsReady = true;
            brusselsInGarden++;
        }

        if (collision.gameObject.CompareTag("kale"))
        {
            kalesReady = true;
            kalesInGarden++;
        }

        if (collision.gameObject.CompareTag("cabbage"))
        {
            cabbagesReady = true;
            cabbagesInGarden++;
        }
    }


    public void OnTriggerExit2D(Collider2D collision)
    {
        plantsInGarden--;

        if (collision.gameObject.CompareTag("pea"))
        {
            peasInGarden--;
            if (peasInGarden == 0)
            {
                peasReady = false;
            }
        }

        if (collision.gameObject.CompareTag("carrot"))
        {
            carrotsInGarden--;
            if (carrotsInGarden == 0)
            {
                carrotsReady = false;
            }
        }

        if (collision.gameObject.CompareTag("bellPepper"))
        {
            peppersInGarden--;
            if (peppersInGarden == 0)
            {
                peppersReady = false;
            }
        }

        if (collision.gameObject.CompareTag("potato"))
        {
            potatoesInGarden--;
            if (potatoesInGarden == 0)
            {
                potatoesReady = false;
            }
        }

        if (collision.gameObject.CompareTag("lettuce"))
        {
            lettucesInGarden--;
            if (lettucesInGarden == 0)
            {
                lettucesReady = false;
            }
        }

        if (collision.gameObject.CompareTag("cucumber"))
        {
            cucsInGarden--;
            if (cucsInGarden == 0)
            {
                cucsReady = false;
            }
        }

        if (collision.gameObject.CompareTag("onion"))
        {
            onionsInGarden--;
            if (onionsInGarden == 0)
            {
                onionsReady = false;
            }
        }

        if (collision.gameObject.CompareTag("squash"))
        {
            squashesInGarden--;
            if (squashesInGarden == 0)
            {
                squashesReady = false;
            }
        }

        if (collision.gameObject.CompareTag("corn"))
        {
            cornsInGarden--;
            if (cornsInGarden == 0)
            {
                cornsReady = false;
            }
        }

        if (collision.gameObject.CompareTag("pumpkin"))
        {
            pumpkinsInGarden--;
            if (pumpkinsInGarden == 0)
            {
                pumpkinsReady = false;
            }
        }

        if (collision.gameObject.CompareTag("turnip"))
        {
            turnipsInGarden--;
            if (turnipsInGarden == 0)
            {
                turnipsReady = false;
            }
        }

        if (collision.gameObject.CompareTag("tomato"))
        {
            tomatoesInGarden--;
            if (tomatoesInGarden == 0)
            {
                tomatoesReady = false;
            }
        }

        if (collision.gameObject.CompareTag("pintoBean"))
        {
            pintosInGarden--;
            if (pintosInGarden == 0)
            {
                pintosReady = false;
            }
        }

        if (collision.gameObject.CompareTag("greenBean"))
        {
            greenBeansInGarden--;
            if (greenBeansInGarden == 0)
            {
                greenBeansReady = false;
            }
        }

        if (collision.gameObject.CompareTag("broccoli"))
        {
            broccoliesInGarden--;
            if (broccoliesInGarden == 0)
            {
                broccoliesReady = false;
            }
        }

        if (collision.gameObject.CompareTag("celery"))
        {
            celeriesInGarden--;
            if (celeriesInGarden == 0)
            {
                celeriesReady = false;
            }
        }

        if (collision.gameObject.CompareTag("brusselSprout"))
        {
            brusselsInGarden--;
            if (brusselsInGarden == 0)
            {
                brusselsReady = false;
            }
        }

        if (collision.gameObject.CompareTag("kale"))
        {
            kalesInGarden--;
            if (kalesInGarden == 0)
            {
                kalesReady = false;
            }
        }

        if (collision.gameObject.CompareTag("cabbage"))
        {
            cabbagesInGarden--;
            if (cabbagesInGarden == 0)
            {
                cabbagesReady = false;
            }
        }
    }
}
