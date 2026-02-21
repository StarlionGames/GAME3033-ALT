using Godot;
using System;

public partial class StatList
{
    public Stat pop, appear, athle, poise, intel;
    
    public StatList()
    {
        pop = new Stat("Popularity", 1200, 75);
        appear = new Stat("Appearance", 1200, 90);
        athle = new Stat("Athletics", 1200, 50);
        poise = new Stat("Poise", 1200, 100);
        intel = new Stat("Intelligence", 1200, 109);
    }
}
