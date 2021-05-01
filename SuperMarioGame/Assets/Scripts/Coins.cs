using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EnCoinType
{
    Gold,
    Bronze
}

public interface ICoins
{
    int TotalCoins { get; set; }
    EnCoinType CoinType { get; } //IntrinsicState()
    void GetDisplayOfCollectingCoins(); //GetExtrinsicSate()
}

