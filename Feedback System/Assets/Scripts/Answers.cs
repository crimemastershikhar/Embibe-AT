using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Answers : MonoBehaviour
{
    public bool isCorrect = false;
    public qManager mcqManager;
    public Image winImage;
    public TextMeshProUGUI winText;

    private void Start()
    {
        winImage.gameObject.SetActive(false);
    }
    public void Answer()
    {
        if (isCorrect)
        {
            mcqManager.correct();
            winText.text = "Correct Answer";
            winImage.gameObject.SetActive(true);
        }
        else
        {
            mcqManager.wrong();
            winText.text = "Wrong Answer";
            winImage.gameObject.SetActive(true);
        }

    }
}
