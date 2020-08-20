using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ColorHoleClone
{
    [RequireComponent(typeof(Rigidbody))]
    public class Obstacle : MonoBehaviour, IObstacle
    {
        Rigidbody rb;

        private void Awake()
        {
            rb = GetComponent<Rigidbody>();
            rb.isKinematic = true;
        }

        public void GetSucked(Transform target, float suckSpeed)
        {
            Vector3 dir = target.transform.position - transform.position;

            rb.AddForce(dir * Time.deltaTime * suckSpeed, ForceMode.Force);
        }

        public void SetIsKinematic(bool isEnabled)
        {
            rb.isKinematic = isEnabled;
        }

        public void DestroySelf()
        {
            Destroy(gameObject);
        }
    }
}
