using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class qManager : MonoBehaviour
{
    public List<AnsController> QnA;
    public GameObject[] options;
    public int currentQuestion;
    public Text QuestionTxt;
    public Image nextImage;
    public TextMeshProUGUI nextText;

    private void Start()
    {
        generateQuestion();
        nextImage.gameObject.SetActive(false);
    }
    public void correct()
    {
        QnA.RemoveAt(currentQuestion);
        generateQuestion();
        Debug.Log("Recieved");
    }
    public void wrong()
    {       
        Debug.Log("Recieved");
    }
    void SetAnswers()
    {
        for (int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<Answers>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<Text>().text = QnA[currentQuestion].Answers[i];
            if (QnA[currentQuestion].CorrectAnswer == i + 1)
            {
                options[i].GetComponent<Answers>().isCorrect = true;
            }
        }
    }

    void generateQuestion()
    {
        if(QnA.Count > 0)
        {
            currentQuestion = Random.Range(0, QnA.Count);
            QuestionTxt.text = QnA[currentQuestion].Question;
            SetAnswers();
        }
        else
        {
            nextImage.gameObject.SetActive(true);
            nextText.text = "Move to the next screen";
            Debug.Log("MOve to the next");
        }
    }
}
