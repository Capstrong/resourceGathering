﻿using UnityEngine;
using System.Collections;

public enum ResourceType
{
    Invalid,
    Apple,
    Joy,
}

public class resource : MonoBehaviour {

    public ResourceType type;
    public int amount = 1;
}
