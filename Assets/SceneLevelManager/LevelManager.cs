using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{

    public static Action<bool> LoadNextLevelEvent;
    // Variable that holds the user's level index
    private int currentLevel;

    private void Awake()
    {
        //DontDestroyOnLoad(this.gameObject);
    }
    private void Start()
    {
        LoadNextLevel(false);
    }

    private void OnEnable()
    {
        LoadNextLevelEvent += LoadNextLevel;
    }

    private void OnDisable()
    {
        LoadNextLevelEvent -= LoadNextLevel;
    }



    // Function to move to the next level scene
    public void LoadNextLevel(bool win)
    {

        // We increase the user's playing level index
        currentLevel = PlayerPrefs.GetInt("activeLevel",0);

        if(win)
            currentLevel++;

        PlayerPrefs.SetInt("activeLevel", currentLevel);


        // If the level index played by the user is less than the total number of levels, we pass it to the next level scene
        if (currentLevel < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(currentLevel);
        }
        // If the level index played by the user is greater than the total number of levels, we open the last level scene
        else
        {
            SceneManager.LoadScene(SceneManager.sceneCountInBuildSettings - 1);
        }
    }
}
