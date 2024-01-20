using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Burger : IceCream
{
   public int countClickBurger;
   public GameObject secondBurger;

   private void Update()
   {
       if (countClickIceCream == 1)
       {
           countClickBurger = 0;
       }
   }
   
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
