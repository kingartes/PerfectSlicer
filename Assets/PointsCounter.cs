using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointsCounter : MonoBehaviour
{
    private int _totalPoints;

    public void AddPoints(int pointsAmount)
    {
        _totalPoints += pointsAmount;
        Debug.Log(_totalPoints);
    }
}
