using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PivoCentral : MonoBehaviour
{
    public float percentimetro = 50f;
    public float velocidade = 2f;

    Transform Pivo;
    Transform secao1;
    Transform secao2;
    Transform secao3;

    // Start is called before the first frame update
    void Start()
    {
        Pivo = gameObject.transform;
        secao1 = Pivo.Find("Secao1");
        secao2 = secao1.Find("Secao2");
        secao3 = secao2.Find("Secao3");
    }

    // Update is called once per frame
    void Update()
    {
        float rot = 100 * Time.deltaTime;
        secao1.transform.Rotate(0f, 1 * Time.deltaTime, 0f);
        //secao2.transform.Rotate(0f, 1 * Time.deltaTime, 0f);
        secao3.transform.Rotate(0f, 1 * Time.deltaTime, 0f);

    }
}
