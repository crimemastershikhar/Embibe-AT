using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseGame : MonoBehaviour
{
    bool isPuase = false;

    public void Pause()
    {
        if (isPuase)
        {
            Time.timeScale = 1;
            isPuase = false;
        }
        else
        {
            Time.timeScale = 0;
            isPuase = true;
        }
    }
}
