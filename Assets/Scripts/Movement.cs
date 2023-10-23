using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 10f;

    private float direction = 0;

    void Update()
    {
        direction = Input.GetAxisRaw("Horizontal");
        transform.position += Vector3.right * direction * speed * Time.deltaTime;
    }
}
