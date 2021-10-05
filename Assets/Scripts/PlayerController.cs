using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20.0f;

    public float turnSpeed = 100.0f;

    public float hInput;

    public float vInput;

    public float xRange = 11.6f;

    public float yRange = 5.0f;

    public GameObject projectile;
    private Vector3 offset = new Vector3(0, 1, 0);

    public Transform launcher;

    // public float health;

    // Update is called once per frame
    void Update()
    {
        hInput = Input.GetAxis("Horizontal");
        vInput = Input.GetAxis("Vertical");

        transform.Rotate(Vector3.back * turnSpeed * hInput * Time.deltaTime);
        transform.Translate(Vector3.up * speed * vInput * Time.deltaTime);
        if(transform.position.x < -xRange){
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if(transform.position.x > xRange){
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if(transform.position.y < -yRange){
            transform.position = new Vector3(transform.position.x, -yRange, transform.position.z);
        }
        if(transform.position.y > yRange){
            transform.position = new Vector3(transform.position.x, yRange, transform.position.z);
        }

        if(Input.GetKeyDown(KeyCode.Space)) {
            Instantiate(projectile, launcher.transform.position, launcher.transform.rotation);
        }

    }
}
