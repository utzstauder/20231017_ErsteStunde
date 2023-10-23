using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 10f;

    private float direction = 0;

    // Start is called before the first frame update
    void Start()
    {
        print("Hello world!");
    }

    // Update is called once per frame
    void Update()
    {
        direction = Input.GetAxisRaw("Horizontal");

        // transform.position = transform.position + new Vector3(speed, 0, 0);
        // transform.position += new Vector3(speed, 0, 0);
        transform.position += Vector3.right * direction * speed * Time.deltaTime;
    }
}
