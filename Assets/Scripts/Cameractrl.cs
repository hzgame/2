using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameractrl : MonoBehaviour
{
   public Transform target;
   public float smooth;
   public Vector3 dist;

   private void Start()
   {
       dist=transform.position-target.position;
   }

   private void LateUpdate()
   {
        if(target!=null){
            if(transform.position!=target.position){
                Vector3 targetPos=target.position;
                transform.position=Vector3.Lerp(transform.position,targetPos,smooth)+dist;
            }
        }    
   }


}
