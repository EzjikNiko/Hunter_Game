using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class WolfDesiredVelocityProvider : MonoBehaviour
{

    [SerializeField, Range(0, 3)]
    private float weight = 1f;

    public float Weight => weight;

    protected WolfMovement WolfMovement;

    private void Awake()
    {
        WolfMovement = GetComponent<WolfMovement>();
    }

    public abstract Vector3 GetDesiredVelocity();

}
