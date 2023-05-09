using System.Collections;
using System.Collections.Generic;
using SaveSystem.Scripts.Runtime;
using SaveSystem.Scripts.Runtime.Channels;
using SceneManagement;
using UnityEngine;
using UnityEngine.UIElements;

[RequireComponent(typeof(UIDocument))]
public class MainMenuUI : MonoBehaviour
{
    private VisualElement m_ConfirmationModal;
    private UIDocument m_UIDocument;
    [SerializeField] private LoadSceneChannel m_LoadSceneChannel;
    [SerializeField] private SceneReference m_StartingLocation;
    [SerializeField] private GameData  m_GameData;
    [SerializeField] private LoadDataChannel m_LoadDataChannel;


    private void Awake() 
    {
        m_UIDocument = GetComponent<UIDocument>();
        
    }

    private void OnEnable()
    {
        var root = m_UIDocument.rootVisualElement;
        Button continueButton = root.Q<Button>("continue-button"); 
        continueButton.SetEnabled(m_GameData.hasPreviousSave);
        continueButton.clicked += ContinuePreviousGame;

        Button exitButton = root.Q<Button>("exit-button"); 
        exitButton.clicked += QuitGame;

        Button confirmButton = m_ConfirmationModal.Q<Button>("confirm-button");
        confirmButton.clicked += QuitGame;

        Button cancelButton = m_ConfirmationModal.Q<Button>("cancel-button");
        cancelButton.clicked += Cancel;

        Button closeButton = m_ConfirmationModal.Q<Button>("close-button");
        closeButton.clicked += Cancel;


        Button newGameButton = root.Q<Button>("new-game-button"); 
        newGameButton.clicked += StartNewGame;
    }

        private void Cancel()
    {
        m_ConfirmationModal.style.display = DisplayStyle.None;
    }

    private void ContinuePreviousGame()
    {
        m_GameData.LoadFromBinaryFile();
        m_LoadDataChannel.Load();
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
