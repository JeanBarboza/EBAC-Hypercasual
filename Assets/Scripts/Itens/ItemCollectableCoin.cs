using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollectableCoin : ItemCollectableBase
{
    public Collider2D colliderCoins;
    protected override void OnCollect()
    {
        base.OnCollect();
        ItemManager.Instance.AddCoins();
        colliderCoins.enabled = false;
    }
}
