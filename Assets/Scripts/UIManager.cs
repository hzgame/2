using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject invertoryMenu;
    public bool inventoryState;
    public static UIManager instance;

    private void Awake()
    {
        if(instance!=null){
            Destroy(gameObject);
        }
        instance=this;
    }

    private void Start()
    {
        invertoryMenu.gameObject.SetActive(false);
    }
    private void Update()
    {
        invertoryctrl();
    }

    private void invertoryctrl()
    {
        if(Input.GetKeyDown(KeyCode.E)){
            if(GameManager.instance.isPaused==false&&inventoryState==false){
                invertoryMenu.gameObject.SetActive(true);
                inventoryState=true;
            }
            else{
                invertoryMenu.gameObject.SetActive(false);
                inventoryState=false;
            }
        }
        
    }//按E键打开背包，再按关闭
}
