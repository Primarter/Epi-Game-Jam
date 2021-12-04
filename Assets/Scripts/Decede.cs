using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Decede : MonoBehaviour {

    private void OnTriggerEnter(Collider other) {
        Debug.Log("collided");
    }
}
