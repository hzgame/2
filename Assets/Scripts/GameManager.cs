using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public bool isPaused;
    public List<Items> itemsInBag=new List<Items>();
    public List<int>itemsInBagNum=new List<int>();
    public GameObject[] slots;

    private void Awake()
    {
        if(instance!=null){
            Destroy(gameObject);
        }
        instance=this;
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        DisplayItem();
    }
    private void Update()
    {
        GameState();
    }
    
    private void GameState(){
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(isPaused==false){
                Pause();
            }
            else{
                Resume();
            }

        }
    }

    private void Resume(){
        Time.timeScale=1;
        isPaused=false;
    }

    private void Pause(){
        Time.timeScale=0;
        isPaused=true;
    }

    public void DisplayItem(){
        for(int i=0;i<itemsInBag.Count;i++){
            slots[i].transform.GetChild(0).GetComponent<Image>().color=new Color(1,1,1,1);
            slots[i].transform.GetChild(0).GetComponent<Image>().sprite=itemsInBag[i].itemImage;

            slots[i].transform.GetChild(1).GetComponent<TextMesh>().color=new Color(1,1,1,1);
            slots[i].transform.GetChild(1).GetComponent<TextMesh>().text=itemsInBagNum[i].ToString();
        }
    }

}
