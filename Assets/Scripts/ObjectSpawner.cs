using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    [HideInInspector]
    public int type;
    public float Mass, Torque, MaxDrop, DamperValue, StiffnessValue;

    public GameObject _carPrefab, _bikePrefab, _truckPrefab;

    // Use this for initialization
    private void Start()
    {
        switch(type)
        {
            case 0:
                Instantiate(_carPrefab, transform);
                break;

            case 1:
                Instantiate(_truckPrefab, transform);
                break;

            case 2:
                Instantiate(_bikePrefab, transform);
                break;
        }
    }
}
