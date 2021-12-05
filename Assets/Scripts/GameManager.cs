using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    public GameObject m_rayPrefab;

    private System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();

    void Start()
    {
        Debug.Log("Game Started");
        sw.Start();
    }

    void Update()
    {
        if (sw.ElapsedMilliseconds > 1000) {
            Instantiate(m_rayPrefab);
            sw.Restart();
        }
    }
}
