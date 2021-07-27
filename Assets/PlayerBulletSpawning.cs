using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBulletSpawning : MonoBehaviour
{
    public GameObject prefab;
    public float time;
    public Transform point;
    //public float timer;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 2f, time);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Spawn()
    {
        GameObject temp = Instantiate(prefab);
        temp.transform.position = point.transform.position;
    }
}
