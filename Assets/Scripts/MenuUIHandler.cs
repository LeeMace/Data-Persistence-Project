using System.Collections;
using System.Collections.Generic;
#if UNITY_EDITOR
using UnityEngine;
#endif
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;



public class MenuUIHandler : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI PlayerNameInput;

    public void SetPlayerName()
    {
        PlayerData.Instance.PlayerName = PlayerNameInput.text;
    }


    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }

    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
