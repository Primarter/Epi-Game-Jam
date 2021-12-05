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
        float scale = (Mathf.Sin(sw.ElapsedMilliseconds * 0.005f) + 3f) * 0.4f;
        this.transform.localScale = new Vector3(scale, 1f, scale);

        if (sw.ElapsedMilliseconds > 1500)
        {
            GameObject o = Instantiate(m_laserPrefab);

            Vector3 pos = this.transform.position;
            pos.y = 40;
            o.transform.position = pos;
            Destroy(this.gameObject);
        }
    }
}
