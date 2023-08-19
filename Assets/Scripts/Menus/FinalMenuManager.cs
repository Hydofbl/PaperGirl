using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Menus
{
    public class FinalMenuManager : MonoBehaviour
    {
        public GameObject win,lose;
        public Text score, highscore;
        private int isWin;
    
        void Start()
        {
            isWin = PlayerPrefs.GetInt("isWin");
            if (isWin == 1)
            {
                win.SetActive(true);
            }
            else
            {            
                lose.SetActive(true);
            }
            score.text = PlayerPrefs.GetInt("Score").ToString();
            highscore.text = PlayerPrefs.GetInt("HighScore").ToString();
        }
    
        public void RestartButton()
        {
            SceneManager.LoadScene("InGameScene");
        }

        public void HomeButton()
        {
            SceneManager.LoadScene("MainMenuScene");  
        }

        public void DifficultyButton()
        {
            SceneManager.LoadScene("DifficultyMenuScene");
        }
    }
}
