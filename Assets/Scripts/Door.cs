using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{

    public GameManager gameManager;

    void Start() {

    }

    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D other) {
        if( other.CompareTag("Player") && gameManager.hasKey) {
            print("You unlocked the door");
            gameManager.isDoorLocked = false;
        }
        else {
            print("Door is locked");
        }
    }
}
