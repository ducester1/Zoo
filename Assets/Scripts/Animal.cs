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
        [SerializeField]
        private bool trick;
        [SerializeField]
        private string animalName;
        [SerializeField]
        private string helloText;
        [SerializeField]
        private string leaveEatingText;
        [SerializeField]
        private string meatEatingText;

        private void Start()
        {
        }

        public void EatLeaves()
        {
            if (herbivore == true)
            {
                balloon.SetActive(true);
                balloon.GetComponentInChildren<Text>().text = leaveEatingText;
            }
        }
    }
}