using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckWin : MonoBehaviour
{
    void Update()
    {
        GameObject[] rabbit = GameObject.FindGameObjectsWithTag("Rabbit");
        GameObject[] wolf = GameObject.FindGameObjectsWithTag("Wolf");
        GameObject[] lan = GameObject.FindGameObjectsWithTag("Deer");
        int rabbitCount = rabbit.Length;
        int wolfCount = wolf.Length;
        int lanCount = lan.Length;
        if (rabbitCount == 0 && wolfCount == 0 && lanCount == 0)
        {
            SceneManager.LoadScene(2);
        }

    }
}
