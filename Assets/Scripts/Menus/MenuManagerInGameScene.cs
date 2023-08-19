using UnityEngine;
using UnityEngine.SceneManagement;

namespace Menus
{
    public class MenuManagerInGameScene : MonoBehaviour
    {
        public GameObject inGameScreen, pauseScreen;

        public void PauseButton()
        {
            Time.timeScale = 0;
            inGameScreen.SetActive(false);
            pauseScreen.SetActive(true);
        }

        public void ContinueButton()
        {
            Time.timeScale = 1;
            inGameScreen.SetActive(true);
            pauseScreen.SetActive(false);
        }

        public void RestartButton()
        {
            Time.timeScale = 1;
            SceneManager.LoadScene("InGameScene");
        }

        public void HomeButton()
        {
            Time.timeScale = 1;
            SceneManager.LoadScene("MainMenuScene");  
        }

        public void DifficultyButton()
        {
            Time.timeScale = 1;
            SceneManager.LoadScene("DifficultyMenuScene");
        }
    }
}
