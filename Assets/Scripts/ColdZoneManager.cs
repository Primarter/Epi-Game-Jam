using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColdZoneManager : MonoBehaviour
{
    public GameObject ZonePrefab;
    private List<GameObject> zoneList;

    private float timeLength = 3.0f;
    float timeLeft = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        zoneList = new List<GameObject>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        foreach (GameObject o in zoneList)
        {
            o.transform.position += new Vector3(1.5f * Time.deltaTime, 0.0f, 0.0f);
        }

        timeLeft -= Time.deltaTime;
        if (timeLeft < 0.0f)
        {
            timeLeft = timeLength;

            float z = Random.Range(-20f, 20f);

            GameObject o = Instantiate(ZonePrefab, new Vector3(1, 1, z), Quaternion.identity);
            zoneList.Add(o);
        }
    }
}
