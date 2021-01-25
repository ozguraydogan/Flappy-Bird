using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bird : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;
    public float power;
    public float angle;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene(0); // Sahnenin index numarasını yazdık.
    }

    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rigidbody2D.velocity = Vector2.zero;
            _rigidbody2D.velocity = Vector2.up * power * Time.deltaTime;
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, 60.0f);
        }
        else
        {
            transform.eulerAngles -= new Vector3(transform.eulerAngles.x, transform.eulerAngles.y,angle);
        }
    }
}
