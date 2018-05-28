using System;
using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    class Lion : MonoBehaviour
    {
        [SerializeField]
        private GameObject Balloon;
        [SerializeField]
        private Text text;
        public string name;


        public void SayHello()
        {
            Balloon.SetActive(true);
            text.text = "roooaoaaaaar";
        }

        public void EatMeat()
        {
            Balloon.SetActive(true);
            text.text = "nomnomnom thx mate";
        }
    }
}
