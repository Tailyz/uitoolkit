using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UIElements;
using UnityEditor.UIElements;

public class UiToolKit : EditorWindow
{
    VisualElement container;

    [MenuItem("Testing/Test Window")]
    public static void ShowWindow()
    {
        UiToolKit window = GetWindow<UiToolKit>();
        window.titleContent = new GUIContent("Test Window");
        window.minSize = new Vector2(500,500);
    }
    // Start is called before the first frame update
    public void CreateGUI()
    {
        container = rootVisualElement;
        VisualTreeAsset visualTree = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>("Assets/uitoolkit.uxml");
        container.Add(visualTree.Instantiate());

        StyleSheet styleSheet = AssetDatabase.LoadAssetAtPath<StyleSheet>("Assets/uitoolkit.uss");
        container.styleSheets.Add(styleSheet);
    }
}
