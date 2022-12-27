using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{

    public static Action<bool> LoadNextLevelEvent;
    // Kullanýcýnýn oynadýðý level indexini tutan deðiþken
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



    // Bir sonraki level sahnesine geçme fonksiyonu
    public void LoadNextLevel(bool win)
    {

        // Kullanýcýnýn oynadýðý level indexini arttýrýyoruz
        currentLevel = PlayerPrefs.GetInt("activeLevel",0);

        if(win)
            currentLevel++;

        PlayerPrefs.SetInt("activeLevel", currentLevel);


        // Eðer kullanýcýnýn oynadýðý level indexi, toplam level sayýsýndan küçükse, bir sonraki level sahnesine geçiriyoruz
        if (currentLevel < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(currentLevel);
        }
        // Eðer kullanýcýnýn oynadýðý level indexi, toplam level sayýsýndan büyükse, en son level sahnesini açýyoruz
        else
        {
            SceneManager.LoadScene(SceneManager.sceneCountInBuildSettings - 1);
        }
    }
}
