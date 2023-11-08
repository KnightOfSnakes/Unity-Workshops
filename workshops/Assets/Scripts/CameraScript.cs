using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject followTarget;

    // Update is called once per frame
    void Update()
    {
        transform.position = followTarget.transform.position;
    }
}
