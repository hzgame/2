using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class watermove : MonoBehaviour
{
    public Transform transform;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = transform.position;
    }
}
