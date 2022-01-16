using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seek : WolfDesiredVelocityProvider
{
    [SerializeField]
    private Transform objectToSeek;


    [SerializeField, Range(0, 10)]
    private float arriveRadius;

    public override Vector3 GetDesiredVelocity()
    {
        var distance = (objectToSeek.position - transform.position);
        if (distance.magnitude < arriveRadius)
            return (objectToSeek.position - transform.position).normalized * WolfMovement.VelocityLimit;
        else return (objectToSeek.position - transform.position).normalized * WolfMovement.VelocityLimit * 0;
    }


}
