using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    public float speed = 3.0f;
    private Rigidbody enemyRb;
    private GameObject player;

    void Update()
    {
        if(transform.position.y < -10){
            Destroy(gameObject);
        }

        Vector3 lookDirection = (player.transform.position - transform.position).normalized;

        enemyRb.AddForce(lookDirection * speed);
    }
}
