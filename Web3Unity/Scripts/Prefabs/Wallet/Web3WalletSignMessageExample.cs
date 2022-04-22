using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ChainSafeGamingSDK.ChainSafeWallet;
public class Web3WalletSignMessageExample : MonoBehaviour
{
    async public void OnSignMessage()
    {
        string response = await Web3Wallet.Sign("hello");
        print(response);
    }
}
