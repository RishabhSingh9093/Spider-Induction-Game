using UnityEngine;
public class GameManager : MonoBehaviour
{
    public GameObject startPanel;
    void Start()
    {
        Time.timeScale=0f;
        startPanel.SetActive(true);
    }
    public void StartGame()
    {
        startPanel.SetActive(false);
        Time.timeScale=1f;
    }
    bool isPaused=false;
    public void TogglePause()
    {
        isPaused=!isPaused;
        Time.timeScale=isPaused?0f:1f;
    }
}