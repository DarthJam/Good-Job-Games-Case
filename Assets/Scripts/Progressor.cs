using UnityEngine;
using DG.Tweening;
using RoboRyanTron.Unite2017.Events;

namespace ColorHoleClone
{
    public class Progressor : MonoBehaviour
    {
        [SerializeField] GameObject hole;
        [SerializeField] Transform holeTarget;

        [SerializeField] GameObject cam;
        [SerializeField] Transform cameraTarget;

        [SerializeField] GameEvent startProgress;
        [SerializeField] GameEvent endprogress;

        [ContextMenu("Progress Test")]
        public void Progress()
        {
            Sequence progressSequence = DOTween.Sequence();

            progressSequence.Append(hole.transform.DOMoveX(0f, 1.3f, false).OnPlay(startProgress.Raise));
            progressSequence.Append(hole.transform.DOMove(holeTarget.transform.position, 3f, false));
            progressSequence.Join(cam.transform.DOMove(cameraTarget.transform.position, 3f, false).OnComplete(endprogress.Raise));
        }
    }
}