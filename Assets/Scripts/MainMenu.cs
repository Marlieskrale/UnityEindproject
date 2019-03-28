using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //void Start()
   // {
   //     Cursor.visible = true;
   // }

    private void Awake()
    {
        Cursor.lockState = CursorLockMode.None;
    }

    public void PlayGame()
    {
        //Cursor.visible;
        SceneManager.LoadScene("Level01");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("quit");
    }
}
