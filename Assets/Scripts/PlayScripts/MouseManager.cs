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

    public event Action<Vector3> OnMouseClicked;

    private void Awake()
    {
        Instance = this;
        
    }
    private void Update()
    {
        SetCursorTexture();
        MouseContro();
        //_distance = Vector3.Distance(GameManager.instance.player.transform.position,
            //GameManager.instance.house.transform.position);
    }

    private void SetCursorTexture()
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
                Debug.Log(GameManager.instance._Dis);
                if (GameManager.instance._Dis<dis)
                {
                    GameManager.instance.guo.SetActive(true);
                    Invoke("UIdisapper",2);
                }
                
            }
        }
    }//鼠标点击地面进行移动

    void UIdisapper()
    {
        GameManager.instance.guo.SetActive(false);
    }

   
}
