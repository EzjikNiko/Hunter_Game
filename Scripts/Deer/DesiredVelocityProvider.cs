using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class DeerDesiredVelocityProvider : MonoBehaviour
{

    [SerializeField, Range(0, 3)]
    private float weight = 1f;

    public float Weight => weight;

    protected DeerMovement DeerMovement;

    private void Awake()
    {
        DeerMovement = GetComponent<DeerMovement>();
    }

    public abstract Vector3 GetDesiredVelocity();

}
