using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjMove : MonoBehaviour
{
    private float timer;
    private Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
        pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        Vector3 rPos = pos;
        rPos.x += Mathf.Sin(timer) * 200;

        transform.position = rPos;
    }
}
