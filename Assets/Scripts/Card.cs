using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Elements
{
    NONE,
    WATER,
    FIRE,
    PLANT,
    WIND,
    EARTH,
    DRAGON,
    BEAST,
    ANGEL,
    DEMON,
    FAIRY,
    LIGHT,
    DARKNESS,
    SPACE,
    TIME,
    GRAVITY,
} // Elige el icono y el tipo de daño/defensa/apoyo/invocación de la carta

public enum CardRarity
{
    NONE,
    E,
    D,
    C,
    B,
    A,
    S,
    EX
} // Cambia el color del interior del borde de la carta

public enum Evolution
{
    NONE, // BASE
    EVO1, // COPPER
    EVO2, // SILVER
    EVO3, // GOLDEN
}  // Cambia el color del borde de la carta

[CreateAssetMenu(fileName = "Single Attack Card", menuName = "Card/New Single Attack Card")]
public class SingleAttackCard : ScriptableObject
{
    public CardRarity rarity;
    public Evolution currentEvolution;
    public Texture2D hand, info;
    public string strName;
    public string description;
    public Elements element;
    public int damage;
    public SingleAttackCard nextEvolution;
}

[CreateAssetMenu(fileName = "Continue Attack Card", menuName = "Card/New Continue Attack Card")]
public class ContinueAttackCard : ScriptableObject
{
    public CardRarity rarity;
    public Evolution currentEvolution;
    public Texture2D hand, info;
    public string strName;
    public string description;
    public Elements element;
    public int damage;
    public ContinueAttackCard nextEvolution;
}

[CreateAssetMenu(fileName = "Defense Card", menuName = "Card/New Defense Card")]
public class DefenseCard : ScriptableObject
{
    public CardRarity rarity;
    public Evolution currentEvolution;
    public Texture2D hand, info;
    public string strName;
    public string description;
    public Elements element;
    public int durability;
    public DefenseCard nextEvolution;
}

[CreateAssetMenu(fileName = "Buff Card", menuName = "Card/New Buff Card")]
public class BuffCard : ScriptableObject
{
    public CardRarity rarity;
    public Evolution currentEvolution;
    public Texture2D hand, info;
    public string strName;
    public string description;
    // public Element element; (Aumenta la resistencia de un elemento a un aliado)
    public float upgrade;
    public BuffCard nextEvolution;
}

[CreateAssetMenu(fileName = "Debuff Card", menuName = "Card/New Debuff Card")]
public class DebuffCard : ScriptableObject
{
    public CardRarity rarity;
    public Evolution currentEvolution;
    public Texture2D hand, info;
    public string strName;
    public string description;
    // public Element element; (Disminuye la resistencia a un elemento de un enemigo)
    public float downgrade;
    public DebuffCard nextEvolution;
}

[CreateAssetMenu(fileName = "Trap Card", menuName = "Card/New Trap Card")]
public class TrapCard : ScriptableObject
{
    public CardRarity rarity;
    public Evolution currentEvolution;
    public Texture2D hand, info;
    public string strName;
    public string description;
    public Elements element;
    public int damage;
    public int durabilityTime;
    public TrapCard nextEvolution;
}
