using CompositeTween.Core;
using DG.Tweening;
using UnityEngine;

namespace CompositeTween.Node
{
    [System.Serializable]
    public class DoParticleSystemPlayNode : TweenNode
    {
        [SerializeField] private ParticleSystem particleSystem;

        public override Sequence GetSequence()
        {
            sequence = base.GetSequence();
            var timer = duration;
            sequence.Insert(insertTime, DOTween.To(() => timer, x => timer = x, 0, duration));
            sequence.OnRewind(() => particleSystem.Play());
            sequence.OnStart(() => particleSystem.Play());
            sequence.OnComplete(() => particleSystem.Stop());
            return sequence;
        }
    }
}