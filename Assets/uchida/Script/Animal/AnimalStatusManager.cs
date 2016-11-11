﻿using UnityEngine;
using System.Collections;

public class AnimalStatusManager : MonoBehaviour
{
    public enum Sexuality
    {
        MALE,
        FEMALE,
    }

    public struct AnimalStatus
    {
        // ID
        public int ID { get; set; }
        // 名前
        public string Name { get; set; }
        // 値段
        public int PurchasePrice { get; set; }
        // 食べ物
        public int FoodType { get; set; }
        // レア度
        public int Rarity { get; set; }
        // 集客数
        public int AttractVisitors { get; set; }
        // 愛情度
        public int LoveDegree { get; set; }
        // 満腹度
        public int SatietyLevel { get; set; }
        // おもちゃ
        public int ToyID { get; set; }
        // 購入してあるか
        public bool IsPurchase { get; set; }
        // 次のレベルまでの値
        public int NextLevel { get; set; }
        // 倍率
        public float Ratio { get; set; }
        // 性別
        public Sexuality Sexuality { get; set; }
        // 檻の番号
        // 控えは99
        public int CageID { get; set; }
    }
    public AnimalStatus status;

    // 育成する動物かどうか
    public bool IsRaise { get; set; }

    public void InitStatus()
    {
        status.ID = 99;
        status.Name = "***";
        status.PurchasePrice = 0;
        status.FoodType = 0;
        status.Rarity = 1;
        status.AttractVisitors = 0;
        status.LoveDegree = 1;
        status.SatietyLevel = 100;
        status.ToyID = 0;

        status.IsPurchase = false;
        status.NextLevel = 0;
        status.Ratio = 1.0f;
        status.Sexuality = Sexuality.MALE;
        status.CageID = 99;

        IsRaise = false;
    }


    // 経過した時間分の来場客数の計算
    //＊＊＊＊＊＊＊＊＊＊＊＊＊＊＊＊＊＊＊＊＊＊＊＊＊＊＊
    // プランナーに用相談
    //＊＊＊＊＊＊＊＊＊＊＊＊＊＊＊＊＊＊＊＊＊＊＊＊＊＊＊
    public int GetVisitors(float elapsedTime)
    {
        float visitors = (float)status.AttractVisitors * status.Ratio * elapsedTime;

        return (int)visitors;
    }
}