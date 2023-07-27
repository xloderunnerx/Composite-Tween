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
            Debug.Log("Particles Sequence Creation");
            sequence = base.GetSequence();
            var timer = duration;
            sequence.Insert(insertTime, DOTween.To(() => timer, x => timer = x, 0, duration));
            sequence.InsertCallback(insertTime, () => particleSystem.Play());
            sequence.OnComplete(() => particleSystem.Stop());
            return sequence;
        }
    }
}