using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Car : MonoBehaviour
{
    [SerializeField]
    private float _torque;


    [SerializeField]
    private List<WheelCollider> _wheelColliders;

    [SerializeField]
    private List<Wheel> _wheels;

    // Start is called before the first frame update
    void Start()
    {
        _wheelColliders = GetComponentsInChildren<WheelCollider>().ToList();
        _wheels = GetComponentsInChildren<Wheel>().ToList();

    }

    // Update is called once per frame
    void Update()
    {
        float acceleration = Input.GetAxis("Vertical");
        Move(acceleration);
    }

    private void Move(float pAcceleration)
    {
        pAcceleration = Mathf.Clamp(pAcceleration, -1, 1);
        float movement = pAcceleration * _torque;



        for (int i = 0; i < _wheelColliders.Count; i++)
        {
            WheelCollider wheelCollider = _wheelColliders[i];
            wheelCollider.motorTorque = movement;

            //Wheel wheel = _wheels[i];

            //wheelCollider.transform.Rotate(wheelCollider.rpm / 60 * 360 * Time.deltaTime, 0, 0);

        }

    }
}
