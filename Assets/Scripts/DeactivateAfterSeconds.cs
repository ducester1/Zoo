using System;
using System.Collections;
using UnityEngine;

namespace Zoo
{
    public class DeactivateAfterSeconds : MonoBehaviour
    {

        [SerializeField]
        private float seconds;
        private void OnEnable()
        {
            StartCoroutine(Deactivate());
        }

        private IEnumerator Deactivate()
        {
            yield return new WaitForSeconds(seconds);
            gameObject.SetActive(false);
        }
    }
}