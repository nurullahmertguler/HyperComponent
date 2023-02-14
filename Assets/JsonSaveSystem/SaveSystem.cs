using System.IO;
using UnityEngine;

public class SaveSystem : MonoBehaviour
{
    public static SaveSystem instance;

    [SerializeField] private const string FILE_NAME = "saveData.json";
    [SerializeField] private string filePath;

    public GameVariables saveData;


    public void Initialize()
    {
        saveData = Resources.Load<GameVariables>("GameVariables");
        filePath = Path.Combine(Application.persistentDataPath, FILE_NAME);
    }

    private void Awake()
    {

        instance = this;
        Initialize();
    }


    private void OnEnable()
    {
        // ApplicationQuitOrPause.Add(SaveGame);
    }

    private void OnDisable()
    {
        // ApplicationQuitOrPause.Remove(SaveGame);
    }

    private void OnApplicationQuit()
    {
        SaveGame();
    }

    void Start()
    {
        CreateSaveFile();
        LoadGame();
        DontDestroyOnLoad(gameObject);
        ApplicationQuitOrPause.Add(SaveGame);
    }

    private void CreateSaveFile()
    {
        if (!File.Exists(filePath))
        {
            File.Create(filePath).Dispose();
            SaveGame();
        }
    }


    public void DeleteSave()
    {
        File.Delete(filePath);
    }

    public void SaveGame()
    {
        string json = JsonUtility.ToJson(saveData);
        File.WriteAllText(filePath, json);
    }

    private void LoadGame()
    {
        if (!File.Exists(filePath))
        {
            File.Create(filePath).Dispose();
            SaveGame();
        }
        else
        {
            string json = File.ReadAllText(filePath);
            JsonUtility.FromJsonOverwrite(json, saveData);

        }

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            LoadGame();
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            SaveGame();
        }
    }


}




