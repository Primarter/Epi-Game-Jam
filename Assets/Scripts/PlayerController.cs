using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed = 5.0f;
    public Animator animator;

    private Vector3 velocity;

    void Start() {
        velocity = new Vector3(0, 0, 0);
    }

    void Update() {
        velocity.z = Input.GetAxis("Vertical");
        velocity.x = Input.GetAxis("Horizontal");

        velocity = velocity.normalized;
        animator.SetFloat("Speed", Mathf.Abs(velocity.x) + Mathf.Abs(velocity.z));
        transform.Translate(velocity * Time.deltaTime * speed, Space.World);
        if (velocity.z != 0.0f || velocity.x != 0.0f)
            transform.rotation = Quaternion.LookRotation(velocity);
    }
}
