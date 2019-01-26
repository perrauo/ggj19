﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Core.UI
{
    public class HUD : MonoBehaviour
    {
        //[HideInInspector]
        public static HUD Instance;

        [SerializeField]
        public Image BuyMeterContent;

        public void Awake()
        {
            Instance = this;
            Debug.Log("Hello HUD");
        }

        public void Start()
        {
            Game.Instance.OnBuyStatusChangedHandler += OnBuyStatusChanged;
            Game.Instance.OnVisitHandler += OnVisit;
        }


        public void OnVisit()
        {
            BuyMeterContent.fillAmount = Game.Instance.BuyStatus/Game.Instance.Values.BuyStatusComplete;

            // Adjust UI display
        }


        public void OnBuyStatusChanged()
        {
            BuyMeterContent.fillAmount = Game.Instance.BuyStatus / Game.Instance.Values.BuyStatusComplete;
            // Adjust UI display
        }

        public void OnDestroy()
        {
            Game.Instance.OnBuyStatusChangedHandler -= OnBuyStatusChanged;
            Game.Instance.OnVisitHandler -= OnVisit;
        }

        //public void )
        //{

        //}


    }
}
