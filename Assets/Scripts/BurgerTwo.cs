using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurgerTwo : Burger
{
  private void OnMouseDown()
  {
    countClickBurger++;
    secondBurger.GetComponent<Burger>().countClickBurger++;
    if (countClickBurger == 2)
    {
      gameObject.SetActive(false);
      secondBurger.SetActive(false);
    }
  }
}
