using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tests : MonoBehaviour
{
    Transform tObject;
    Transform eixo1;
    Transform eixo2;

    // Start is called before the first frame update
    void Start()
    {
        //tObject = gameObject.transform.GetChild(0);
        tObject = gameObject.transform;
        eixo1 = tObject.Find("Eixo1");
        eixo2 = eixo1.Find("Eixo2");
    }

    // Update is called once per frame
    void Update()
    {
        float rot = 100 * Time.deltaTime;
        eixo1.transform.Rotate(0f, 0f, 10 * Time.deltaTime);
        eixo2.transform.Rotate(0f, 0f, 10 * Time.deltaTime);

    }
}
