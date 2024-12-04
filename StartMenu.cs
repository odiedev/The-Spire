using UnityEngine;
using UnityEngine.SceneManagement;


public class StartMenu : Monobehavior
{
    public gameObject pauseMenu;
    
private void Pause()
    if(Input.GetKeyDown(KeyCode.Escape))
    {
        GameManager.Instance.SetGameState(GameState.Paused)
        Time.timeScale = 0f; //pause time
    }
private void UnPause()
    {
        GameManager.Instance.SetGameState(GameState.Playing)
        Time.timescale = 0f; // resume time
    }
}
