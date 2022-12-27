using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{

    public static Action<bool> LoadNextLevelEvent;
    // Kullan�c�n�n oynad��� level indexini tutan de�i�ken
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



    // Bir sonraki level sahnesine ge�me fonksiyonu
    public void LoadNextLevel(bool win)
    {

        // Kullan�c�n�n oynad��� level indexini artt�r�yoruz
        currentLevel = PlayerPrefs.GetInt("activeLevel",0);

        if(win)
            currentLevel++;

        PlayerPrefs.SetInt("activeLevel", currentLevel);


        // E�er kullan�c�n�n oynad��� level indexi, toplam level say�s�ndan k���kse, bir sonraki level sahnesine ge�iriyoruz
        if (currentLevel < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(currentLevel);
        }
        // E�er kullan�c�n�n oynad��� level indexi, toplam level say�s�ndan b�y�kse, en son level sahnesini a��yoruz
        else
        {
            SceneManager.LoadScene(SceneManager.sceneCountInBuildSettings - 1);
        }
    }
}
