using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class logicscript : MonoBehaviour
{
    public int playerscore;
    public Text scorecount;
    public GameObject gameOverScreen;
    [ContextMenu("Increase Score")]
    public void addscore()
    {
        playerscore += 1;
        scorecount.text = playerscore.ToString();
        
    }
    public void GameRestart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void GameOver()
    {
        gameOverScreen.SetActive(true);
    }
}
