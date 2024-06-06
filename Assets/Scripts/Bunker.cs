using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bunker : MonoBehaviour
{
   private void OnTriggerEnter2D(Collider2D other)
   {
      if (other.gameObject.layer == LayerMask.NameToLayer("ınvader"))
      {
         this.gameObject.SetActive(false);
      }
   }
}
