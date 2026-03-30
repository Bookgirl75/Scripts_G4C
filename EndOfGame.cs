using TMPro;
using UnityEngine;

public class EndOfGame : MonoBehaviour
{ 
    public TextMeshProUGUI totalCalText;
    public TextMeshProUGUI peopleHelpedText;

    public int dailyCals = 1125;
    public float peopleHelped;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Calculations();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Calculations()
    {
        totalCalText.text = "Congrats! Your garden produced " + CollisionBasket.totalCalories + " calories over the course of the year.";
        peopleHelped = CollisionBasket.totalCalories / dailyCals;

        if (10 >= peopleHelped)
        {
            peopleHelpedText.text = "That means that you made " + peopleHelped + " meals for the community. It's a great start, but I'd aim for more next time.";
        }

        else if ((peopleHelped > 10) && (peopleHelped < 50))
        {
            peopleHelpedText.text = "That means that you made " + peopleHelped + " meals for the community. It's a great start, but I'd aim for more next time.";
        }

        else if ((peopleHelped >= 50) && (peopleHelped < 200))
        {
            peopleHelpedText.text = "That means that you made " + peopleHelped + " meals for the community! Keep up the great work";
        }

        else if (peopleHelped >= 200)
        {
            peopleHelpedText.text = "That means that you made " + peopleHelped + " meals for the community!!! That is incredible!";
        }
    }
}
