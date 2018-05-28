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
    public string leaveEatingText { get; set; }
    public string meatEatingText { get; set; }

    public Animal(string name, bool herbivore, bool carnivore, bool trick, string helloText, string leaveEatingText, string meatEatingText)
    {
        this.name = name;
        this.herbivore = herbivore;
        this.carnivore = carnivore;
        this.trick = trick;
        this.helloText = helloText;
        this.leaveEatingText = leaveEatingText;
        this.meatEatingText = meatEatingText;
    }

}
public class Main : MonoBehaviour
{
    private void Start()
    {
        Animal hippo = new Animal("Henk", true, false, false, "splash", "munch munch lovely", "");
        Animal lion = new Animal("Elsa", false, true, false, "roooaoaaaaar", "", "nomnomnom thx mate");
        Animal pig = new Animal("Dora", true, true, true, "oink oink", "munch munch oink", "nomnomnom oink thx");
        Animal tiger = new Animal("Wally", false, true, true, "rraaarww", "", "nomnomnom thx wubalubadubdub");
        Animal zebra = new Animal("Marty", true, false, false, "zebra zebra", "munch munch zank yee bra", "");
    }
}