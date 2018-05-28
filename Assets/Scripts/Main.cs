using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal
{

    public bool herbivore { get; set; }
    public bool carnivore { get; set; }
    public bool trick { get; set; }
    public string name { get; set; }
    public string helloText { get; set; }
    public string eatingText { get; set; }

    public Animal(string name, bool herbivore, bool carnivore, bool trick, string helloText, string eatingText)
    {
        this.name = name;
        this.herbivore = herbivore;
        this.carnivore = carnivore;
        this.trick = trick;
        this.helloText = helloText;
        this.eatingText = eatingText;
    }

}
public class Main : MonoBehaviour
{


}
