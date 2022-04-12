using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Bag : MonoBehaviour,IPointerEnterHandler,IPointerExitHandler
{
     public void OnPointerEnter(PointerEventData eventData)
    {
       
        Cursor.SetCursor(MouseManager.Instance.interact,new Vector2(20,0),CursorMode.Auto);
        
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Cursor.SetCursor(MouseManager.Instance.normal,new Vector2(0,0),CursorMode.Auto);
    }
}
