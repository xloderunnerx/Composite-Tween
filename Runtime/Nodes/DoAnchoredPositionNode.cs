using CompositeTween.Core;
using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CompositeTween.Node
{
    [System.Serializable]
    public class DoAnchoredPositionNode : TweenNode
    {
        [SerializeField] private RectTransform transform;
        [SerializeField] private Vector2 endAnchoredPosition;
        public override Sequence GetSequence()
        {
            sequence = base.GetSequence();
            sequence.Insert(insertTime, transform.DOAnchorPos(endAnchoredPosition, duration).SetEase(ease));
            return sequence;
        }
    }
}