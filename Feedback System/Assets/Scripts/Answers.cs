using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Answers : MonoBehaviour
{
    public bool isCorrect = false;
    public qManager mcqManager;
    public void Answer()
    {
        if (isCorrect)
        {
            mcqManager.correct();
            Debug.Log("CORRECT");
        }
        else
        {
            mcqManager.correct();
            mcqManager.bRetry.gameObject.SetActive(true);
            Debug.Log("Incorrect");
        }

    }
}
