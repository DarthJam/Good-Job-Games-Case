using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

namespace ColorHoleClone
{
    public class OnChangePosition : MonoBehaviour
    {
        [SerializeField] private PolygonCollider2D hole2DCollider;
        [SerializeField] private PolygonCollider2D ground2DCollider;
        [SerializeField] private MeshCollider GeneratedMeshCollider;

        private Mesh GeneratedMesh;

        private float initialScale = .65f;

        private void FixedUpdate()
        {
            if (transform.hasChanged)
            {
                transform.hasChanged = false;
                hole2DCollider.transform.position = new Vector2(transform.position.x, transform.position.z);
                hole2DCollider.transform.localScale = transform.localScale * initialScale;
                MakeHole2D();
                Make3DMeshCollider();
            }
        }
        private void MakeHole2D()
        {
            Vector2[] PointPositions = hole2DCollider.GetPath(0);

            for (int i = 0; i < PointPositions.Length; i++)
            {
                PointPositions[i] = hole2DCollider.transform.TransformPoint(PointPositions[i]);
            }

            ground2DCollider.pathCount = 2;

            ground2DCollider.SetPath(1, PointPositions);
        }

        private void Make3DMeshCollider()
        {
            if (GeneratedMesh != null)
                Destroy(GeneratedMesh);

            GeneratedMesh = ground2DCollider.CreateMesh(true, true);
            GeneratedMeshCollider.sharedMesh = GeneratedMesh;
        }
    }
}
