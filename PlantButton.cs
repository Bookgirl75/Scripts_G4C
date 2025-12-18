using UnityEngine;

public class PlantButton : MonoBehaviour
{
    public Collision4Planting plantCollision;
    public GrowthController growthController;

    public GameObject peaPacket;
    public GameObject carrotPacket;
    public GameObject pepperPacket;
    public GameObject potatoPacket;
    public GameObject lettucePacket;
    public GameObject cucPacket;
    public GameObject onionPacket;
    public GameObject squashPacket;
    public GameObject cornPacket;
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

    public bool peaPlanted = false;
    public bool carrotPlanted = false;
    public bool pepperPlanted = false;
    public bool potatoPlanted = false;
    public bool lettucePlanted = false;
    public bool onionPlanted = false;
    public bool cucPlanted = false;
    public bool squashPlanted = false;
    public bool cornPlanted = false;
    public bool pumpkinPlanted = false;
    public bool turnipPlanted = false;
    public bool tomatoPlanted = false;
    public bool pintoPlanted = false;
    public bool greenBeanPlanted = false;
    public bool broccoliPlanted = false;
    public bool celeryPlanted = false;
    public bool brusselPlanted = false;
    public bool kalePlanted = false;
    public bool cabbagePlanted = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonPressed()
    {
        if ((plantCollision.peasReady == true) & (peaPlanted == false))
        {
            growthController.PlantPea();
            peaPlanted = true;
            Destroy(peaPacket);
        }

        if ((plantCollision.carrotsReady == true) & (carrotPlanted == false))
        {
            growthController.PlantCarrot();
            carrotPlanted = true;
            Destroy(carrotPacket);
        }

        if ((plantCollision.peppersReady == true) & (pepperPlanted == false))
        {
            growthController.PlantPepper();
            pepperPlanted = true;
            Destroy(pepperPacket);
        }

        if ((plantCollision.potatoesReady == true) & (potatoPlanted == false))
        {
            growthController.PlantPotato();
            potatoPlanted = true;
            Destroy(potatoPacket);
        }

        if ((plantCollision.lettucesReady == true) & (lettucePlanted == false))
        {
            growthController.PlantLettuce();
            lettucePlanted = true;
            Destroy(lettucePacket);
        }

        if ((plantCollision.cucsReady == true) & (cucPlanted == false))
        {
            growthController.PlantCuc();
            cucPlanted = true;
            Destroy(cucPacket);
        }

        if ((plantCollision.onionsReady == true) & (onionPlanted == false))
        {
            growthController.PlantOnion();
            onionPlanted = true;
            Destroy(onionPacket);
        }

        if ((plantCollision.squashesReady == true) & (squashPlanted == false))
        {
            growthController.PlantSquash();
            squashPlanted = true;
            Destroy(squashPacket);
        }

        if ((plantCollision.cornsReady == true) & (cornPlanted == false))
        {
            growthController.PlantCorn();
            cornPlanted = true;
            Destroy(cornPacket);
        }

        if ((plantCollision.pumpkinsReady == true) & (pumpkinPlanted == false))
        {
            growthController.PlantPumpkin();
            pumpkinPlanted = true;
            Destroy(pumpkinPacket);
        }

        if ((plantCollision.turnipsReady == true) & (peaPlanted == false))
        {
            growthController.PlantTurnip();
            turnipPlanted = true;
            Destroy(turnipPacket);
        }

        if ((plantCollision.tomatoesReady == true) & (tomatoPlanted == false))
        {
            growthController.PlantTomato();
            tomatoPlanted = true;
            Destroy(tomatoPacket);
        }

        if ((plantCollision.pintosReady == true) & (pintoPlanted == false))
        {
            growthController.PlantPinto();
            pintoPlanted = true;
            Destroy(pintoPacket);
        }

        if ((plantCollision.greenBeansReady == true) & (greenBeanPlanted == false))
        {
            growthController.PlantGreenBean();
            greenBeanPlanted = true;
            Destroy(greenBeanPacket);
        }

        if ((plantCollision.broccoliesReady == true) & (broccoliPlanted == false))
        {
            growthController.PlantBroccoli();
            broccoliPlanted = true;
            Destroy(broccoliPacket);
        }

        if ((plantCollision.celeriesReady == true) & (celeryPlanted == false))
        {
            growthController.PlantCelery();
            celeryPlanted = true;
            Destroy(celeryPacket);
        }

        if ((plantCollision.brusselsReady == true) & (brusselPlanted == false))
        {
            growthController.PlantBrussel();
            brusselPlanted = true;
            Destroy(brusselPacket);
        }

        if ((plantCollision.kalesReady == true) & (kalePlanted == false))
        {
            growthController.PlantKale();
            tomatoPlanted = true;
            Destroy(tomatoPacket);
        }

    }
}
