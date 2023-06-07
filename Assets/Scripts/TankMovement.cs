using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMovement : MonoBehaviour
{
    [SerializeField] GameObject greenTankPrefab;
    [SerializeField] GameObject blueTankPrefab;
    [SerializeField] GameObject redTankPrefab;
    private GameObject tank;
    public float speed;
    public float rotationSpeed;
    public int damagePoints;
    public int health;
    private float moveDirection;
    private Vector3 rotationDirection;
    private float rotation;
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
        

        if(type == 1)
        {
            tank = Instantiate(greenTankPrefab);
            SetSpeed(10);
            SetHealth(100);
            SetDamage(20);
            SetRotationSpeed(80);
        }
        else if (type == 2)
        {
            tank = Instantiate(blueTankPrefab);
            SetSpeed(15);
            SetHealth(80);
            SetDamage(30);
            SetRotationSpeed(100);
        }
        else if (type == 3)
        {
            tank = Instantiate(redTankPrefab);
            SetSpeed(20);
            SetHealth(60);
            SetDamage(15);
            SetRotationSpeed(120);
        }
    }

    private void SetSpeed(int  speed)           {   this.speed = speed;           }
    private void SetHealth(int health)          {   this.health = health;         }
    private void SetDamage(int damage)          {   this.damagePoints = damage;   }
    private void SetRotationSpeed(int speed)    {   this.rotationSpeed = speed;   }
}
