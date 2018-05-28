using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    class Spawner : MonoBehaviour
    {
        [SerializeField]
        private GameObject lion, hippo, pig, tiger, zebra;
        [SerializeField]
        private GameObject inputText;
        private GameObject henk, elsa, dora, wally, marty;
        private List<GameObject> animals;

        private void Start()
        {
            animals = new List<GameObject>();
            animals.Add(henk = Instantiate(hippo, transform));
            animals.Add(elsa = Instantiate(lion, transform));
            animals.Add(dora = Instantiate(pig, transform));
            animals.Add(wally = Instantiate(tiger, transform));
            animals.Add(marty = Instantiate(zebra, transform));
        }

        public void LeaveEaters()
        {
            for (int i = 0; i < animals.Count; i++)
            {
                if (animals[i].GetComponent<Animal>().herbivore == true)
                {
                    animals[i].GetComponent<Animal>().EatLeaves();
                }
            }
        }

        public void MeatEaters()
        {
            for (int i = 0; i < animals.Count; i++)
            {
                if (animals[i].GetComponent<Animal>().carnivore == true)
                {
                    animals[i].GetComponent<Animal>().EatMeat();
                }
            }
        }

        public void Tricks()
        {
            for (int i = 0; i < animals.Count; i++)
            {
                if (animals[i].GetComponent<Animal>().trick == true)
                {
                    animals[i].GetComponent<Animal>().PerformTrick();
                }
            }
        }

        public void Hello()
        {
            string text = inputText.GetComponent<Text>().text;
            if (text != "")
            {
                for (int i = 0; i < animals.Count; i++)
                {
                    if (animals[i].GetComponent<Animal>().animalName == text)
                    {
                        animals[i].GetComponent<Animal>().SayHello();
                    }
                }
            }
            else
            {
                for (int i = 0; i < animals.Count; i++)
                {
                    animals[i].GetComponent<Animal>().SayHello();
                }
            }
        }
    }
}
