using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ItemDrag : MonoBehaviour ,IBeginDragHandler,IDragHandler,IEndDragHandler
{
    private RectTransform m_RT;
    private CanvasGroup canG;
    private Vector3 originPos;
    private Vector3 originScale;

    private void Start()
    {
        canG=gameObject.GetComponent<CanvasGroup>();
        originPos=gameObject.GetComponent<Transform>().position;
        originScale=gameObject.GetComponent<Transform>().localScale;
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        canG.blocksRaycasts=false;
        canG.alpha=0.5f;
        gameObject.GetComponent<Transform>().position = Input.mousePosition;
        //隐藏数字
        for(int i=0;i<GameManager.instance.itemsInBag.Count;i++){
            GameManager.instance.slots[i].transform.GetChild(0).transform.GetChild(0).GetComponent<Text>().color=new Color(1,1,1,0);

        }
    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector3 pos;
        m_RT = gameObject.GetComponent<RectTransform>();
        //屏幕坐标到世界坐标
        RectTransformUtility.ScreenPointToWorldPointInRectangle(m_RT,eventData.position,eventData.enterEventCamera,out pos);
        m_RT.position = pos;
        //scale up
        gameObject.GetComponent<Transform>().localScale=2.0f*originScale;
    }

    void IEndDragHandler.OnEndDrag(PointerEventData eventData)
    {
        if(eventData.pointerCurrentRaycast.gameObject!=null){
            gameObject.GetComponent<Transform>().position=originPos;
            gameObject.GetComponent<Transform>().localScale=originScale;
        }
        else{
            gameObject.GetComponent<Transform>().position = Input.mousePosition;
        }
        canG.blocksRaycasts=true;
        canG.alpha=1.0f;
    }


}