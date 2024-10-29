using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float input = UnityEngine.Input.GetAxis("Horizontal");
        transform.Translate(input * speed * Time.deltaTime * Vector3.right);
    }
}
