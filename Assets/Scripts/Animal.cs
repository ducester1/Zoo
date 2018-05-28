using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    public class Animal : MonoBehaviour
    {

        public GameObject balloon;

        public bool herbivore;
        public bool carnivore;
        public bool trick;
        public string animalName;

        [SerializeField]
        private string helloText;
        [SerializeField]
        private string leaveEatingText;
        [SerializeField]
        private string meatEatingText;

        private void Start()
        {

        }

        public void SayHello()
        {
            balloon.SetActive(true);
            balloon.GetComponentInChildren<Text>().text = helloText;
        }

        public void EatLeaves()
        {
            balloon.SetActive(true);
            balloon.GetComponentInChildren<Text>().text = leaveEatingText;
        }

        public void EatMeat()
        {
            balloon.SetActive(true);
            balloon.GetComponentInChildren<Text>().text = meatEatingText;
        }
        public void PerformTrick()
        {
            StartCoroutine(DoTrick());
        }

        IEnumerator DoTrick()
        {
            for (int i = 0; i < 360; i++)
            {
                transform.localRotation = Quaternion.Euler(i, 0, 0);
                yield return new WaitForEndOfFrame();
            }
        }
    }
}