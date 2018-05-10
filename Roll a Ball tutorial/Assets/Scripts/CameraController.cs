using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject player;
    private Vector3 offset;

    // used for initialization
    private void Start()
    {
        offset = transform.position - player.transform.position;

    }
    // lateupdate is called once per frame but guaranteed to run AFTER update so that everything else is already processed (moves camera before displaying what camera can see)
    private void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
