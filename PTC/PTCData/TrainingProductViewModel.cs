﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTCData
{
    public class TrainingProductViewModel
    {
        public TrainingProductViewModel()
        {
            Init();

            Products = new List<TrainingProduct>();
            SearchEntity = new TrainingProduct();
            Entity = new TrainingProduct();
        }
        public TrainingProduct Entity { get; set; }
        public string EventCommand { get; set; }
        public List<TrainingProduct> Products { get; set; }
        public TrainingProduct SearchEntity { get; set; }
        public bool IsValid { get; set; }
        public string Mode { get; set; }
        public bool IsDetailAreaVisible { get; set; }
        public bool IsListAreaVisible { get; set; }
        public bool IsSearchAreaVisible { get; set; }
        private void Init()
        {
            EventCommand = "List";
            ListMode();
        }
        public void HandleRequest()
        {
            switch(EventCommand.ToLower())
            {
                case "list":
                case "search":
                    Get();
                    break;

                case "save":
                    Save();
                    if (IsValid)
                    {
                        Get();
                    }
                    break;

                case "cancel":
                    ListMode();
                    Get();
                    break;

                case "resetsearch":
                    ResetSearch();
                    break;

                case "add":
                    Add();
                    break;

                default:
                    break;
            }
        }
        private void Save()
        {
            if (IsValid)
            {
                if (Mode == "Add")
                {

                }
            }
            else
            {
                if (Mode == "Add")
                {
                    AddMode();
                }
            }
        }
        private void ListMode()
        {
            IsValid = true;
            IsListAreaVisible = true;
            IsSearchAreaVisible = true;
            IsDetailAreaVisible = false;
            Mode = "List";
        }
        private void Add()
        {
            IsValid = true;
            Entity = new TrainingProduct();
            Entity.IntroductionDate = DateTime.Now;
            Entity.Url = "http://";
            Entity.Price = 0;
            AddMode();
        }
        private void AddMode()
        {
            IsListAreaVisible = false;
            IsSearchAreaVisible = false;
            IsDetailAreaVisible = true;
            Mode = "Add";
        }
        private void ResetSearch()
        {
            SearchEntity = new TrainingProduct();
        }
        private void Get()
        {
            TrainingProductManager mgr = new TrainingProductManager();
            Products = mgr.Get(SearchEntity);
        }
    }
}
