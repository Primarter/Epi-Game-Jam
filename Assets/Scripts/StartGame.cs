using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    [SerializeField]
    public GameObject m_gameManagerPrefab;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") {
            Instantiate(m_gameManagerPrefab);
            Destroy(this.gameObject);
        }
    }
}
