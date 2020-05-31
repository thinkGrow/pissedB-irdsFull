
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
  
   
       public  void restartClicked ()
        {
           string currentSceneName = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(currentSceneName);
            
        }
    
}
