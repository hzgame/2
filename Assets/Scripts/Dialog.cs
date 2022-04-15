using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialog : MonoBehaviour
{
   public GameObject qiao_dialog;
   private void Start()
   {
       Gameeventsystem.instance.spellingComplete_qiao+=Qiao_dialog_appear;
   }

    public void Qiao_dialog_appear(){
        qiao_dialog.SetActive(true);
        Invoke("Qiao_dialog_disappear",2);
    }

    void Qiao_dialog_disappear(){
        qiao_dialog.SetActive(false);
    }    
}
