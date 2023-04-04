using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private int enemyAlive = 3;
    private int playerAlive = 3;
    public UIManager uIManager;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(0);
        }    

        if (enemyAlive < 1)
        {
            uIManager.DisplayPlayerWin();
        }

        else if (playerAlive < 1)
        {
            uIManager.DisplayGameOver();
        }
    }

    public void DecreaseEnemyCount()
    {
        enemyAlive--;
        Debug.Log("enemy = "+enemyAlive);
    }
    
    public void DecreasePlayerCount()
    {
        playerAlive--;
        Debug.Log("player = " + playerAlive);
    }
}
