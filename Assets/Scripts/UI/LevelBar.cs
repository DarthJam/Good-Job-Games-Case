using UnityEngine;
using UnityEngine.UI;
using RoboRyanTron.Unite2017.Sets;
using DG.Tweening;

namespace ColorHoleClone
{
    public class LevelBar : MonoBehaviour
    {
        [SerializeField] ThingRuntimeSet Set;

        [SerializeField] Image fillImage;

        private float initialCount;
        private float currentCount;


        private void Start()
        {
            //if we don't assign variables here DOTween returns a NaN
            initialCount = Set.Items.Count;
            currentCount = initialCount;

            UpdateFill();
        }


        private void Update()
        {
            if (currentCount != Set.Items.Count)
            {
                currentCount = Set.Items.Count;
                UpdateFill();
            }
        }

        public void UpdateFill()
        {
            fillImage.DOFillAmount(1f - Mathf.Clamp01(Set.Items.Count / initialCount), .4f);
        }
    }
}