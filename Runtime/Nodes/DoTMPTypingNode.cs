using CompositeTween.Core;
using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

namespace CompositeTween.Node
{
    [System.Serializable]
    public class DoTMPTypingNode : TweenNode
    {
        [SerializeField] private TextMeshProUGUI textMeshPro;
        [SerializeField] [TextArea(3, 100)] private string text;
        public override Sequence GetSequence()
        {
            sequence = base.GetSequence();

            var counter = 0;
            sequence.Insert(insertTime, DOTween.To(() => counter, x => { counter = x; textMeshPro.text = text.Substring(0, x); }, text.Length, duration));

            return sequence;
        }
    }
}