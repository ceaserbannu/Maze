using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinFactory : MonoBehaviour
{
    public static int ObjectsCount = 0;
    private Dictionary<EnCoinType, ICoins> _coinObjects;
    public ICoins GetCoinsToDisplay(EnCoinType form) // Same as GetFlyWeight()
    {
        if (_coinObjects == null)
            _coinObjects = new Dictionary<EnCoinType, ICoins>();
        if (_coinObjects.ContainsKey(form))
        {
            _coinObjects[form].TotalCoins++;
            return _coinObjects[form];
        }
        switch (form)
        {
            case EnCoinType.Gold:
                _coinObjects.Add(form, new GoldCoin());
                ObjectsCount++;
                break;
            case EnCoinType.Bronze:
                _coinObjects.Add(form, new BronzeCoin());
                ObjectsCount++;
                break;
            default:
                break;
        }
        return _coinObjects[form];
    }
}