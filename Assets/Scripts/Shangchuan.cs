using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shangchuan : MonoBehaviour
{
    public GameObject shangchantishi;
   private void OnTriggerEnter(Collider other)
   {
       if(other.CompareTag("Player")){
            shangchantishi.SetActive(true);
            Invoke("Destroy_tishi",2);
       }
   }

   private void Destroy_tishi(){
        shangchantishi.SetActive(false);
   }
}
