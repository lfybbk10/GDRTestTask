using System;
using UnityEngine;

public static class Tools
{
    public static bool IsInLayerMask(this GameObject obj, LayerMask layerMask)
    {
        return ((layerMask.value & (1 << obj.layer)) > 0);
    }
    
    public static bool IsValid(this MonoBehaviour comp) {
        try {
            if (comp.gameObject == null) return false;
        } catch(Exception) {
            return false;
        }
        return true;
    }
}
