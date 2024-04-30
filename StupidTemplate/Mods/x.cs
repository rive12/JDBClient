using System;
using GorillaLocomotion;
using Photon.Pun;
using UnityEngine;

namespace StupidTemplate.Mods
{
	// Token: 0x02000042 RID: 66
	internal class x
	{
		// Token: 0x0600009A RID: 154 RVA: 0x00004598 File Offset: 0x00002798
		public static void Tracers()
		{
			bool flag = PhotonNetwork.CurrentRoom == null;
			if (!flag)
			{
				foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
				{
					bool flag2 = !vrrig.isOfflineVRRig;
					if (flag2)
					{
						GameObject gameObject = new GameObject("Line");
						LineRenderer lineRenderer = gameObject.AddComponent<LineRenderer>();
						lineRenderer.startColor = (lineRenderer.endColor = Color.green);
						lineRenderer.startWidth = (lineRenderer.endWidth = 0.01f);
						lineRenderer.positionCount = 2;
						lineRenderer.SetPositions(new Vector3[]
						{
							Player.Instance.rightControllerTransform.position,
							vrrig.transform.position
						});
						lineRenderer.material.shader = Shader.Find("GUI/Text Shader");
						Object.Destroy(gameObject, Time.deltaTime);
					}
				}
			}
		}
	}
}
