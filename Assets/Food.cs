using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
   [SerializeField] private int _pointsCost;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out PointsCounter counter)) {
            counter.AddPoints(_pointsCost);
        }
    }
}
