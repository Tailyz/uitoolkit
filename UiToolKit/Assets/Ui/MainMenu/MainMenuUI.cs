using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using SceneManagement;
using UnityEngine.Events;

[RequireComponent(typeof(UIDocument))]
public class MainMenuUI : MonoBehaviour
{
    private UIDocument m_UIDocument;
    [SerializeField] private LoadSceneChannel m_LoadSceneChannel;
    [SerializeField] private SceneReference m_StartingLocation;


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

        Button newGameButton = root.Q<Button>("new-game-button"); 
        newGameButton.clicked += StartNewGame;
    }

    private void StartNewGame()
    {
        m_LoadSceneChannel.Load(m_StartingLocation);
    }

    private void QuitGame()
    {
        Application.Quit();
    }
}
