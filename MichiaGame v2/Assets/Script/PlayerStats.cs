using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PLayerStats : MonoBehaviour
{
    public enum Type
    {
        GUERRERO,
            MAGO,
            NINJA,
            HEALER
    }
    
    public float baseHP;
    public float currHp;

    public float baseMP;
    public float currMP;

    public float baseATK;
    public float curATK;
    public float baseDDEF;
    public float currDEF;
}
