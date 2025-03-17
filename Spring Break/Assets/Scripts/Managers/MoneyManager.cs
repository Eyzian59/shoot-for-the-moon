using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyManager : MonoBehaviour
{
    public Transform spaceship;
    public int money = 0;
    private float maxHeight = 0f;

    void Update()
    {
        maxHeight = Mathf.Max(maxHeight, spaceship.position.y);
    }

    public void Earnings()
    {
        money += (int)maxHeight * 10;
        maxHeight = 0f;
    }
}
