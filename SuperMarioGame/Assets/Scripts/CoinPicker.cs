using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPicker : MonoBehaviour
{
    // private float coin = 0;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            gameObject.SetActive(false);
            //Destroy(gameObject);
        }
    }

    //private void OnTriggerEnter(Collider colider)
    //{
    //    int addPoint = 0;
    //    if (gameObject.name.Contains("Gold"))
    //        addPoint += 5;

    //    if (gameObject.name.Contains("Bronze"))
    //        addPoint += 2;

    //    //Score.GetScore().AddPoints(addPoint);
    //    Destroy(gameObject);
    //}

    //void OnCollisionEnter(Collision collision)
    //{
    //    int addPoint = 0;
    //    if (gameObject.name.Contains("Gold"))
    //        addPoint += 5;

    //    if (gameObject.name.Contains("Bronze"))
    //        addPoint += 2;

    //    //Score.GetScore().AddPoints(addPoint);
    //    Destroy(gameObject);
    //}
}
