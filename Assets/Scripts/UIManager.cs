using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private GameObject gameOverText;
    [SerializeField]
    private GameObject playerWinText;

    public void DisplayGameOver()
    {
        gameOverText.SetActive(true);
    }
    
    public void DisplayPlayerWin()
    {
        playerWinText.SetActive(true);
    }
}
