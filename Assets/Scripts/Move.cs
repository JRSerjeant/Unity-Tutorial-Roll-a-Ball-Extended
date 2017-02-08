using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

    public GameObject ground;
    private Renderer groundRenderer;
    private float groundBoundsMinX;
    private float groundBoundsMaxX;
    private float groundBoundsMinZ;
    private float groundBoundsMaxZ;
    public Vector3 targetPostion;
    public float Speed;


    private void Start()
    {
        groundRenderer = ground.GetComponent<Renderer>();

        groundBoundsMinX = ground.transform.position.x - groundRenderer.bounds.extents.x;
        groundBoundsMaxX = ground.transform.position.x + groundRenderer.bounds.extents.x;

        groundBoundsMinZ = ground.transform.position.z - groundRenderer.bounds.extents.z;
        groundBoundsMaxZ = ground.transform.position.z + groundRenderer.bounds.extents.z;

        targetPostion = NewTargetPosition();
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPostion, Speed * Time.deltaTime);

        if(transform.position == targetPostion)
        {
            targetPostion = NewTargetPosition();
        }
    }

    Vector3 NewTargetPosition()
    {
        float randomX = Random.Range(groundBoundsMinX, groundBoundsMaxX);
        float randomZ = Random.Range(groundBoundsMinZ, groundBoundsMaxZ);
        return new Vector3(randomX, 0.5f, randomZ);
    }

}
