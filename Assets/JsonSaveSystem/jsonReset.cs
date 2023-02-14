
#if UNITY_EDITOR

using UnityEngine;
using System.IO;
using UnityEditor;
using UnityEditor.SceneManagement;

public class JsonReset : MonoBehaviour
{

    public static string filePath;
    private const string FILE_NAME = "saveData.json";

    public static void Reset()
    {
        // data reset
        GameVariables gameVariables = Resources.Load<GameVariables>("GameVariables");

        gameVariables.level = 1;
        
        // get file path
        filePath = Path.Combine(Application.persistentDataPath, FILE_NAME);

        // file control
        if (File.Exists(filePath))
            File.Delete(filePath);

        // scene mark and save
        EditorUtility.SetDirty(gameVariables);
        EditorSceneManager.MarkSceneDirty(EditorSceneManager.GetActiveScene());
        EditorSceneManager.SaveScene(EditorSceneManager.GetActiveScene());
    }
}
#endif