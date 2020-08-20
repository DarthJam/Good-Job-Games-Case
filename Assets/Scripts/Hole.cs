using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ColorHoleClone
{
    public class Hole : MonoBehaviour
    {
        [SerializeField] private Transform suckTarget;
        [SerializeField] private float suctionStrength;

        private void OnTriggerEnter(Collider other)
        {
            IObstacle suckable;

            if (other.GetComponent<IObstacle>() != null)
            {
                suckable = other.GetComponent<IObstacle>();

                suckable.SetIsKinematic(false);
            }
        }

        private void OnTriggerStay(Collider other)
        {
            if (other.GetComponent<IObstacle>() != null)
            {
                other.GetComponent<IObstacle>().GetSucked(suckTarget, suctionStrength);
            }
        }
    }
}
