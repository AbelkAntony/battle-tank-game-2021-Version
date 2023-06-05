using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMovement : MonoBehaviour
{
    [SerializeField] GameObject tankPrefab;
    private GameObject tank;
    private string tankName;
    public float speed;
    private float rotationSpeed;
    private int damagePoints;
    private int health;

    private void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            this.tank.transform.position = Vector3.forward * speed * Time.deltaTime;
            
        }
        if(Input.GetKey(KeyCode.RightArrow))
        {
            this.tank.transform.rotation = Quaternion.Euler(0f,rotationSpeed,0f);
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
