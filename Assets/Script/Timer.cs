using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    private TextMesh textMesh;
    public float time;

    // Start is called before the first frame update
    void Start()
    {
        textMesh = gameObject.GetComponent<TextMesh>();
        textMesh.text = Mathf.CeilToInt(time).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;

        textMesh.text = Mathf.CeilToInt(time).ToString();

        if (time <= 0)
        {
            Destroy(gameObject);
        }
    }
}
