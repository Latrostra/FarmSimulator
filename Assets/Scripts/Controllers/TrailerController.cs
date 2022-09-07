using System.Collections.Generic;
using UnityEngine;

namespace Controllers
{
    public class TrailerController : MonoBehaviour
    {
        public Item item;
        public bool isTrailed;

        public List<Transform> points;

        private bool isActive;

        private void Awake()
        {
            foreach (Transform child in transform)
            {
                points.Add(child);
            }
        }

        public void Pull(Vector3 hookPosition, float vehicleSpeed)
        {
            Vector3 direction = (hookPosition - transform.position).normalized;
            float distance = Vector3.Distance(hookPosition, transform.position);

            if (distance > 2f)
            {
                transform.Translate(Vector3.up * Time.deltaTime * vehicleSpeed);
            }
            else if (distance > .5f)
            {
                transform.Translate(Vector3.up * Time.deltaTime * vehicleSpeed / 1.5f);
            }

            FaceVehicle(direction);
        }

        private void Use()
        {
            foreach (Transform point in points)
            {
                //item.createdTile.InstantiatePrefab(GridManager.Instance.GetTilemap(), GridManager.Instance.GetWorldPosition(point.position));
            }
        }

        private void FixedUpdate()
        {
            if (isActive)
            {
                Use();
            }
        }

        public void SwitchActivity()
        {
            if (item && isActive == false)
            {
                isActive = true;
            }
            else
            {
                Deactivate();
            }
        }

        public void Deactivate()
        {
            isActive = false;
        }

        private void FaceVehicle(Vector3 direction)
        {
            Quaternion lookRotation = Quaternion.LookRotation(Vector3.forward, direction);
            transform.rotation = lookRotation;
        }
    }
}
