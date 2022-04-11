using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MouseManager : MonoBehaviour
{
    public static MouseManager Instance;
    RaycastHit hitInfo;

    public event Action<Vector3> OnMouseClicked;

    private void Awake()
    {
        Instance = this;
    }
    private void Update()
    {
        SetCursorTexture();
        MouseContro();
    }

    private void SetCursorTexture()
    {
        Ray _ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(_ray, out hitInfo))
        {
            //change cursor textrue
        }
    }

    private void MouseContro()
    {
        if (Input.GetMouseButtonDown(0) && hitInfo.collider != null&&UIManager.instance.inventoryState==false)
        {
            if (hitInfo.collider.gameObject.CompareTag("Ground"))
                OnMouseClicked?.Invoke(hitInfo.point);
        }
    }//鼠标点击地面进行移动
}
