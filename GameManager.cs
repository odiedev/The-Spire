using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour

{
    // Singleton Instance
    public static GameManager Instance { get; private set; }
    //get allows a value to be read from outside the class. private set restricts the ability to modify

    // Game States
    public enum GameState { MainMenu, Playing, Paused, GameOver }
    public GameState CurrentState { get; private set; }


    private void Awake()
    {
        // Ensure only one instance exists
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject); // Persist through all unity scenes
    }


    public void Start()
    {
        SetGameState(GameState.MainMenu);
    }


    // Change Game State
    public void SetGameState(GameState newState)
    {
        CurrentState = newState;

        switch (CurrentState)
        {
            case GameState.MainMenu:
                Time.timeScale = 1f; // Reset time scale
                break;

            case GameState.Playing:
                Time.timeScale = 1f; // Resume time
                break;

            case GameState.Paused:
                Time.timeScale = 0f; // Pause time
                break;

            case GameState.GameOver:
                Time.timeScale = 0f; // Freeze time
                isGameOver = true;
                break;
        }
    }

    public void QuitGame()
    {
        GameManager.Instance
    }
}
