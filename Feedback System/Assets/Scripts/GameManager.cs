using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<GameObject> buttonList;
    [SerializeField] private int counter = 0;

    public void Next()
    {
        if(counter < 4)
        {
            counter++;
            sceneManager();
        }
    }
    public void Back()
    {
        if(counter >= 0)
        {
            counter--;
            sceneManager();
        }
    }

    public void sceneManager()
    {
        switch (counter)
        {
            case 0:
                buttonList[0].SetActive(true);
                buttonList[1].SetActive(false);
                buttonList[2].SetActive(false);
                buttonList[3].SetActive(false);
                break;
            case 1:
                buttonList[0].SetActive(false);
                buttonList[1].SetActive(true);
                buttonList[2].SetActive(false);
                buttonList[3].SetActive(false);
                break;
            case 2:
                buttonList[0].SetActive(false);
                buttonList[1].SetActive(false);
                buttonList[2].SetActive(true);
                buttonList[3].SetActive(false);
                break;
            case 3:
                buttonList[0].SetActive(false);
                buttonList[1].SetActive(false);
                buttonList[2].SetActive(false);
                buttonList[3].SetActive(true);
                break;
        }
    }
}
