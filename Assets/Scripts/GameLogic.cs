using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameLogic : MonoBehaviour
{
    public int playerScore;
    public Text playerScoreText;
    public GameObject gameOverScreen;
    public GameObject pauseMenu;
    public bool gameIsActive = true;

    [ContextMenu("Increase Score")]
    public void IncrementPlayerScore()
    {
        if (gameIsActive)
        {
            playerScore++;
            playerScoreText.text = playerScore.ToString();
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        gameIsActive = true;
        ApplyTimeScale();
    }

    public void GameOver()
    {
        gameIsActive = false;
        ApplyTimeScale();
        gameOverScreen.SetActive(true);
    }

    public void StartGame()
    {
        SceneManager.LoadScene("MainGameplayScene");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePause();
        }
    }

    void TogglePause()
    {
        gameIsActive = !gameIsActive;
        ApplyPauseState();
    }

    public void ResumeGame()
    {
        gameIsActive = true;
        ApplyPauseState();
    }

    void ApplyPauseState()
    {
        ApplyTimeScale();
        pauseMenu.SetActive(!gameIsActive);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    void ApplyTimeScale()
    { 
        Time.timeScale = gameIsActive ? 1 : 0;
    }
}
