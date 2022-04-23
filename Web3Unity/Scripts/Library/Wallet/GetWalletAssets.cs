using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Networking;
using Rawrshak;

public class GetWalletAssets : QueryBase
{
    public static async Task<GetAccountInfo.ReturnData> Fetch(string walletAddress)
    {
        string query = LoadQuery("GetWalletAssets");
        // pass in function params
        string queryWithParams = String.Format(query).ToLower();
        // post query
        string returnData = await PostAsync("https://api.thegraph.com/subgraphs/name/ryry79261/mainnet-erc721-erc1155",queryWithParams);
        return JsonUtility.FromJson<GetAccountInfo.ReturnData>(returnData);
    }
}
