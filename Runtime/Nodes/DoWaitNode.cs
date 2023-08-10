using CompositeTween.Core;
using DG.Tweening;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace CompositeTween.Node
{
    [System.Serializable]
    public class DoWaitNode : TweenNode
    {
        public override Sequence GetSequence()
        {
            var sequence = base.GetSequence();
            var timer = 0;
            sequence.Insert(insertTime, DOTween.To(() => timer, x => timer = x, 0, duration));
            return sequence;
        }
    }
}
