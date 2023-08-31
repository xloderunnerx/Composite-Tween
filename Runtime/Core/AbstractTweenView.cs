using Composite.Core;
using DG.Tweening;
using Sirenix.Serialization;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CompositeTween.Core
{
    public class AbstractTweenView : AbstractView
    {
        [SerializeField] protected Sequence sequence;
        [SerializeReference]
        [OdinSerialize]
        protected List<TweenNode> tweenGroup;
        [SerializeField] protected int loops;

        public Action onComplete;

        public void RunSequence()
        {
            sequence = DOTween.Sequence();
            sequence.SetLoops(loops);
            sequence.OnComplete(() => onComplete?.Invoke());
            tweenGroup.ForEach(tweenNode =>
            {
                sequence.Join(tweenNode.GetSequence());
            });
        }

        public void StopSequence()
        {
            if (sequence != null)
                sequence.Kill();
            sequence = null;
        }
    }
}