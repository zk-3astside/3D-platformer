using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
  public void StartGame ()
    {
        SceneManager.LoadScene(0);
        Debug.Log("START!");
    }
    public void EndGame ()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
   
}