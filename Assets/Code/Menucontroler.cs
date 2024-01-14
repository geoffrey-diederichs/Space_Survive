using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menucontroler : MonoBehaviour
{
   public static void ChangeScene(string sceneName)
   {
       SceneManager.LoadScene(sceneName);
   }

    public void QuitGame()
    {
        Application.Quit();
    }
}
