using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject follow;
    public Vector3 offsets;
    public float interpolation_amount = 0;

    // Update is called once per frame
    void Update()
    {
        Vector3 lerpedPos = Vector3.Lerp(new Vector3(follow.transform.position.x + offsets.x,
        follow.transform.position.y + offsets.y, follow.transform.position.z + offsets.z),gameObject.transform.position,interpolation_amount);
        gameObject.transform.position = lerpedPos;
    }
}
