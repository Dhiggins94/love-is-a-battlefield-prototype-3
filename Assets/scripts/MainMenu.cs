using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour
{

    public void playgame()
    {
        Application.LoadLevel(1);

    }
    public void exitgame()
    {
        Application.Quit();
    }
}