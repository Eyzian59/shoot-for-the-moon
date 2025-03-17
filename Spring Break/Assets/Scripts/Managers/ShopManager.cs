using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopManager : MonoBehaviour
{
    public spaceshipMovement shipController;
    public MoneyManager moneyManager;

    //Upgrade Cost (Can add more upgrades)
    public int thrustUpgradeCost = 100;
    public int fuelUpgradeCost = 150;


    public void UpgradeThrust()
    {
        if (moneyManager.money >= thrustUpgradeCost)
        {
            moneyManager.money -= thrustUpgradeCost;
            //Ex: shipController.thrustForce += 2f;
            thrustUpgradeCost = Mathf.RoundToInt(thrustUpgradeCost * 1.2f); // Increase cost for next level
        }
    }

    public void UpgradeFuel()
    {
        if (moneyManager.money >= fuelUpgradeCost)
        {
            moneyManager.money -= fuelUpgradeCost;
            //Ex: shipController.maxFuel += 20f;
            fuelUpgradeCost = Mathf.RoundToInt(fuelUpgradeCost * 1.2f); // Increase cost for next level
        }
    }
}
