using UnityEngine;
using System.Collections;

public class GameManger_master : MonoBehaviour
{

    public delegate void GameMangerEventHandler();
    public event GameMangerEventHandler RestartLevelEvent;
    public event GameMangerEventHandler GoToMenuSceneEvent;
    public event GameMangerEventHandler GameOverEvent;

    public bool isGameOver;
    public bool isMenuOn;

    public void CallEventRestartLevel()
    {
        if (RestartLevelEvent != null)
        {
            RestartLevelEvent();
        }
    }
    public void CalleventGameOver()
    {
        if(GameOverEvent != null)
        {
            GameOverEvent();
        }
             
    }
}
    
