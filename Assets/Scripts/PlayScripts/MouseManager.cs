using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MouseManager : MonoBehaviour
{
    public static MouseManager Instance;
    public Texture2D normal,interact;
    RaycastHit hitInfo;
    //public GameObject house;
    //private float _distance;
    public float dis;
    public event Action<Vector3> OnMouseClicked_Boat;
    
    public event Action<Vector3> OnMouseClicked;
    public event Action<Vector3> OnMouseClicked_Buoble;

    private void Awake()
    {
        Instance = this;
        
    }
    private void Update()
    {
        SetCursorTexture();
         if (Input.GetMouseButtonDown(0))
        {
            //当前检测到的是否是UI层   
            if (EventSystem.current.IsPointerOverGameObject())
            {
                //
            }
            else MouseContro();
        //_distance = Vector3.Distance(GameManager.instance.player.transform.position,
            //GameManager.instance.house.transform.position);
        }
    }

    public void SetCursorTexture()
    {
        Ray _ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(_ray, out hitInfo))
        {
            //ange cursor textrue
            if(hitInfo.collider.gameObject.CompareTag("Interact")){
                Cursor.SetCursor(interact,new Vector2(20,0),CursorMode.Auto);
            }else{
                Cursor.SetCursor(normal,new Vector2(0,0),CursorMode.Auto);
            }
        }
    }

    private void MouseContro()
    {
        if (Input.GetMouseButtonDown(0) && hitInfo.collider != null&&UIManager.instance.inventoryState==false)
        {
            if (hitInfo.collider.gameObject.CompareTag("Ground"))
                OnMouseClicked?.Invoke(hitInfo.point);
            if (hitInfo.collider.gameObject.CompareTag("house"))
            {
                Debug.Log(GameManager.instance._Dis1);
                if (GameManager.instance._Dis1<dis)
                {
                    GameManager.instance.guo.SetActive(true);
                    Invoke("UIdisapper1",2);
                }
                
            }
            if (hitInfo.collider.gameObject.CompareTag("box"))
            {
                Debug.Log(GameManager.instance._Dis2);
                if (GameManager.instance._Dis2<dis)
                {
                    Debug.Log("lll");
                    GameManager.instance.di.SetActive(true);
                    Invoke("UIdisapper2",5);
                }
                
            }

             if(hitInfo.collider.gameObject.CompareTag("Bouble"))
            {
               OnMouseClicked_Buoble?.Invoke(hitInfo.point);
            } 
            
            if (hitInfo.collider.gameObject.CompareTag("Water"))
            {
                OnMouseClicked_Boat?.Invoke(hitInfo.point);
            }
        }
    }//鼠标点击地面进行移动

    void UIdisapper1()
    {
        GameManager.instance.guo.SetActive(false);
    }
    void UIdisapper2()
    {
        GameManager.instance.di.SetActive(false);
    }
   
}

