using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController : MonoBehaviour
{
    [SerializeField] GameObject greenTankPrefab;
    [SerializeField] GameObject blueTankPrefab;
    [SerializeField] GameObject redTankPrefab;
    private GameObject tank;
    public float speed;
    public float rotationSpeed;
    public float damagePoints;
    public float health;
    private float moveDirection;
    private Vector3 rotationDirection;
    private float rotation;
    private void Update()
    {
        TankMovement();
    }

    public void SpawnTank(int option)
    {
        
        switch(option)
        {
            case 1: TankSpec(greenTankPrefab, 10, 100, 20, 80);
                break;
            case 2: TankSpec(blueTankPrefab, 15, 80, 30, 120);
                break;
            case 3: TankSpec(redTankPrefab, 20, 60, 15, 120);
                break;
        }
     
    }

    void TankMovement()
    {
        if (Input.GetAxis("Vertical") != 0)
        {

            moveDirection = Input.GetAxis("Vertical");
            this.tank.transform.position += this.tank.transform.rotation * Vector3.forward * speed * Time.deltaTime * moveDirection;

        }
        if (Input.GetAxis("Horizontal") != 0)
        {
            rotationDirection = new Vector3(0f, 1, 0f);
            rotation = Input.GetAxis("Horizontal");
            this.tank.transform.Rotate(rotationSpeed * rotationDirection * rotation * Time.deltaTime);
        }
    }
    void TankSpec(GameObject tank ,float speed, float health, float damagePoints, float rotationSpeed )
    {
        this.tank = Instantiate(tank);
        this.speed = speed;
        this.health = health;
        this.damagePoints = damagePoints;
        this.rotationSpeed = rotationSpeed;  
    }

}
