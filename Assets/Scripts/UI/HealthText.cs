﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthText : MonoBehaviour
{
    Text healthText;

    Health playerHealth;
    int playerStartingHealth;

    // Start is called before the first frame update
    void Start()
    {
        healthText = gameObject.GetComponent<Text>();
        playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<Health>();
        playerStartingHealth = playerHealth.health;
    }

    // Update is called once per frame
    void Update()
    {
        if(playerHealth.health >= 0)
        {
            healthText.text = "Health: " + playerHealth.health + "/" + playerStartingHealth;
        }
    }
}
