using UnityEngine;
using UnityEngine.SceneManagement;


public class StartMenu : Monobehavior
{
    public gameObject pauseMenu;

    private Void Update()
    {
        if (GameManager.Instance.CurrentState == GameManager.GameState.Playing)
        {
            {
                Pause();
            }
            else if (GameManager.Instance.CurrentState == GameManager.GameState.Paused)
            {
                UnPause();
            }
        }
    }
    
    private void Pause()
    {
        GameManager.Instance.SetGameState(GameState.Paused)
        Time.timeScale = 0f; //pause time
    }
    private void UnPause()
    {
        GameManager.Instance.SetGameState(GameState.Playing)
        Time.timescale = 1f; // resume time
    }
}
