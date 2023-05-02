using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Inventory : MonoBehaviour
{
    private UIDocument m_Uidocument;

    private void Awake()
    {
        m_Uidocument = GetComponent<UIDocument>();
    }


    private void Start()
    {
        VisualElement root = m_Uidocument.rootVisualElement;
        Button button = root.Q<Button>();
        button.clicked += () => Debug.Log("Hello World");
    }
}
