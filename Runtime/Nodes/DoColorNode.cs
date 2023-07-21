using CompositeTween.Core;
using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace CompositeTween.Node
{
    [System.Serializable]
    public class DoColorNode : TweenNode
    {
        [SerializeField] private Image image;
        [SerializeField] private Color endColor;

        public override Sequence GetSequence()
        {
            sequence = base.GetSequence();
            sequence.Insert(insertTime, image.DOColor(endColor, duration).SetEase(ease));
            sequence.Insert(insertTime, image.DOFade(endColor.a, duration).SetEase(ease));
            return sequence;
        }
    }
}