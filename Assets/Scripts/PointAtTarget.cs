using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointAtTarget : MonoBehaviour {

    GameObject Target;

    private void Start()
    {
        Target = GameObject.FindGameObjectWithTag("Player");
        transform.LookAt(Target.transform);
    }
}
