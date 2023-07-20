using CompositeTween.Core;
using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CompositeTween.Node
{
    [System.Serializable]
    public class DoScaleNode : TweenNode
    {
        [SerializeField] private RectTransform transform;
        [SerializeField] private float endValue;

        public override Sequence GetSequence()
        {
            sequence = base.GetSequence();
            sequence.Insert(insertTime, transform.DOScale(endValue, duration).SetEase(ease));
            return sequence;
        }
    }
}