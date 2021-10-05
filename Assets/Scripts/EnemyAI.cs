using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{

    public Transform player;
    public float speed = 10.0f;
    public Rigidbody2D rb;
    public Vector2 target;

    // Start is called before the first frame update
    void Start()
    {
        target = player.position;
    }

    // Update is called once per frame
    void Update()
    {
        target = player.position;

        Vector2 lookDir = target - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg;
        rb.rotation = angle;

        float step = speed * Time.deltaTime;

        // move sprite towards the target location
        transform.position = Vector3.MoveTowards(transform.position, target, step);
    }

    void OnTriggerEnter2D(Collider2D collider) {
        if(collider.CompareTag("Projectile")) {
            Destroy(gameObject, .05f);
        }
        if(collider.CompareTag("Player")) {
            print("Player Hit Enemy");
        }
    }
}
