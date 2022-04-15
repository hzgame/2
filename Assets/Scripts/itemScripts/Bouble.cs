using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouble : MonoBehaviour
{
    public GameObject cube, flame, buoble;
    public Transform _transform,_transform_origin;

    private void Start()
    {
        MouseManager.Instance.OnMouseClicked_Buoble += Boom;
        _transform_origin=GetComponent<Transform>();
    }

    public void Boom(Vector3 target)
    {
        Instantiate(cube, _transform_origin.position, _transform.rotation, _transform);
        Destroy(buoble);
        Instantiate(flame, _transform_origin.position, _transform.rotation, _transform);
    }
}
