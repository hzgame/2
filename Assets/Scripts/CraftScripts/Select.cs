using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Select : MonoBehaviour
{
    public GameObject mode_1;
    public GameObject mode_2;
    public GameObject mode_3;
    public GameObject mode_4;
    public GameObject mode_5;
    void Start() {
        mode_1.gameObject.SetActive(false);
        mode_2.gameObject.SetActive(false);
        mode_3.gameObject.SetActive(false);
        mode_4.gameObject.SetActive(false);
        mode_5.gameObject.SetActive(false);
    }
    public void click1() {
        mode_1.gameObject.SetActive(true);
        mode_2.gameObject.SetActive(false);
        mode_3.gameObject.SetActive(false);
        mode_4.gameObject.SetActive(false);
        mode_5.gameObject.SetActive(false);
    }
    public void click2()
    {
        mode_1.gameObject.SetActive(false);
        mode_2.gameObject.SetActive(true);
        mode_3.gameObject.SetActive(false);
        mode_4.gameObject.SetActive(false);
        mode_5.gameObject.SetActive(false);
    }
    public void click3()
    {
        mode_1.gameObject.SetActive(false);
        mode_2.gameObject.SetActive(false);
        mode_3.gameObject.SetActive(true);
        mode_4.gameObject.SetActive(false);
        mode_5.gameObject.SetActive(false);
    }
    public void click4()
    {
        mode_1.gameObject.SetActive(false);
        mode_2.gameObject.SetActive(false);
        mode_3.gameObject.SetActive(false);
        mode_4.gameObject.SetActive(true);
        mode_5.gameObject.SetActive(false);
    }
    public void click5()
    {
        mode_1.gameObject.SetActive(false);
        mode_2.gameObject.SetActive(false);
        mode_3.gameObject.SetActive(false);
        mode_4.gameObject.SetActive(false);
        mode_5.gameObject.SetActive(true);
    }
}
