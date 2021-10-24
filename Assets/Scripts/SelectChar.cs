using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class SelectChar : MonoBehaviour
{
    //private GSmanager scriptG;

    public DataMgr.Character character;
    //Animator anim;
    SpriteRenderer sr;
    public SelectChar[] chars;

    public TextMeshProUGUI ID_1, ID_2, ID_3, ID_4;

    void Start()
    {
        //anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
        if (DataMgr.instance.currentCharacter == character)
        {
            OnSelect();
            //scriptG = GameObject.Find("GSmanager").GetComponent<GSmanager>();

            if (character==DataMgr.Character.Body_1)
            {
                //ID_1.text = scriptG.myID.text;
                ID_1.text = "hem";

            }
            if (character == DataMgr.Character.Body_2)
            {
                //ID_2.text = scriptG.myID.text;
                ID_2.text = "hem";

            }
            if (character == DataMgr.Character.Body_3)
            {
                //ID_3.text = scriptG.myID.text;
                ID_3.text = "hem";

            }
            if (character == DataMgr.Character.Body_4)
            {
                //ID_4.text = scriptG.myID.text;
                ID_4.text = "hem";

            }
        }
        else OnDeSelect();
    }

    private void OnMouseUpAsButton()
    {
        DataMgr.instance.currentCharacter = character;
        OnSelect();
        for (int i = 0; i<chars.Length;i++)
        {
            if (chars[i] != this) chars[i].OnDeSelect();
        }
    }

    void OnDeSelect()
    {
        //anim.SetBool("run", true);
        sr.color = new Color(0.5f, 0.5f, 0.5f);
    }

    void OnSelect()
    {
        //anim.SetBool("run", true);
        sr.color = new Color(1f, 1f, 1f);
    }
}
