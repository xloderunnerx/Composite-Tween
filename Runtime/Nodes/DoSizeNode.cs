using CompositeTween.Core;
using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CompositeTween.Node
{
    [System.Serializable]
    public class DoSizeNode : TweenNode
    {
        [SerializeField] private RectTransform transform;
        [SerializeField] private Vector2 endSize;

        public override Sequence GetSequence()
        {
            sequence = base.GetSequence();
            sequence.Insert(insertTime, transform.DOSizeDelta(endSize, duration)).SetEase(ease);
            return sequence;
        }
    }
}