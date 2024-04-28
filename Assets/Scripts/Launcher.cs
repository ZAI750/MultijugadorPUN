using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Launcher : MonoBehaviourPunCallbacks
{
   private void Start()
   {
      Debug.Log("Conectando");
      PhotonNetwork.ConnectUsingSettings();
      MenuManager.Instance.OpenMenuName("Loading");
   }

   public override void OnConnectedToMaster()
   {
      Debug.Log("Conectado");
      PhotonNetwork.JoinLobby();
   }

   public override void OnJoinedLobby()
   {
      Debug.Log("Conectado al lobby");
      MenuManager.Instance.OpenMenuName("Home");
   }
}
