using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionDestroy : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        switch (other.tag)
        {
            case "Player":
                Destroy(gameObject);
                break;
            case "Wall":
                Destroy(gameObject);
                break;
            default:
                break;
        }
    }
}
