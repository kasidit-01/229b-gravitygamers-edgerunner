
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject creditScene;
    public TextMeshProUGUI LivesScoreText;
    public GameObject titleScreenUI;
    public GameObject gameOverScreenUI;
    public GameObject gameWinScreenUI;
    public TextMeshProUGUI CoinScoreText;
    public int CurrentCoins = 0;
    private int MaxCoins = 31;
    private int currentLives = 5;
    

    private bool gameIsOver = false;
    private void Awake()
    {
        Time.timeScale = 0f;
        gameIsOver = false;
        gameOverScreenUI.SetActive(false);
        gameWinScreenUI.SetActive(false);
        creditScene.SetActive(false);
        if (LivesScoreText != null)
        {
            LivesScoreText.gameObject.SetActive(false);
            CoinScoreText.gameObject.SetActive(false);
        }
    }



    public void PlayGame()
    {
        titleScreenUI.SetActive(false);
        Time.timeScale = 1f;
        if (LivesScoreText != null)
        {
            LivesScoreText.gameObject.SetActive(true);
            CoinScoreText.gameObject.SetActive(true);
        }
    }

    public void GameOver()
    {
        if (gameIsOver) return;

        gameIsOver = true;
        Time.timeScale = 0f;
        gameOverScreenUI.SetActive(true);
    }

    public void ReplayGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void WinGame()
    {
        Time.timeScale = 0f;
        gameWinScreenUI.SetActive(true);
    }
    public void AddLives()
    {
        currentLives--;
        UpdateLivesUI();

        if (currentLives <= 0)
        {
            GameOver();
        }
    }

    private void UpdateLivesUI()
    {
        if (LivesScoreText != null)
        {
            
            LivesScoreText.text = "Lives: " + currentLives.ToString();
        }
    }
    public void AddCoin()
    { 
        CurrentCoins++;
        UpdateCoinUI();
    }
    public void UpdateCoinUI()
    {
        if (CoinScoreText != null)
        {
            CoinScoreText.text = "Coins: " + CurrentCoins.ToString() + "/" + MaxCoins.ToString();
        }
        
    }
    public void credit()
    {
        titleScreenUI.SetActive(false);
        gameWinScreenUI.SetActive(false);
        creditScene.SetActive(true);
    }
}