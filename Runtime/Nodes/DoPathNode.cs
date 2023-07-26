using CompositeTween.Core;
using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace CompositeTween.Node
{
    public class DoPathNode : TweenNode
    {
        [SerializeField] private RectTransform transform;
        [SerializeField] private List<RectTransform> path;
        [SerializeField] private PathType pathType;

        public override Sequence GetSequence()
        {
            var sequence = base.GetSequence();
            sequence.Insert(insertTime, transform.DOPath(path.Select(pathNode => pathNode.transform.position).ToArray(), duration, pathType));
            return sequence;
        }
    }
}