using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ColorHoleClone
{
    public interface IObstacle
    {
        void SetIsKinematic(bool isEnabled);
        void GetSucked(Transform target, float speed);
        void DestroySelf();
    }
}
