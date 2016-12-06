using UnityEngine;
using System.Collections;

public class GameManger_gameover : MonoBehaviour {

    private GameManger_master gameMangerMaster;
    public GameObject panelgameover;
    // Use this for initialization
    void Onenable() {

    }

    // Update is called once per frame
    void OnDisable() {
        SetInitialRefrence();
        gameMangerMaster.GameOverEvent += TurnOnGameOverPanel;

    }

    void SetInitialRefrence() {
        gameMangerMaster = GetComponent<GameManger_master>();
    }

    void TurnOnGameOverPanel()
    {
if(panelgameover != null)
            {
            panelgameover.SetActive(true);
        }

    }
}