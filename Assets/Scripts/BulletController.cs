using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{

    [SerializeField] GameObject bulletPrefab;
    private GameObject bullet;
    private GameObject tank;
    private Vector3 tankPosition;
    void Update()
    {
        
        tankPosition = transform.position;
        gameObject.transform.position =  tankPosition;
        Fire();       

    }

    void Fire()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
           // tank = FindObjectOfType<Tank>();
            bullet = Instantiate(bulletPrefab);
            bullet.GetComponent<Rigidbody>().velocity = transform.forward * 5f;
        }
    }
}
