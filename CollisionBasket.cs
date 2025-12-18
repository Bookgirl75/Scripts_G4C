using TMPro;
using UnityEngine;

public class CollisionBasket : MonoBehaviour
{
    //public GrowthController growthController;
    public GrowthController growthController;
    public PlantButton plantButton;
    public Collision4Planting collision4Planting;

    public TextMeshProUGUI calorieText;
    public TextMeshProUGUI caloriesGainedText;

    public int averageCaloriesPerObject;
    public int averageHarvest;

    public float dataTimer = 1;

    public float totalCalories;
    public float caloriesGained;
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

                if ((growthController.tomatoMonthsCounted == 1) || (growthController.tomatoMonthsCounted == 2))
                {
                    CalcCalories();
                }

                else if (growthController.tomatoMonthsCounted == 3)
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

        
    }

    public void CalcCalories()
    {
        caloriesGained = harvestPercent * averageCaloriesPerObject;
        totalCalories += caloriesGained;
        caloriesGainedText.text = "Calories gained: " + caloriesGained;
    }

    public void CalcCaloriesOffMonths()
    {
        caloriesGained = harvestPercentByTime * averageCaloriesPerObject;
        totalCalories += caloriesGained;
        caloriesGainedText.text = "Calories gained: " + caloriesGained;
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
