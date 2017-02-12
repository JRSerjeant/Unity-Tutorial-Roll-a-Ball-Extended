using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBullet : MonoBehaviour {

    public GameObject Bullet;
    public int Quantity;
    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        float Chance = Random.Range(0.0f, 10.0f);
        if (Chance < 0.025f)
        {
            Instantiate(Bullet, gameObject.transform.position, Quaternion.identity);
        }
	}
}
