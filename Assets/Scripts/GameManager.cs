using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    public GameObject m_strikeZonePrefab;

    private GameObject m_playerObject;

    private System.Diagnostics.Stopwatch sw_around = new System.Diagnostics.Stopwatch();
    private System.Diagnostics.Stopwatch sw_onTarget = new System.Diagnostics.Stopwatch();

    void Start()
    {
        Debug.Log("Game Started");
        sw_around.Start();
        sw_onTarget.Start();

        m_playerObject = GameObject.FindWithTag("Player");
    }

    void Update()
    {
        if (!m_playerObject) return;

        if (sw_onTarget.ElapsedMilliseconds > 2500)
        {
            GameObject o = Instantiate(m_strikeZonePrefab);

            Vector3 pos = m_playerObject.transform.position;
            pos.y = 1f;
            o.transform.position = pos;

            sw_onTarget.Restart();
        }

        if (sw_around.ElapsedMilliseconds > 150) {
            GameObject o = Instantiate(m_strikeZonePrefab);

            Vector3 pos = m_playerObject.transform.position;
            float maxDist = 25f;
            pos.y = 1f;
            pos.x += Random.Range(-maxDist, maxDist);
            pos.z += Random.Range(-maxDist, maxDist);
            o.transform.position = pos;

            sw_around.Restart();
        }
        if (GameObject.FindWithTag("Player") == null) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
