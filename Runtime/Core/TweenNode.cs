using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CompositeTween.Core
{
    [System.Serializable]
    public class TweenNode
    {
        protected Sequence sequence;
        [SerializeField] protected Ease ease;
        [SerializeField] protected float duration;
        [SerializeField] protected float insertTime;

        public virtual Sequence GetSequence()
        {
            sequence = DOTween.Sequence();
            return sequence;
        }
    }
}