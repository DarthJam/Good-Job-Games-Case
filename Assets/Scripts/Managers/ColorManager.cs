using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;

namespace ColorHoleClone
{
    public class ColorManager : MonoBehaviour
    {
        [SerializeField] Material failBlockMat;
        [SerializeField] Material obstacleBlockMat;

        [SerializeField] Material groundMat;
        [SerializeField] List<SpriteRenderer> borderSprites = new List<SpriteRenderer>();
        [SerializeField] List<SpriteRenderer> frontSprites = new List<SpriteRenderer>();
        [SerializeField] SpriteRenderer backGroundSprite;

        [SerializeField] Image[] progressFillImages;


        [Space]
        [SerializeField] Color obstacleBlockColor;
        [SerializeField] Color failBlockColor;

        [SerializeField] Color groundColor;
        [SerializeField] Color backGroundColor;
        [SerializeField] Color borderColor;
        [SerializeField] Color frontColor;

        [SerializeField] Color progressFillColor;

        private void Start()
        {
            UpdateColors();
        }

        private void UpdateColors()
        {
            groundMat.color = groundColor;
            failBlockMat.color = failBlockColor;
            obstacleBlockMat.color = obstacleBlockColor;

            for (int i = 0; i < borderSprites.Count; i++)
            {
                borderSprites[i].color = borderColor;
            }

            for (int i = 0; i < frontSprites.Count; i++)
            {
                frontSprites[i].color = frontColor;
            }

            for (int i = 0; i < progressFillImages.Length; i++)
            {
                progressFillImages[i].color = progressFillColor;
            }

            backGroundSprite.color = backGroundColor;
        }

        // To see color changes realtime on Editor.
        private void OnValidate()
        {
            UpdateColors();
        }
    }
}
