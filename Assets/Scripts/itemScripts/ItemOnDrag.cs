using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemOnDrag : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private RectTransform recTrans;
    private CanvasGroup canG;

    private void Start()
    {
        recTrans=GetComponent<RectTransform>();
        canG=GetComponent<CanvasGroup>();
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        canG.blocksRaycasts=false;
        canG.alpha=0.5f;
    }

    public void OnDrag(PointerEventData eventData)
    {
       Vector3 viewPoint=Camera.main.ScreenToViewportPoint(Input.mousePosition);
       transform.position=viewPoint;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        canG.blocksRaycasts=true;
        canG.alpha=1.0f;
    }
}
