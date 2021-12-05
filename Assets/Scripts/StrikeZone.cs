using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrikeZone : MonoBehaviour
{
    [SerializeField]
    public GameObject m_laserPrefab;

    private System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();

    // Start is called before the first frame update
    void Start()
    {
        sw.Start();
    }

    // Update is called once per frame
    void Update()
    {
        if (sw.ElapsedMilliseconds > 1250)
        {
            GameObject o = Instantiate(m_laserPrefab);
            o.transform.position = this.transform.position;
            Destroy(this.gameObject);
        }
    }
}
