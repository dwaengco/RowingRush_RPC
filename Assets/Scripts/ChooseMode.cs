using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChooseMode : MonoBehaviour
{
    public void SceneChange_single()
    {
        SceneManager.LoadScene("E_start");

    }

    public void SceneChange_multi()
    {
        SceneManager.LoadScene("Select");

    }

    public void SceneChange_home()
    {
        SceneManager.LoadScene("first");

    }

    public void StartMulti()
    {
        SceneManager.LoadScene("muti_start");

    }
}
