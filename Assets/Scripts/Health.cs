using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int health;

    void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "Enemy")
        {
            health = health - other.gameObject.GetComponent<Attack>().damage;
        }
    }

}
