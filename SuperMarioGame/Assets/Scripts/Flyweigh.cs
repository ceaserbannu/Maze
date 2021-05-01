using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flyweigh : MonoBehaviour
{
    private readonly List<Vector3> BRONZE_COINS = new List<Vector3>() {
        new Vector3(-10.71f, 2.34f),
        new Vector3(-12.36f, 0.81f),
        new Vector3(-7.02f, 0.41f),
        new Vector3(-2.06f, 0.07f)
    };

    private readonly List<Vector3> GOLD_COINS = new List<Vector3>() {
        new Vector3(-8.14f, 2.14f),
        new Vector3(9.8f, -0.11f),
        new Vector3(0.35f, 1.12f),
        new Vector3(2.58f, 0.01f)
    };

    public void CollectCoin(Vector3 vector)
    {
        var coinFactory = new CoinFactory();
        ICoins graphicalCoinObj = null;


        if (Contains(vector, BRONZE_COINS))
        {
            graphicalCoinObj = coinFactory.GetCoinsToDisplay(EnCoinType.Bronze);
        }
        else if (Contains(vector, GOLD_COINS))
        {
            graphicalCoinObj = coinFactory.GetCoinsToDisplay(EnCoinType.Gold);
        }
        else
        {
            return;
        }

        graphicalCoinObj.GetDisplayOfCollectingCoins();

    }

    private bool Contains(Vector3 vector, List<Vector3> vectors)
    {
        return vectors.FindIndex((v) => v.y == vector.y && v.x == vector.x) > 0;
    }

    public void CollectCoin(string coinType)
    {
        var coinFactory = new CoinFactory();
        ICoins graphicalCoinObj = null;

        if (coinType == "Gold")
            graphicalCoinObj = coinFactory.GetCoinsToDisplay(EnCoinType.Gold);
        else
            graphicalCoinObj = coinFactory.GetCoinsToDisplay(EnCoinType.Bronze);

        graphicalCoinObj.GetDisplayOfCollectingCoins();
    }


}