﻿using UnityEngine;
using System.Collections;

public class DebugPlayerStatus : MonoBehaviour
{
    PlayerStatusManager status;

    void Awake()
    {
        status = new PlayerStatusManager();
        status = gameObject.GetComponent<PlayerStatusManager>();

        Init();
    }

    void Init()
    {
        status.HandMoney = 10000;
    }

    public int GetHandMoney()
    {
        return status.HandMoney;
    }
}