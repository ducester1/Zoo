using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    class Pig : MonoBehaviour
    {
        public string name;
        [SerializeField]
        private GameObject Balloon;
        [SerializeField]
        private Text text;

        public void SayHello()
        {
            Balloon.SetActive(true);
            text.text = "oink oink";
        }

        public void EatLeaves()
        {
            Balloon.SetActive(true);
            text.text = "munch munch oink";
        }

        public void EatMeat()
        {
            Balloon.SetActive(true);
            text.text = "nomnomnom oink thx";
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
