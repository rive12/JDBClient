using System;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine;

namespace StupidTemplate.Mods
{
	// Token: 0x02000029 RID: 41
	internal class Beacons
	{
		// Token: 0x0600005A RID: 90 RVA: 0x00003558 File Offset: 0x00001758
		public static void BeaconsMod()
		{
			bool flag = PhotonNetwork.CurrentRoom != null;
			if (flag)
			{
				foreach (Player player in PhotonNetwork.PlayerListOthers)
				{
					PhotonView photonView = GorillaGameManager.instance.FindVRRigForPlayer(player);
					VRRig vrrig = GorillaGameManager.instance.FindPlayerVRRig(player);
					bool flag2 = !vrrig.isOfflineVRRig && !vrrig.isMyPlayer && !photonView.IsMine;
					if (flag2)
					{
						GameObject gameObject = GameObject.CreatePrimitive(2);
						Object.Destroy(gameObject.GetComponent<BoxCollider>());
						Object.Destroy(gameObject.GetComponent<Rigidbody>());
						Object.Destroy(gameObject.GetComponent<Collider>());
						gameObject.GetComponent<MeshRenderer>().material.SetColor("_Color", Color.green);
						gameObject.transform.rotation = Quaternion.identity;
						gameObject.transform.localScale = new Vector3(0.04f, 200f, 0.04f);
						gameObject.transform.position = vrrig.transform.position;
						gameObject.GetComponent<MeshRenderer>().material = vrrig.mainSkin.material;
						Object.Destroy(gameObject, Time.deltaTime);
					}
				}
			}
		}
	}
}
