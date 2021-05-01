using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(gameObject.name);
    }


    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider colider)
    {
        int addPoint = 0;
        if (gameObject.name.Contains("Gold"))
            addPoint += 5;

        if (gameObject.name.Contains("Bronze"))
            addPoint += 2;

        Score.GetScore().AddPoints(addPoint);
        Destroy(gameObject);
    }

    void OnCollisionEnter(Collision collision)
    {
        int addPoint = 0;
        if (gameObject.name.Contains("Gold"))
            addPoint += 5;

        if (gameObject.name.Contains("Bronze"))
            addPoint += 2;

        Score.GetScore().AddPoints(addPoint);
        Destroy(gameObject);
    }
}