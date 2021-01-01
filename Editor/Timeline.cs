using UnityEngine;
using UnityEditor;

class Timeline : EditorWindow
{
    string myString = "Hello World";
    string myString2 = "Hello World";
    bool groupEnabled;
    bool myBool = true;
    float myFloat = 1.23f;

    private int animationLenth = 30;


    private const int buttonWidth= 35;

    [MenuItem("Window/MichMond/Cinema Timeline")]
    public static void ShowWindow()
    {
        var w= EditorWindow.GetWindow(typeof(Timeline));
        w.minSize = new Vector2(450f, 250f);
    }


    Vector2 scrollPos;
    void OnGUI()
    {
        EditorGUILayout.BeginHorizontal();
           
        /*   */ EditorGUILayout.BeginVertical(GUILayout.Width(125));
        /*   *   */ GUILayout.BeginHorizontal();
        /*   *   *   */ if (GUILayout.Button("+", GUILayout.Width(buttonWidth))) { animationLenth--; }
        /*   *   *   */ myString2 = EditorGUILayout.TextField(myString2);
        /*   *   *   */ if (GUILayout.Button("+", GUILayout.Width(buttonWidth))) { animationLenth++; }
        /*   *   */ GUILayout.EndHorizontal();
        /*   *   */ GUILayout.Label("Base Settings", EditorStyles.boldLabel);
        /*   *   */ myString = EditorGUILayout.TextField("Text Field", myString);
        /*   *   */ groupEnabled = EditorGUILayout.BeginToggleGroup("Optional Settings", groupEnabled);
        /*   *   */ myBool = EditorGUILayout.Toggle("Toggle", myBool);
        /*   *   */ myFloat = EditorGUILayout.Slider("Slider", myFloat, -3, 3);
        /*   *   */ EditorGUILayout.EndToggleGroup();
        /*   */ EditorGUILayout.EndVertical();
        /*   */ scrollPos = EditorGUILayout.BeginScrollView(scrollPos);
        /*   *   */ EditorGUILayout.BeginVertical();
        /*   *   *   */ GUILayout.BeginHorizontal();
        /*   *   *   *   */ if (GUILayout.Button("<1",GUILayout.Width(buttonWidth))) {  Debug.Log("Clicked Button");  }
        /*   *   *   *   */ if (GUILayout.Button("1>", GUILayout.Width(buttonWidth))) {  Debug.Log("Clicked Button");  }
        /*   *   *   *   */ if (GUILayout.Button("<24", GUILayout.Width(buttonWidth))) {  Debug.Log("Clicked Button");  }
        /*   *   *   *   */ if (GUILayout.Button("24>", GUILayout.Width(buttonWidth))) {  Debug.Log("Clicked Button"); }
        /*   *   *   */ GUILayout.EndHorizontal();
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
