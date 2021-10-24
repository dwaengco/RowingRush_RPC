using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DataMgr : MonoBehaviour
{
    public enum Character
    {
        Body_1, Body_2, Body_3, Body_4
    }
    public static DataMgr instance;
    private void Awake()
    {
        if (instance == null) instance = this;
        else if (instance != null) return;
        DontDestroyOnLoad(gameObject);

    }

    public void click_select()
    {
        SceneManager.LoadScene("GameRoom");
    }

    public Character currentCharacter;
}
