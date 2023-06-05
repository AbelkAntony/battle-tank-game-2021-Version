using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    [SerializeField] TankMovement tank;
    [SerializeField] GameObject uiGreenButton;
    [SerializeField] GameObject uiBlueButton;
    [SerializeField] GameObject uiRedButton;
    private int tankColour;


    private void Awake()
    {
        UiStatus(true);
    }
    public void Green()
    {
        tank.SpawnTank(1);
        UiStatus(false);
    }

    public void Blue()
    {
        tank.SpawnTank(2);
        UiStatus(false);
    }

    public void Red()
    {
        tank.SpawnTank(3);
        UiStatus(false);
    }

    private void UiStatus(bool status)
    {
        uiGreenButton.SetActive(status);
        uiBlueButton.SetActive(status);
        uiRedButton.SetActive(status);
    }
}
