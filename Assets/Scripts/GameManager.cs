using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    public GameObject m_strikeZonePrefab;

    private System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();

    void Start()
    {
        Debug.Log("Game Started");
        sw.Start();
    }

    void Update()
    {
        if (sw.ElapsedMilliseconds > 750) {
            GameObject o = Instantiate(m_strikeZonePrefab);
            o.transform.position = new Vector3(Random.Range(-50f, 50f), 1, Random.Range(-50f, 50f));

            sw.Restart();
        }
    }
}
