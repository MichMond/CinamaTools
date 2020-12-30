using UnityEngine;
using UnityEditor;
using System.Collections;

class Timeline : EditorWindow
{
    string myString = "Hello World";
    bool groupEnabled;
    bool myBool = true;
    float myFloat = 1.23f;

    [MenuItem("Window/MichMond/Cinema Timeline")]
    public static void ShowWindow()
    {
     var w=   EditorWindow.GetWindow(typeof(Timeline));
        w.minSize = new Vector2(450f, 250f);
    }


    Vector2 scrollPos;
    void OnGUI()
    {
        EditorGUILayout.BeginHorizontal();
        /*   */ EditorGUILayout.BeginVertical(GUILayout.Width(125));
        /*   *   */ GUILayout.Label("Base Settings", EditorStyles.boldLabel);
        /*   *   */ myString = EditorGUILayout.TextField("Text Field", myString);
        /*   *   */ groupEnabled = EditorGUILayout.BeginToggleGroup("Optional Settings", groupEnabled);
        /*   *   */ myBool = EditorGUILayout.Toggle("Toggle", myBool);
        /*   *   */ myFloat = EditorGUILayout.Slider("Slider", myFloat, -3, 3);
        /*   *   */ EditorGUILayout.EndToggleGroup();
        /*   */ EditorGUILayout.EndVertical();
        /*   */ scrollPos = EditorGUILayout.BeginScrollView(scrollPos);
        /*   *   */ EditorGUILayout.BeginVertical();
        /*   *   *   */ EditorGUILayout.BeginHorizontal();
        /*   *   *   *   */ GUILayout.Label("Base Settings", EditorStyles.boldLabel); myString = EditorGUILayout.TextField("Text Field", myString); groupEnabled = EditorGUILayout.BeginToggleGroup("Optional Settings", groupEnabled); EditorGUILayout.EndToggleGroup();
        /*   *   *   */ EditorGUILayout.EndHorizontal();
        /*   *   *   */ EditorGUILayout.BeginHorizontal();
        /*   *   *   *   */ GUILayout.Label("Base Settings", EditorStyles.boldLabel); myString = EditorGUILayout.TextField("Text Field", myString); groupEnabled = EditorGUILayout.BeginToggleGroup("Optional Settings", groupEnabled); EditorGUILayout.EndToggleGroup();
        /*   *   *   */ EditorGUILayout.EndHorizontal();
        /*   *   *   */ EditorGUILayout.BeginHorizontal();
        /*   *   *   *   */ GUILayout.Label("Base Settings", EditorStyles.boldLabel); myString = EditorGUILayout.TextField("Text Field", myString); groupEnabled = EditorGUILayout.BeginToggleGroup("Optional Settings", groupEnabled); EditorGUILayout.EndToggleGroup();
        /*   *   *   */ EditorGUILayout.EndHorizontal();
        /*   *   */ EditorGUILayout.EndVertical();
        /*   */ EditorGUILayout.EndScrollView();
        EditorGUILayout.EndHorizontal();

    
    }
}
