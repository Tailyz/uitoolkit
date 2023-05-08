//using Core.Input;
using SaveSystem.Scripts.Runtime;
using SaveSystem.Scripts.Runtime.Channels;
using SceneManagement;
//using UI.LoadingScreen;
using UnityEngine;

namespace Core.Scripts.Runtime.UI
{
    public class UIManager : MonoBehaviour
    {
        //[SerializeField] private InputReader m_InputReader;
        //[SerializeField] private PauseMenuUI m_PauseMenu;
        [SerializeField] private GameData m_GameData;
        [SerializeField] private SaveDataChannel m_SaveDataChannel;
        [SerializeField] private SceneReference m_MainMenuScene;
        [SerializeField] private LoadSceneChannel m_LoadSceneChannel;

        [SerializeField] private SceneReference m_ForestScene;
        //[SerializeField] private SceneReadyChannel m_SceneReadyChannel;
        //[SerializeField] private LoadingScreen m_LoadingScreen;


        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Save();
                m_LoadSceneChannel.Load(m_MainMenuScene);
            }
            else if (Input.GetKeyDown(KeyCode.Q))
            {
                m_LoadSceneChannel.Load(m_ForestScene);
            }
        }
        private void Save()
        {
            m_GameData.LoadFromBinaryFile();
            m_SaveDataChannel.Save();
            m_GameData.SaveToBinaryFile();
        }
    }
}
