﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace SteamWebAPI2.Models.SteamEconomy
{
    internal class AssetPrices
    {
        [JsonProperty("USD")]
        public int USD { get; set; }

        [JsonProperty("GBP")]
        public int GBP { get; set; }

        [JsonProperty("EUR")]
        public int EUR { get; set; }

        [JsonProperty("RUB")]
        public int RUB { get; set; }

        [JsonProperty("BRL")]
        public int BRL { get; set; }

        [JsonProperty("JPY")]
        public int JPY { get; set; }

        [JsonProperty("NOK")]
        public int NOK { get; set; }

        [JsonProperty("IDR")]
        public int IDR { get; set; }

        [JsonProperty("MYR")]
        public int MYR { get; set; }

        [JsonProperty("PHP")]
        public int PHP { get; set; }

        [JsonProperty("SGD")]
        public int SGD { get; set; }

        [JsonProperty("THB")]
        public int THB { get; set; }

        [JsonProperty("VND")]
        public int VND { get; set; }

        [JsonProperty("KRW")]
        public int KRW { get; set; }

        [JsonProperty("TRY")]
        public int TRY { get; set; }

        [JsonProperty("UAH")]
        public int UAH { get; set; }

        [JsonProperty("MXN")]
        public int MXN { get; set; }

        [JsonProperty("CAD")]
        public int CAD { get; set; }

        [JsonProperty("AUD")]
        public int AUD { get; set; }

        [JsonProperty("NZD")]
        public int NZD { get; set; }

        [JsonProperty("CNY")]
        public int CNY { get; set; }

        [JsonProperty("TWD")]
        public int TWD { get; set; }

        [JsonProperty("HKD")]
        public int HKD { get; set; }

        [JsonProperty("INR")]
        public int INR { get; set; }

        [JsonProperty("AED")]
        public int AED { get; set; }

        [JsonProperty("SAR")]
        public int SAR { get; set; }

        [JsonProperty("ZAR")]
        public int ZAR { get; set; }
    }

    internal class AssetClass
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    internal class Asset
    {
        [JsonProperty("prices")]
        public AssetPrices Prices { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("class")]
        public IList<AssetClass> Class { get; set; }

        [JsonProperty("classid")]
        public string Classid { get; set; }

        [JsonProperty("tags")]
        public IList<string> Tags { get; set; }

        [JsonProperty("tag_ids")]
        public IList<long> TagIds { get; set; }
    }

    internal class AssetTags
    {
        [JsonProperty("Cosmetics")]
        public string Cosmetics { get; set; }

        [JsonProperty("Tools")]
        public string Tools { get; set; }

        [JsonProperty("Weapons")]
        public string Weapons { get; set; }

        [JsonProperty("Taunts")]
        public string Taunts { get; set; }

        [JsonProperty("Bundles")]
        public string Bundles { get; set; }

        [JsonProperty("Limited")]
        public string Limited { get; set; }

        [JsonProperty("New")]
        public string New { get; set; }

        [JsonProperty("Maps")]
        public string Maps { get; set; }

        [JsonProperty("Halloween")]
        public string Halloween { get; set; }
    }

    internal class AssetTagIds
    {
        [JsonProperty("0")]
        public long Tag0 { get; set; }

        [JsonProperty("1")]
        public long Tag1 { get; set; }

        [JsonProperty("2")]
        public long Tag2 { get; set; }

        [JsonProperty("3")]
        public long Tag3 { get; set; }

        [JsonProperty("4")]
        public long Tag4 { get; set; }

        [JsonProperty("5")]
        public long Tag5 { get; set; }

        [JsonProperty("6")]
        public long Tag6 { get; set; }

        [JsonProperty("7")]
        public long Tag7 { get; set; }

        [JsonProperty("8")]
        public long Tag8 { get; set; }
    }

    internal class AssetPriceResult
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("assets")]
        public IList<Asset> Assets { get; set; }

        [JsonProperty("tags")]
        public AssetTags Tags { get; set; }

        [JsonProperty("tag_ids")]
        public AssetTagIds TagIds { get; set; }
    }

    internal class AssetPriceResultContainer
    {
        [JsonProperty("result")]
        public AssetPriceResult Result { get; set; }
    }
}