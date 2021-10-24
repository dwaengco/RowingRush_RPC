using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Rowing : MonoBehaviour
{

    const float nSecond = 2f;

    float timer = 0;
    bool entered = false;

    public void PointerEnter()
    {
        entered = true;
    }

    public void PointerExit()
    {
        entered = false;
    }

    void Update()
    {
        if (entered)
        {
            timer += Time.deltaTime;

            if(timer > nSecond)
            {
                SceneManager.LoadScene("Rowing");
            }
        }
        else
        {
            timer = 0;
        }
    }
    
}