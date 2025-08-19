using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Logic_manager : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public bool isGameOver = false;

    [ContextMenu("Increase score")]
    public void Addscore(int scoreToAdd)
    {
        if (!isGameOver)
        {
            playerScore += scoreToAdd;
            scoreText.text = playerScore.ToString();
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver()
    {
    gameOverScreen.SetActive(true);
    isGameOver = true;
    }
}
