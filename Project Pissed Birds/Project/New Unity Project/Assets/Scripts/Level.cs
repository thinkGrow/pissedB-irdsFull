using UnityEngine.SceneManagement;
using UnityEngine;

public class Level : MonoBehaviour
{
    private Enemy[] _enemies;
    //private static int _nextLevelIndex =1;
    // Update is called once per frame
    private void OnEnable()
    {   
        _enemies = FindObjectsOfType<Enemy>();

    }
    void Update()
    {
        foreach(Enemy enemy in _enemies)
        {
            if(enemy != null)
            {
                return;
            }
        }

        Debug.Log("You Killed all animals");

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        

        /*_nextLevelIndex++;

        string nextLevelName = "Level" + _nextLevelIndex;
        SceneManager.LoadScene(nextLevelName);*/
    }
}
