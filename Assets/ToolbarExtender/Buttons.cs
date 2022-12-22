using UnityEditor;
using UnityEngine;


namespace UnityToolbarExtender.Examples
{
#if UNITY_EDITOR
	static class ToolbarStyles
	{
		public static readonly GUIStyle commandButtonStyle;

		static ToolbarStyles()
		{
			commandButtonStyle = new GUIStyle("Command")
			{
				fontSize = 12,
				alignment = TextAnchor.MiddleCenter,
				imagePosition = ImagePosition.ImageAbove,
				fontStyle = FontStyle.Bold,
				fixedWidth = 100
				
			};
		}
	}


	[InitializeOnLoad]
	public class ScenePrefResetButton
	{
		static ScenePrefResetButton()
		{
			ToolbarExtender.LeftToolbarGUI.Add(OnToolbarGUI);
		}

		static void OnToolbarGUI()
		{
			GUILayout.FlexibleSpace();

			if (GUILayout.Button(new GUIContent("Clear Prefs", "Clear All Playerprefs"), ToolbarStyles.commandButtonStyle))
			{
				PlayerPrefs.DeleteAll();
			}
			if (GUILayout.Button(new GUIContent("level 0", "level 0"), ToolbarStyles.commandButtonStyle))
			{
				//EditorApplication.SaveCurrentSceneIfUserWantsTo();
				//EditorApplication.OpenScene("Assets/Game/Scenes/game_level/LoadScene.unity");
			}
		}
	}
#endif
}
