using CompositeTween.Core;
using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CompositeTween.Node
{
    [System.Serializable]
    public class DoParticleSystemEmitNode : TweenNode
    {
        [SerializeField] private ParticleSystem particleSystem;
        [SerializeField] private int count;

        public override Sequence GetSequence()
        {
            var sequence = base.GetSequence();
            var timer = 0;
            sequence.Insert(insertTime, DOTween.To(() => timer, x => timer = x, 0, duration));
            sequence.OnComplete(() => particleSystem.Emit(count));
            return sequence;
        }
    }
}