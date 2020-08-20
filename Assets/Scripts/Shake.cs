using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening.Core;
using DG.Tweening;

namespace ColorHoleClone
{
    public class Shake : MonoBehaviour
    {
        [SerializeField] float duration;
        [SerializeField] float strength;
        [SerializeField] int vibrato;
        [Range(0, 90)]
        [SerializeField] float randomness;

        [ContextMenu("Camera Shake Test")]
        public void ShakeObject()
        {
            transform.DOShakePosition(duration, strength, vibrato, randomness, false, true);
        }
    }
}
