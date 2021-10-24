using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameRoomKeyboard : MonoBehaviour
{
    string IDword = null;

    int IDIndex = -1;

    string alphaID = null;
    string alphaID2 = null;

    public InputField nickName;
    public InputField roomName;
    public InputField chatting;

    char[] IDChar = new char[30];

    public GameObject KeyboardLower;
    public GameObject KeyboardUpper;

    public GameObject LobbyPanel;
    public GameObject RoomPanel;

    public InputField input;


    public void OnClickNickName()
    {
        //닉네임 입력 칸 누르면 키보드ui 활성화
        KeyboardLower.SetActive(true);
        KeyboardUpper.SetActive(false);

        IDIndex = -1;
        IDChar = new char[30];
        alphaID = null;
        IDword = null;
        input.text = null;
    }

    public void OnClickEnter()
    {
        //enter 누르면 키보드ui 비활성화
        KeyboardLower.SetActive(false);
        KeyboardUpper.SetActive(false);
    }

    public void OnClickUpper()
    {
        //위쪽 화살표 버튼 누르면 대문자로 변환

        //소문자 키보드가 활성화되어 있으면 1, 대문자 키보드가 활성화되어 있으면 0을 반환
        bool isKeyboardType = KeyboardLower.activeSelf == true;

        //1이면 대문자 키보드 활성화, 0이면 소문자 키보드 활성화시키기
        KeyboardLower.SetActive(!isKeyboardType);
        KeyboardUpper.SetActive(isKeyboardType);

    }

    public void alphabetFunction(string alphabet)
    {
        if (RoomPanel.activeSelf)
        {
            input = chatting;
            

        }
        else if (LobbyPanel.activeSelf)
        {
            input = roomName;
            
        }
        else
        {
            input = nickName;
        }


        alphabet = KeyboardLower.activeSelf ? alphabet : alphabet.ToUpper();

        IDIndex++;
        char[] keepIDchar = alphabet.ToCharArray();
        IDChar[IDIndex] = keepIDchar[0];
        alphaID = IDChar[IDIndex].ToString();
        IDword = IDword + alphabet;

        input.text = IDword;

    }

    public void backspaceFunction()
    {
        if (IDIndex >= 0)
        {
            IDIndex--;

            alphaID2 = null;

            for (int i = 0; i < IDIndex + 1; i++)
            {
                alphaID2 = alphaID2 + IDChar[i].ToString();
            }

            IDword = alphaID2;

            input.text = IDword;
        }
    }

}