using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{

    [SerializeField] GameObject bulletPrefab;
    [SerializeField] GameObject gunPoint;
    private GameObject bullet;
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
            Fire();       

    }

    void Fire()
    {
        
        {
            bullet = Instantiate(bulletPrefab,gunPoint.transform.position , gunPoint.transform.rotation);
            bullet.GetComponent<Rigidbody>().velocity = transform.forward * 20f;
        }
    }


}
