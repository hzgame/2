using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class guo : MonoBehaviour
{
   private void Start()
   {
       Gameeventsystem.instance.spellingComplete_guo+=nextscene;
   }

   private void nextscene()
   {
       Debug.Log("guo");
        SceneManager.LoadScene(2);
   }
}
