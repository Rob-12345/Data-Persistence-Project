using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
using TMPro;
using UnityEngine.UI;

public class MenuUI : MonoBehaviour
{

    public TMP_InputField inputField;
    public static string playerName;

    private void Start()
    {
        if (PlayerData.Instance.playerName != null)
        {
            inputField.GetComponent<TMP_InputField>().text = PlayerData.Instance.playerName;
        }
    }

    public void StartGame()
    {
        SceneManager.LoadScene("main");
    }
    
    public void BackToMenu()
    {
        SceneManager.LoadScene("menu");
    }

    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // original code to quit Unity player
#endif
    }

    public void SetPlayerName()
    {
        playerName = inputField.GetComponent<TMP_InputField>().text;
        PlayerData.Instance.playerName = playerName;
    }
}
