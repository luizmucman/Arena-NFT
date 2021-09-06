using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Damage Resistances Profile", menuName = "Damage Resistances")]
public class DamageResistances : ScriptableObject
{
    public struct Resistance
    {
        public Elements element;
        public float percentageToTake;
    }

    [Tooltip("Affinity")] public Elements element, summon, support;
    public Resistance[] resistances = new Resistance[12];

    public int CalculateDamageWithResistance(int damage, Elements element)
    {
        for (int i = 0; i < resistances.Length; i++)
        {
            if (resistances[i].element == element)
            {
                return Mathf.FloorToInt((damage * resistances[i].percentageToTake) / 100);
            }
        }

        return damage;
    }

    public void Resistances()
    {
        switch (element)
        {
            case Elements.WATER:
                resistances[0].element = Elements.FIRE;
                resistances[0].percentageToTake = 50;
                resistances[1].element = Elements.PLANT;
                resistances[1].percentageToTake = 150;
                resistances[2].element = Elements.WIND;
                resistances[2].percentageToTake = 100f * 2 / 3;
                resistances[3].element = Elements.EARTH;
                resistances[3].percentageToTake = 200;
                break;
            case Elements.FIRE:
                resistances[0].element = Elements.PLANT;
                resistances[0].percentageToTake = 50;
                resistances[1].element = Elements.WIND;
                resistances[1].percentageToTake = 150;
                resistances[2].element = Elements.EARTH;
                resistances[2].percentageToTake = 100f * 2 / 3;
                resistances[3].element = Elements.WATER;
                resistances[3].percentageToTake = 200;
                break;
            case Elements.PLANT:
                resistances[0].element = Elements.WIND;
                resistances[0].percentageToTake = 50;
                resistances[1].element = Elements.EARTH;
                resistances[1].percentageToTake = 150;
                resistances[2].element = Elements.WATER;
                resistances[2].percentageToTake = 100f * 2 / 3;
                resistances[3].element = Elements.FIRE;
                resistances[3].percentageToTake = 200;
                break;
            case Elements.WIND:
                resistances[0].element = Elements.EARTH;
                resistances[0].percentageToTake = 50;
                resistances[1].element = Elements.WATER;
                resistances[1].percentageToTake = 150;
                resistances[2].element = Elements.FIRE;
                resistances[2].percentageToTake = 100f * 2 / 3;
                resistances[3].element = Elements.PLANT;
                resistances[3].percentageToTake = 200;
                break;
            case Elements.EARTH:
                resistances[0].element = Elements.WATER;
                resistances[0].percentageToTake = 50;
                resistances[1].element = Elements.FIRE;
                resistances[1].percentageToTake = 150;
                resistances[2].element = Elements.PLANT;
                resistances[2].percentageToTake = 100f * 2 / 3;
                resistances[3].element = Elements.WIND;
                resistances[3].percentageToTake = 200;
                break;
        }
        
        switch (summon)
        {
            case Elements.DRAGON:
                resistances[4].element = Elements.BEAST;
                resistances[4].percentageToTake = 50;
                resistances[5].element = Elements.ANGEL;
                resistances[5].percentageToTake = 150;
                resistances[6].element = Elements.DEMON;
                resistances[6].percentageToTake = 100f * 2 / 3;
                resistances[7].element = Elements.FAIRY;
                resistances[7].percentageToTake = 200;
                break;
            case Elements.BEAST:
                resistances[4].element = Elements.ANGEL;
                resistances[4].percentageToTake = 50;
                resistances[5].element = Elements.DEMON;
                resistances[5].percentageToTake = 150;
                resistances[6].element = Elements.FAIRY;
                resistances[6].percentageToTake = 100f * 2 / 3;
                resistances[7].element = Elements.DRAGON;
                resistances[7].percentageToTake = 200;
                break;
            case Elements.ANGEL:
                resistances[4].element = Elements.DEMON;
                resistances[4].percentageToTake = 50;
                resistances[5].element = Elements.FAIRY;
                resistances[5].percentageToTake = 150;
                resistances[6].element = Elements.DRAGON;
                resistances[6].percentageToTake = 100f * 2 / 3;
                resistances[7].element = Elements.BEAST;
                resistances[7].percentageToTake = 200;
                break;
            case Elements.DEMON:
                resistances[4].element = Elements.FAIRY;
                resistances[4].percentageToTake = 50;
                resistances[5].element = Elements.DRAGON;
                resistances[5].percentageToTake = 150;
                resistances[6].element = Elements.BEAST;
                resistances[6].percentageToTake = 100f * 2 / 3;
                resistances[7].element = Elements.ANGEL;
                resistances[7].percentageToTake = 200;
                break;
            case Elements.FAIRY:
                resistances[4].element = Elements.DRAGON;
                resistances[4].percentageToTake = 50;
                resistances[5].element = Elements.BEAST;
                resistances[5].percentageToTake = 150;
                resistances[6].element = Elements.ANGEL;
                resistances[6].percentageToTake = 100f * 2 / 3;
                resistances[7].element = Elements.DEMON;
                resistances[7].percentageToTake = 200;
                break;
        }
        
        switch (support)
        {
            case Elements.LIGHT:
                resistances[8].element = Elements.DARKNESS;
                resistances[8].percentageToTake = 50;
                resistances[9].element = Elements.SPACE;
                resistances[9].percentageToTake = 150;
                resistances[10].element = Elements.TIME;
                resistances[10].percentageToTake =100f * 2 / 3150;
                resistances[11].element = Elements.GRAVITY;
                resistances[11].percentageToTake =200;
                break;
            case Elements.DARKNESS:
                resistances[8].element = Elements.SPACE;
                resistances[8].percentageToTake = 50;
                resistances[9].element = Elements.TIME;
                resistances[9].percentageToTake = 150;
                resistances[10].element = Elements.GRAVITY;
                resistances[10].percentageToTake =100f * 2 / 3150;
                resistances[11].element = Elements.LIGHT;
                resistances[11].percentageToTake =200;
                break;
            case Elements.SPACE:
                resistances[8].element = Elements.TIME;
                resistances[8].percentageToTake = 50;
                resistances[9].element = Elements.GRAVITY;
                resistances[9].percentageToTake = 150;
                resistances[10].element = Elements.LIGHT;
                resistances[10].percentageToTake =100f * 2 / 3150;
                resistances[11].element = Elements.DARKNESS;
                resistances[11].percentageToTake =200;
                break;
            case Elements.TIME:
                resistances[8].element = Elements.GRAVITY;
                resistances[8].percentageToTake = 50;
                resistances[9].element = Elements.LIGHT;
                resistances[9].percentageToTake = 150;
                resistances[10].element = Elements.DARKNESS;
                resistances[10].percentageToTake =100f * 2 / 3150;
                resistances[11].element = Elements.SPACE;
                resistances[11].percentageToTake =200;
                break;
            case Elements.GRAVITY:
                resistances[8].element = Elements.LIGHT;
                resistances[8].percentageToTake = 50;
                resistances[9].element = Elements.DARKNESS;
                resistances[9].percentageToTake = 150;
                resistances[10].element = Elements.SPACE;
                resistances[10].percentageToTake =100f * 2 / 3150;
                resistances[11].element = Elements.TIME;
                resistances[11].percentageToTake =200;
                break;
        }
    }
}
