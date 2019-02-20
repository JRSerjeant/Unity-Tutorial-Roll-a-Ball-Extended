using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinText : MonoBehaviour
{
    Text winText;

    Health playerHealth;
    int playerStartingHealth;

    [SerializeField]
    private int totalEnemyCount = 0;

    void Start()
    {
        winText = gameObject.GetComponent<Text>();
        totalEnemyCount = (GameObject.FindGameObjectsWithTag("Pick Up")).Length;
    }

    void Update()
    {
        if((GameObject.FindGameObjectsWithTag("Pick Up")).Length <= 0)
        {
            winText.text = "You Win!";
        }
        
        if(GameObject.FindGameObjectWithTag("Player").GetComponent<Health>().health == 0)
        {
            winText.text = "You Lose!";
            
        }
    }
}
