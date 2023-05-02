using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

[RequireComponent(typeof(UIDocument))]
public class MainMenuUI : MonoBehaviour
{
    private UIDocument m_UIDocument;


    private void Awake() 
    {
        m_UIDocument = GetComponent<UIDocument>();
        
    }

    private void OnEnable()
    {
        var root = m_UIDocument.rootVisualElement;
        Button continueButton = root.Q<Button>("continue-button"); 
        continueButton.SetEnabled(false);

        Button exitButton = root.Q<Button>("exit-button"); 
        exitButton.clicked += QuitGame;
    }

    private void QuitGame()
    {
        Application.Quit();
    }
}
