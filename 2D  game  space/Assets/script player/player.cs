using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;

public class player : MonoBehaviour
{

    [SerializeField] float xValue;
    [SerializeField] float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
            xValue = Input.GetAxisRaw("Horizontal") * Time.deltaTime * moveSpeed;
            transform.Translate(xValue,0,0);
             

       

    }
}
