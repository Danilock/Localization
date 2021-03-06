using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> : MonoBehaviour
{
    protected static T _instance;

    public static T Instance
    {
        get
        {
            return _instance;
        }

        set => _instance = value;
    }
}
