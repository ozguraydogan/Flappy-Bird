using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud : MonoBehaviour
{
    // -3.90 çıkış, 3.90 giriş  -- +4 ile -2 arası yükseklik
    void Start()
    {
        
    }
    
    void Update()
    {
        if (transform.position.x <= -3.90f)
        {
            float y_deger = Random.Range(-1.0f, 4.0f);
            transform.position = new Vector3(3.90f, y_deger, transform.position.z);
        }
        transform.Translate(-0.2f*Time.deltaTime,0,0);
    }
}
