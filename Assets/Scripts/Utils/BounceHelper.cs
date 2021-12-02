using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class BounceHelper : MonoBehaviour
{
    [Header("Animation")]
    public float scaleDuration = .1f;
    public float scaleBounce = 1.2f;
    public float scaleDurationPlayer = .3f;
    public float scaleBouncePlayer = 2f;
    public Ease ease = Ease.OutBack;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            Bounce();
        }
    }

    public void Bounce()
    {
        transform.DOScale(scaleBounce, scaleDuration).SetEase(ease).SetLoops(2, LoopType.Yoyo);
    }
    
    public void BouncePlayer()
    {
        transform.DOScale(scaleBouncePlayer, scaleDurationPlayer).SetEase(ease).SetLoops(2, LoopType.Yoyo);
    }
}
