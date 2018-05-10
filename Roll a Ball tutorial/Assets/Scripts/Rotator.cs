using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {

    // use update because not using forces
    private void Update()
    {
        // multiply by Time.deltaTime to make it smooth
        transform.Rotate(new Vector3(15, 30, 35) * Time.deltaTime);
    }
}
