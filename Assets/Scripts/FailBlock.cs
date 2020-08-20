using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RoboRyanTron.Unite2017.Events;

namespace ColorHoleClone
{
    public class FailBlock : MonoBehaviour
    {
        [SerializeField] GameEvent failEvent;

        private void OnDestroy()
        {
            failEvent.Raise();
        }
    }
}

