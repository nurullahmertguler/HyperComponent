using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TweenEffect : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        EffectStart();
    }

    Tween scaleEffectTween;
    public void EffectStart()
    {
        scaleEffectTween = transform.DOScale(transform.localScale * 1.1f, .4f).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.Linear);
    }
    void EffectEnd()
    {
        scaleEffectTween.Kill();
    }
}
