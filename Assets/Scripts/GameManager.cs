using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public void GameOver()
    {   // Show game over menu after 1s
        FindObjectOfType<GameOverMenu>().Invoke("ShowMenu", 1f);
    }
}
