using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private string nameFirstObjectClick;
    [SerializeField] private string nameSecondObjectClick;
    [SerializeField] private int countClick;

    private void Update()
    {
        if (nameFirstObjectClick == null)
        {
            nameSecondObjectClick = null;
        }
    }

    private void OnMouseDown()
    {
        countClick++;
        if (countClick == 3)
        {
            countClick = 0;
        }
        print("qw");
        nameFirstObjectClick = gameObject.name;
    }
}
