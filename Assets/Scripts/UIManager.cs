using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject invertoryMenu;
    public GameObject craftMenu;
    public bool inventoryState,craftState;
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
        //craftMenu.gameObject.SetActive(false);
    }
    private void Update()
    {
        
    }

    public void invertoryctrl()
    {
        //按E键打开背包，再按关闭
        /*if(Input.GetKeyDown(KeyCode.E)){
            if(GameManager.instance.isPaused==false&&inventoryState==false){
                invertoryMenu.gameObject.SetActive(true);
                inventoryState=true;
            }
            else{
                invertoryMenu.gameObject.SetActive(false);
                inventoryState=false;
            }
        }
        
    }*/
    //点击按钮打开背包
     if(GameManager.instance.isPaused==false&&inventoryState==false){
                invertoryMenu.gameObject.SetActive(true);
                //craftMenu.gameObject.SetActive(true);
                craftState=true;
                inventoryState=true;
                Debug.Log("bag is open");
            }
            else{
                invertoryMenu.gameObject.SetActive(false);
                //craftMenu.gameObject.SetActive(false);
                craftState=false;
                inventoryState=false;
                Debug.Log("bag is close");
            }
    }

}
