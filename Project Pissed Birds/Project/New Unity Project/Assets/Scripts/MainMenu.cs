

using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
   public void playGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
    public void OpenSite()
    {
        Debug.Log("Should open URL");
        Application.OpenURL("https://www.youtube.com/");
    }

    public void returnMainMenu()
    {
        SceneManager.LoadScene("Main Menu");

    }

   

}
