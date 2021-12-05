using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    private System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();

    [SerializeField]
    public Collider m_trigger;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Destroy(other.gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        sw.Start();
    }

    // Update is called once per frame
    void Update()
    {

        if (sw.ElapsedMilliseconds > 250)
        {
            Destroy(this.gameObject);
        }
    }
}
