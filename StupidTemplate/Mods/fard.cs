using System;
using System.IO;
using GorillaLocomotion;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine;

namespace StupidTemplate.Mods
{
	// Token: 0x02000020 RID: 32
	internal class fard
	{
		// Token: 0x06000046 RID: 70 RVA: 0x00002EE8 File Offset: 0x000010E8
		public static void idgrabgun()
		{
			RaycastHit raycastHit;
			Physics.Raycast(Player.Instance.rightControllerTransform.transform.position, Player.Instance.rightControllerTransform.transform.forward, ref raycastHit);
			GameObject gameObject = GameObject.CreatePrimitive(0);
			gameObject.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
			gameObject.transform.position = raycastHit.point;
			Object.Destroy(gameObject.GetComponent<BoxCollider>());
			Object.Destroy(gameObject.GetComponent<Rigidbody>());
			Object.Destroy(gameObject.GetComponent<Collider>());
			Object.Destroy(gameObject, Time.deltaTime);
			bool rightGrab = ControllerInputPoller.instance.rightGrab;
			bool flag = rightGrab;
			if (flag)
			{
				string text = "New Room";
				foreach (Player player in PhotonNetwork.PlayerList)
				{
					text = string.Concat(new string[]
					{
						text,
						"/nPlayer Name: ",
						player.NickName,
						" , Player ID: ",
						player.UserId
					});
				}
				text += "\n====================================\n";
				File.AppendAllText("PlayerIDS.txt", text);
			}
		}
	}
}
