using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CountText : MonoBehaviour
{
    Text countText;

    [SerializeField]
    private int totalEnemyCount = 0;

    void Start()
    {
        countText = gameObject.GetComponent<Text>();
        totalEnemyCount = (GameObject.FindGameObjectsWithTag("Pick Up")).Length;
    }

    void Update()
    {
        countText.text = "Count: " + (GameObject.FindGameObjectsWithTag("Pick Up")).Length + "/" + totalEnemyCount;
    }
}
