using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;     //show the score
    public TextMeshProUGUI gameOverText;  //Game Over UI
    public TextMeshProUGUI restartText;  //restart UI
    public CharacterController player;    

    private float score = 0f;             //calculate score based on game time
    private bool gameOver = false;

    void Start()
    {
        if (gameOverText != null)
            gameOverText.gameObject.SetActive(false); //hide the gameover UI at first
           restartText.gameObject.SetActive(false); 
    }

    void Update()
    {
        if (!gameOver)
        {
            //calculate score
            score += Time.deltaTime;
            if (scoreText != null)
                scoreText.text = "Your Score: " + Mathf.FloorToInt(score); 
        }

        //make the game restart after pressing space
        if (gameOver && Input.GetKeyDown(KeyCode.Space))
        {
            RestartGame();
        }
    }

    //show UI when player died
    public void GameOver()
    {
        gameOver = true;
        if (gameOverText != null)
        {
            gameOverText.gameObject.SetActive(true);
            restartText.gameObject.SetActive(true);
        }
    }

    void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
