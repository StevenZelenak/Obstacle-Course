using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movers : MonoBehaviour
{
    [SerializeField] float moveSpeed = 4.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xValue = (Input.GetAxis("Horizontal") * moveSpeed) * Time.deltaTime;
        float zValue = (Input.GetAxis("Vertical") * moveSpeed) * Time.deltaTime;
        transform.Translate(xValue,0,zValue);
    }
}
