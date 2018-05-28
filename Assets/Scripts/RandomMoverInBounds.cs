using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zoo
{
    public class RandomMoverInBounds : MonoBehaviour
    {
        [SerializeField]
        private int left, right, top, bottum;
        [SerializeField]
        private float speed;

        private Vector3 goal;

        private void Start()
        {
            PickGoal();
        }

        private void Update()
        {
            Vector3 direction = goal - transform.localPosition;
            transform.Translate(direction.normalized * speed * Time.deltaTime);
            if (direction.magnitude < 5)
                PickGoal();
        }

        private void PickGoal()
        {
            goal = new Vector2(
                Random.Range(left, right),
                Random.Range(bottum, top));
        }
    }
}