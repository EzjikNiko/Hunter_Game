using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] private GameObject Cam;
    void Start()
    {
        Instantiate(Cam, new Vector3(0, 0, 10), Quaternion.identity);
    }
}
