using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
{
    // Declare variables
    public float damage = 10f;
    public float range = 100f;

    public Camera FPSCam;
    // public gameObject Projectile;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        RaycastHit hit;

        // Create the bullet objects
        // Instantiate(Projectile, FPSCam.transform.forward.position, FPSCam.transform.rotation);

        if (Physics.Raycast(FPSCam.transform.position, FPSCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

            EnemyScript enemy = hit.transform.GetComponent<EnemyScript>();
            if (enemy != null)
            {
                enemy.Damage(damage);
            }


        }
    }
}
