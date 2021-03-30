using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    
    // Declare variables
    public Transform target;

    public float health = 5f;
    public float speed = 10f;

    Rigidbody Rigid;
    
    // Start is called before the first frame update
    void Start()
    {
        Rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // Makes it so that our enemy character follows the player within range
        Vector3 pos = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        Rigid.MovePosition(pos);
        transform.LookAt(target);
    }

    public void Damage(float amount)
    {
        health -= amount;
        if ( health == 0f)
        {
            Dead();
        }
    }

    void Dead()
    {
        Destroy(gameObject);
    }

}
