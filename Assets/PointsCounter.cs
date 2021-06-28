using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointsCounter : MonoBehaviour
{
    private int totalPoints;

    public void AddPoints(int pointsAmount)
    {
        totalPoints += pointsAmount;
        Debug.Log(totalPoints);
    }
}
