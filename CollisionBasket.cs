using TMPro;
using UnityEngine;

public class CollisionBasket : MonoBehaviour
{
    //public GrowthController growthController;
    public GrowthController growthController;
    public PlantButton plantButton;
    public Collision4Planting collision4Planting;
    public SeasonManager seasonManager;

    public TextMeshProUGUI calorieText;
    public TextMeshProUGUI caloriesGainedText;

    public int averageCaloriesPerObject;
    public int averageHarvest;

    public float dataTimer = 1;

    public static float totalCalories;

    public float caloriesGained;
    public float amountSubtract;
    public float amountAdd;
    public float finalCaloriesGained;
    public float harvestPercent;
    public float harvestPercentByTime;

    public bool textOn = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        averageHarvest = 0;
        averageCaloriesPerObject = 0;
        caloriesGained = 0;
        calorieText.text = "";
        caloriesGainedText.text = "";
        amountAdd = 0;
        amountSubtract = 0;
        finalCaloriesGained = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (textOn == true)
        {
            CountDownTimer();
        }

        calorieText.text = "Total Calories: " + totalCalories;
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("pea"))
        {
            if (plantButton.peaPlanted == true)
            {
                averageCaloriesPerObject = 64;
                averageHarvest = 1;
                harvestPercent = (growthController.peaPlantTiming) * (averageHarvest);

                textOn = true;

                Destroy(collision.gameObject);
                collision4Planting.plantsInGarden--;

                if (growthController.peaMonthsCounted == 2)
                {
                    CalcCalories();
                }

                else if (growthController.peaMonthsCounted == 3)
                {
                    harvestPercentByTime = harvestPercent * .8f;
                    CalcCaloriesOffMonths();
                }

                else if (growthController.peaMonthsCounted == 1)
                {
                    harvestPercentByTime = harvestPercent * .6f;
                    CalcCaloriesOffMonths();
                }

                else
                {
                    caloriesGainedText.text = "Calories gained: 0";
                }
            }
        }

        if (collision.gameObject.CompareTag("tomato"))
        {
            if (plantButton.tomatoPlanted == true)
            {
                averageCaloriesPerObject = 24;
                averageHarvest = 15;
                harvestPercent = (growthController.tomatoPlantTiming) * (averageHarvest);

                Destroy(collision.gameObject);
                collision4Planting.plantsInGarden--;

                textOn = true;

                if ((growthController.tomatoMonthsCounted == 2) || (growthController.tomatoMonthsCounted == 3))
                {
                    CalcCalories();
                }

                else if (growthController.tomatoMonthsCounted == 4)
                {
                    harvestPercentByTime = harvestPercent * .8f;
                    CalcCaloriesOffMonths();
                }

                else if (growthController.tomatoMonthsCounted == 1)
                {
                    harvestPercentByTime = harvestPercent * .6f;
                    CalcCaloriesOffMonths();
                }

                else
                {
                    caloriesGainedText.text = "Calories gained: 0";
                }
            }
        }

        if (collision.gameObject.CompareTag("carrot"))
        {
            if (plantButton.carrotPlanted == true)
            {
                averageCaloriesPerObject = 23;
                averageHarvest = 1;
                harvestPercent = (growthController.carrotPlantTiming) * (averageHarvest);

                Destroy(collision.gameObject);
                collision4Planting.plantsInGarden--;

                textOn = true;

                if ((growthController.carrotMonthsCounted == 2) || (growthController.carrotMonthsCounted == 3))
                {
                    CalcCalories();
                }

                else if (growthController.carrotMonthsCounted == 4)
                {
                    harvestPercentByTime = harvestPercent * .8f;
                    CalcCaloriesOffMonths();
                }

                else if (growthController.carrotMonthsCounted == 1)
                {
                    harvestPercentByTime = harvestPercent * .6f;
                    CalcCaloriesOffMonths();
                }

                else
                {
                    caloriesGainedText.text = "Calories gained: 0";
                }
            }
        }

        if (collision.gameObject.CompareTag("bellPepper"))
        {
            if (plantButton.pepperPlanted == true)
            {
                averageCaloriesPerObject = 35;
                averageHarvest = 10;
                harvestPercent = (growthController.pepperPlantTiming) * (averageHarvest);

                Destroy(collision.gameObject);
                collision4Planting.plantsInGarden--;

                textOn = true;

                if ((growthController.pepperMonthsCounted == 2) || (growthController.pepperMonthsCounted == 3))
                {
                    CalcCalories();
                }

                else if (growthController.pepperMonthsCounted == 4)
                {
                    harvestPercentByTime = harvestPercent * .8f;
                    CalcCaloriesOffMonths();
                }

                else if (growthController.pepperMonthsCounted == 1)
                {
                    harvestPercentByTime = harvestPercent * .6f;
                    CalcCaloriesOffMonths();
                }

                else
                {
                    caloriesGainedText.text = "Calories gained: 0";
                }
            }
        }

        if (collision.gameObject.CompareTag("potato"))
        {
            if (plantButton.potatoPlanted == true)
            {
                averageCaloriesPerObject = 140;
                averageHarvest = 8;
                harvestPercent = (growthController.potatoPlantTiming) * (averageHarvest);

                Destroy(collision.gameObject);
                collision4Planting.plantsInGarden--;

                textOn = true;

                if ((growthController.potatoMonthsCounted == 3) || (growthController.potatoMonthsCounted == 4))
                {
                    CalcCalories();
                }

                else if (growthController.potatoMonthsCounted == 5)
                {
                    harvestPercentByTime = harvestPercent * .8f;
                    CalcCaloriesOffMonths();
                }

                else if (growthController.potatoMonthsCounted == 2)
                {
                    harvestPercentByTime = harvestPercent * .6f;
                    CalcCaloriesOffMonths();
                }

                else
                {
                    caloriesGainedText.text = "Calories gained: 0";
                }
            }
        }

        if (collision.gameObject.CompareTag("lettuce"))
        {
            if (plantButton.lettucePlanted == true)
            {
                averageCaloriesPerObject = 110;
                averageHarvest = 1;
                harvestPercent = (growthController.lettucePlantTiming) * (averageHarvest);

                Destroy(collision.gameObject);
                collision4Planting.plantsInGarden--;

                textOn = true;

                if ((growthController.lettuceMonthsCounted == 2) || (growthController.lettuceMonthsCounted == 3))
                {
                    CalcCalories();
                }

                else if (growthController.lettuceMonthsCounted == 4)
                {
                    harvestPercentByTime = harvestPercent * .7f;
                    CalcCaloriesOffMonths();
                }

                else if (growthController.lettuceMonthsCounted == 1)
                {
                    harvestPercentByTime = harvestPercent * .6f;
                    CalcCaloriesOffMonths();
                }

                else
                {
                    caloriesGainedText.text = "Calories gained: 0";
                }
            }
        }

        if (collision.gameObject.CompareTag("cucumber"))
        {
            if (plantButton.cucPlanted == true)
            {
                averageCaloriesPerObject = 21;
                averageHarvest = 12;
                harvestPercent = (growthController.cucPlantTiming) * (averageHarvest);

                Destroy(collision.gameObject);
                collision4Planting.plantsInGarden--;

                textOn = true;

                if ((growthController.cucMonthsCounted == 2))
                {
                    CalcCalories();
                }

                else if (growthController.cucMonthsCounted == 3)
                {
                    harvestPercentByTime = harvestPercent * .8f;
                    CalcCaloriesOffMonths();
                }

                else if (growthController.cucMonthsCounted == 1)
                {
                    harvestPercentByTime = harvestPercent * .6f;
                    CalcCaloriesOffMonths();
                }

                else
                {
                    caloriesGainedText.text = "Calories gained: 0";
                }
            }
        }

        if (collision.gameObject.CompareTag("onion"))
        {
            if (plantButton.onionPlanted == true)
            {
                averageCaloriesPerObject = 660;
                averageHarvest = 1;
                harvestPercent = (growthController.onionPlantTiming) * (averageHarvest);

                Destroy(collision.gameObject);
                collision4Planting.plantsInGarden--;

                textOn = true;

                if ((growthController.onionMonthsCounted == 3))
                {
                    CalcCalories();
                }

                else if (growthController.onionMonthsCounted == 4)
                {
                    harvestPercentByTime = harvestPercent * .8f;
                    CalcCaloriesOffMonths();
                }

                else if (growthController.onionMonthsCounted == 2)
                {
                    harvestPercentByTime = harvestPercent * .6f;
                    CalcCaloriesOffMonths();
                }

                else
                {
                    caloriesGainedText.text = "Calories gained: 0";
                }
            }
        }

        if (collision.gameObject.CompareTag("squash"))
        {
            if (plantButton.squashPlanted == true)
            {
                averageCaloriesPerObject = 68;
                averageHarvest = 12;
                harvestPercent = (growthController.squashPlantTiming) * (averageHarvest);

                Destroy(collision.gameObject);
                collision4Planting.plantsInGarden--;

                textOn = true;

                if ((growthController.squashMonthsCounted == 3) || (growthController.squashMonthsCounted == 4))
                {
                    CalcCalories();
                }

                else if (growthController.squashMonthsCounted == 5)
                {
                    harvestPercentByTime = harvestPercent * .8f;
                    CalcCaloriesOffMonths();
                }

                else if (growthController.squashMonthsCounted == 2)
                {
                    harvestPercentByTime = harvestPercent * .4f;
                    CalcCaloriesOffMonths();
                }

                else
                {
                    caloriesGainedText.text = "Calories gained: 0";
                }
            }
        }

        if (collision.gameObject.CompareTag("corn"))
        {
            if (plantButton.cornPlanted == true)
            {
                averageCaloriesPerObject = 141;
                averageHarvest = 2;
                harvestPercent = (growthController.cornPlantTiming) * (averageHarvest);

                Destroy(collision.gameObject);
                collision4Planting.plantsInGarden--;

                textOn = true;

                if ((growthController.cornMonthsCounted == 2) || (growthController.cornMonthsCounted == 3))
                {
                    CalcCalories();
                }

                else if (growthController.cornMonthsCounted == 4)
                {
                    harvestPercentByTime = harvestPercent * .8f;
                    CalcCaloriesOffMonths();
                }

                else if (growthController.cornMonthsCounted == 1)
                {
                    harvestPercentByTime = harvestPercent * .6f;
                    CalcCaloriesOffMonths();
                }

                else
                {
                    caloriesGainedText.text = "Calories gained: 0";
                }
            }
        }

        if (collision.gameObject.CompareTag("pumpkin"))
        {
            if (plantButton.pumpkinPlanted == true)
            {
                averageCaloriesPerObject = 256;
                averageHarvest = 8;
                harvestPercent = (growthController.pumpkinPlantTiming) * (averageHarvest);

                Destroy(collision.gameObject);
                collision4Planting.plantsInGarden--;

                textOn = true;

                if ((growthController.pumpkinMonthsCounted == 3) || (growthController.pumpkinMonthsCounted == 4))
                {
                    CalcCalories();
                }

                else if (growthController.pumpkinMonthsCounted == 5)
                {
                    harvestPercentByTime = harvestPercent * .6f;
                    CalcCaloriesOffMonths();
                }

                else if (growthController.pumpkinMonthsCounted == 2)
                {
                    harvestPercentByTime = harvestPercent * .4f;
                    CalcCaloriesOffMonths();
                }

                else
                {
                    caloriesGainedText.text = "Calories gained: 0";
                }
            }
        }

        if (collision.gameObject.CompareTag("turnip"))
        {
            if (plantButton.turnipPlanted == true)
            {
                averageCaloriesPerObject = 73;
                averageHarvest = 1;
                harvestPercent = (growthController.turnipPlantTiming) * (averageHarvest);

                Destroy(collision.gameObject);
                collision4Planting.plantsInGarden--;

                textOn = true;

                if ((growthController.turnipMonthsCounted == 1) || (growthController.turnipMonthsCounted == 2))
                {
                    CalcCalories();
                }

                else if (growthController.turnipMonthsCounted == 3)
                {
                    harvestPercentByTime = harvestPercent * .7f;
                    CalcCaloriesOffMonths();
                }

                else
                {
                    caloriesGainedText.text = "Calories gained: 0";
                }
            }
        }

        if (collision.gameObject.CompareTag("pintoBean"))
        {
            if (plantButton.pintoPlanted == true)
            {
                averageCaloriesPerObject = 98;
                averageHarvest = 24;
                harvestPercent = (growthController.pintoPlantTiming) * (averageHarvest);

                Destroy(collision.gameObject);
                collision4Planting.plantsInGarden--;

                textOn = true;

                if ((growthController.pintoMonthsCounted == 3) || (growthController.pintoMonthsCounted == 4) || (growthController.pintoMonthsCounted == 5))
                {
                    CalcCalories();
                }

                else if (growthController.pintoMonthsCounted == 6)
                {
                    harvestPercentByTime = harvestPercent * .7f;
                    CalcCaloriesOffMonths();
                }

                else if (growthController.pintoMonthsCounted == 2)
                {
                    harvestPercentByTime = harvestPercent * .6f;
                    CalcCaloriesOffMonths();
                }

                else
                {
                    caloriesGainedText.text = "Calories gained: 0";
                }
            }

        }

        if (collision.gameObject.CompareTag("greenBean"))
        {
            if (plantButton.greenBeanPlanted == true)
            {
                averageCaloriesPerObject = 11;
                averageHarvest = 16;
                harvestPercent = (growthController.greenBeanPlantTiming) * (averageHarvest);

                Destroy(collision.gameObject);
                collision4Planting.plantsInGarden--;

                textOn = true;

                if (growthController.greenBeanMonthsCounted == 2)
                {
                    CalcCalories();
                }

                else if (growthController.greenBeanMonthsCounted == 3)
                {
                    harvestPercentByTime = harvestPercent * .8f;
                    CalcCaloriesOffMonths();
                }

                else if (growthController.greenBeanMonthsCounted == 1)
                {
                    harvestPercentByTime = harvestPercent * .6f;
                    CalcCaloriesOffMonths();
                }

                else
                {
                    caloriesGainedText.text = "Calories gained: 0";
                }
            }
        }

        if (collision.gameObject.CompareTag("broccoli"))
        {
            if (plantButton.broccoliPlanted == true)
            {
                averageCaloriesPerObject = 119;
                averageHarvest = 1;
                harvestPercent = (growthController.broccoliPlantTiming) * (averageHarvest);

                Destroy(collision.gameObject);
                collision4Planting.plantsInGarden--;

                textOn = true;

                if ((growthController.broccoliMonthsCounted == 2) || (growthController.broccoliMonthsCounted == 3) || (growthController.broccoliMonthsCounted == 4))
                {
                    CalcCalories();
                }

                else if (growthController.broccoliMonthsCounted == 5)
                {
                    harvestPercentByTime = harvestPercent * .8f;
                    CalcCaloriesOffMonths();
                }

                else if (growthController.broccoliMonthsCounted == 1)
                {
                    harvestPercentByTime = harvestPercent * .6f;
                    CalcCaloriesOffMonths();
                }

                else
                {
                    caloriesGainedText.text = "Calories gained: 0";
                }
            }
        }

        if (collision.gameObject.CompareTag("celery"))
        {
            if (plantButton.celeryPlanted == true)
            {
                averageCaloriesPerObject = 48;
                averageHarvest = 1;
                harvestPercent = (growthController.celeryPlantTiming) * (averageHarvest);

                Destroy(collision.gameObject);
                collision4Planting.plantsInGarden--;

                textOn = true;

                if (growthController.celeryMonthsCounted == 4)
                {
                    CalcCalories();
                }

                else if (growthController.celeryMonthsCounted == 5)
                {
                    harvestPercentByTime = harvestPercent * .8f;
                    CalcCaloriesOffMonths();
                }

                else if (growthController.celeryMonthsCounted == 3)
                {
                    harvestPercentByTime = harvestPercent * .6f;
                    CalcCaloriesOffMonths();
                }

                else
                {
                    caloriesGainedText.text = "Calories gained: 0";
                }
            }
        }

        if (collision.gameObject.CompareTag("brusselSprout"))
        {
            if (plantButton.brusselPlanted == true)
            {
                averageCaloriesPerObject = 8;
                averageHarvest = 80;
                harvestPercent = (growthController.brusselPlantTiming) * (averageHarvest);

                Destroy(collision.gameObject);
                collision4Planting.plantsInGarden--;

                textOn = true;

                if ((growthController.brusselMonthsCounted == 3) || (growthController.brusselMonthsCounted == 4))
                {
                    CalcCalories();
                }

                else if (growthController.brusselMonthsCounted == 5)
                {
                    harvestPercentByTime = harvestPercent * .8f;
                    CalcCaloriesOffMonths();
                }

                else if (growthController.brusselMonthsCounted == 2)
                {
                    harvestPercentByTime = harvestPercent * .6f;
                    CalcCaloriesOffMonths();
                }

                else
                {
                    caloriesGainedText.text = "Calories gained: 0";
                }
            }
        }

        if (collision.gameObject.CompareTag("kale"))
        {
            if (plantButton.kalePlanted == true)
            {
                averageCaloriesPerObject = 13;
                averageHarvest = 16;
                harvestPercent = (growthController.kalePlantTiming) * (averageHarvest);

                Destroy(collision.gameObject);
                collision4Planting.plantsInGarden--;

                textOn = true;

                if (growthController.kaleMonthsCounted == 2)
                {
                    CalcCalories();
                }

                else if (growthController.kaleMonthsCounted == 3)
                {
                    harvestPercentByTime = harvestPercent * .8f;
                    CalcCaloriesOffMonths();
                }

                else if (growthController.kaleMonthsCounted == 1)
                {
                    harvestPercentByTime = harvestPercent * .6f;
                    CalcCaloriesOffMonths();
                }

                else
                {
                    caloriesGainedText.text = "Calories gained: 0";
                }
            }
        }

        if (collision.gameObject.CompareTag("cabbage"))
        {
            if (plantButton.cabbagePlanted == true)
            {
                averageCaloriesPerObject = 9;
                averageHarvest = 33;
                harvestPercent = (growthController.cabbagePlantTiming) * (averageHarvest);

                Destroy(collision.gameObject);
                collision4Planting.plantsInGarden--;

                textOn = true;

                if ((growthController.cabbageMonthsCounted == 2) || (growthController.cabbageMonthsCounted == 3))
                {
                    CalcCalories();
                }

                else if (growthController.cabbageMonthsCounted == 4)
                {
                    harvestPercentByTime = harvestPercent * .8f;
                    CalcCaloriesOffMonths();
                }

                else if (growthController.cabbageMonthsCounted == 1)
                {
                    harvestPercentByTime = harvestPercent * .6f;
                    CalcCaloriesOffMonths();
                }

                else
                {
                    caloriesGainedText.text = "Calories gained: 0";
                }
            }
        }
    }

    public void CalcCalories()
    {
        caloriesGained = harvestPercent * averageCaloriesPerObject;
        amountSubtract = caloriesGained * seasonManager.percentLoss;
        amountAdd = caloriesGained * seasonManager.percentGain;
        finalCaloriesGained = caloriesGained + (amountAdd - amountSubtract);
        totalCalories += finalCaloriesGained;
        caloriesGainedText.text = "Calories gained: " + finalCaloriesGained;
    }

    public void CalcCaloriesOffMonths()
    {
        caloriesGained = harvestPercentByTime * averageCaloriesPerObject;
        amountSubtract = caloriesGained * seasonManager.percentLoss;
        amountAdd = caloriesGained * seasonManager.percentGain;
        finalCaloriesGained = caloriesGained + (amountAdd - amountSubtract);
        totalCalories += finalCaloriesGained;
        caloriesGainedText.text = "Calories gained: " + finalCaloriesGained;
    }

    public void CountDownTimer()
    {
        dataTimer -= Time.deltaTime;

        if (dataTimer <= 0)
        {
            caloriesGainedText.text = "";
            textOn = false;
            dataTimer = 1;
        }
    }
}


