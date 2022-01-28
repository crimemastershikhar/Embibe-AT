using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayGame : MonoBehaviour
{
    bool isPlay = true;

    public void Play()
    {
        if (isPlay)
        {
            Time.timeScale = 1;
            isPlay = true;
        }
        else
        {
            Time.timeScale = 0;
            isPlay = false;
        }
    }
}
