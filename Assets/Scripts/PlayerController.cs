using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed;

    private Vector3 velocity;

    void Start() {
        velocity = new Vector3(0, 0, 0);
    }

    void Update() {
        velocity.z = Input.GetAxis("Vertical");
        velocity.x = Input.GetAxis("Horizontal");

        velocity = velocity.normalized;
        transform.Translate(velocity * Time.deltaTime * speed);
    }
}
