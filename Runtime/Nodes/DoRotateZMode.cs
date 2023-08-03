using CompositeTween.Core;
using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CompositeTween.Node
{
    [System.Serializable]
    public class DoRotateZMode : TweenNode
    {
        [SerializeField] private RectTransform transform;
        [SerializeField] private float endZValue;
        [SerializeField] private RotateMode rotateMode;

        public override Sequence GetSequence()
        {
            sequence = base.GetSequence();
            sequence.Insert(insertTime, transform.DORotate(new Vector3(0, 0, endZValue), duration, rotateMode).SetEase(ease));
            return sequence;
        }
    }
}