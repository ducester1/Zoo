using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    class Hippo:MonoBehaviour
    {
        public string name;
        [SerializeField]
        private GameObject Balloon;
        [SerializeField]
        private Text text;

        public void SayHello()
        {
            Balloon.SetActive(true);
            text.text = "splash";
        }

        public void EatLeaves()
        {
            Balloon.SetActive(true);
            text.text = "munch munch lovely";
        }
    }
    
}
