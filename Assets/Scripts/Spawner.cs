using System;
using System.Collections.Generic;
using UnityEngine;

namespace Zoo
{
    class Spawner : MonoBehaviour
    {
        [SerializeField]
        private GameObject lion, hippo, pig, tiger, zebra;
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

        private void LeaveEaters()
        {
            for (int i = 0; i < animals.Count; i++)
            {
                if (animals[i].GetComponent<Animal>().herbivore == true)
                {
                    animals[i].GetComponent<Animal>().EatLeaves();
                }
            }
        }
    }
}
