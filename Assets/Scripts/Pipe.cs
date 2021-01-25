using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    // -3.5 de silinecek, 3.5 de eklenicek. yüksekleik 2 ile -1 arasında
    private Manager _manager;
    void Start()
    {
        float rast = Random.Range(-1.3f, 2.3f);
        transform.position = new Vector3(3.5f, rast, transform.position.z);
        _manager = GameObject.Find("Manager").GetComponent<Manager>();
    }
    
    void Update()
    {
        if (transform.position.x <= -3.5f)
        {
            Destroy(gameObject);
            _manager.ScorAdd(10);
        }
        transform.Translate(-0.5f*Time.deltaTime,0,0);
    }
}
