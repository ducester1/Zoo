using System;
using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    class Zebra : MonoBehaviour
    {
        [SerializeField]
        private GameObject Balloon;
        [SerializeField]
        private Text text;
        public string name;


        public void SayHello()
        {
            Balloon.SetActive(true);
            text.text = "zebra zebra";
        }

        public void EatLeaves()
        {
            Balloon.SetActive(true);
            text.text = "munch munch zank yee bra";
        }
    }
}
