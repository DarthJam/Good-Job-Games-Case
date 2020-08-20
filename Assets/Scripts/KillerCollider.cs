using UnityEngine;

namespace ColorHoleClone
{
    public class KillerCollider : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            other.gameObject.GetComponent<IObstacle>()?.DestroySelf();
        }
    }
}
