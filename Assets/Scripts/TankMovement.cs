using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMovement : MonoBehaviour
{
    [SerializeField] GameObject tankPrefab;
    private GameObject tank;
    private string tankName;
    public float speed;
    private float rotationSpeed = 80;
    private int damagePoints;
    private int health;
    private float moveDirection;
    private Vector3 rotationDirection;
    private float rotation;
    private float turnValue;
    private void Update()
    {
        if(Input.GetAxis("Vertical")!=0)
        {

            moveDirection = Input.GetAxis("Vertical");
            this.tank.transform.position += this.tank.transform.rotation * Vector3.forward* speed * Time.deltaTime * moveDirection;
        
        }
        if (Input.GetAxis("Horizontal")!=0)
        {
            rotationDirection = new Vector3(0f, 1, 0f);
            rotation = Input.GetAxis("Horizontal");
            this.tank.transform.Rotate(rotationSpeed * rotationDirection * rotation * Time.deltaTime);
        }
    }

    public void SpawnTank(int type)
    {
        tank = Instantiate(tankPrefab);

        if(type == 1)
        {
            SetTankName("GREEN");
            SetSpeed(10);
            SetHealth(100);
            SetDamage(20);
        }
        else if (type == 2)
        {
            SetTankName("BLUE");
            SetSpeed(15);
            SetHealth(80);
            SetDamage(30);
        }
        else if (type == 3)
        {
            SetTankName("RED");
            SetSpeed(20);
            SetHealth(60);
            SetDamage(15);
        }
    }

    private void SetTankName(string name)       {   this.tankName = name;         }
    private void SetSpeed(int  speed)           {   this.speed = speed;           }
    private void SetHealth(int health)          {   this.health = health;         }
    private void SetDamage(int damage)          {   this.damagePoints = damage;   }
}
