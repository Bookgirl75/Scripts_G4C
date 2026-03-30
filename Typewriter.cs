using System.Collections;
using TMPro;
using UnityEngine;

public class TypewriterEffect : MonoBehaviour
{
    public float typingSpeed = 0.05f;
    public TextMeshProUGUI cutSceneText;
    public TextMeshProUGUI continueButtonText;

    public GameObject backgroundOne;
    public GameObject backgroundTwo;
    public GameObject backgroundThree;
    public GameObject backgroundFour;


    [TextArea(3, 10)]
    public string[] textLines;

    public int currentLineIndex = 0;
    public bool isTyping = false;

    void Start()
    {
        StartCoroutine(TypeLine());
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isTyping)
            {
                StopAllCoroutines();
                cutSceneText.text = textLines[currentLineIndex];
                isTyping = false;
            }
            else
            {
                currentLineIndex++;
                if (currentLineIndex < textLines.Length)
                {
                    StartCoroutine(TypeLine());
                }

                else
                {
                    cutSceneText.text = "";
                }
            }
        }

        if (currentLineIndex == 3)
        {
            backgroundOne.transform.gameObject.SetActive(false);
        }
        
        if (currentLineIndex == 5)
        {
            backgroundTwo.transform.gameObject.SetActive(false);
        }
        
        if (currentLineIndex == 8)
        {
            backgroundThree.transform.gameObject.SetActive(false);
        }

        if (currentLineIndex >= 10)
        {
            continueButtonText.text = "Start";
        }
    }

    IEnumerator TypeLine()
    {
        isTyping = true;
        cutSceneText.text = "";

        foreach (char letter in textLines[currentLineIndex].ToCharArray())
        {
            cutSceneText.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }

        isTyping = false;
    }

    
}