using System;
using BepInEx;
using GorillaLocomotion;
using UnityEngine;

namespace StupidTemplate.Mods
{
	// Token: 0x0200003F RID: 63
	internal class TP
	{
		// Token: 0x06000093 RID: 147 RVA: 0x000042C8 File Offset: 0x000024C8
		public static void TpGun()
		{
			bool rightGrab = ControllerInputPoller.instance.rightGrab;
			if (rightGrab)
			{
				RaycastHit raycastHit;
				Physics.Raycast(GorillaTagger.Instance.rightHandTransform.position, GorillaTagger.Instance.rightHandTransform.forward, ref raycastHit);
				GameObject gameObject = GameObject.CreatePrimitive(0);
				gameObject.transform.position = raycastHit.point;
				gameObject.transform.localScale = new Vector3(0.185f, 0.185f, 0.185f);
				gameObject.GetComponent<Renderer>().material.color = Settings.OutlineColor;
				Object.Destroy(gameObject, Time.deltaTime);
				Object.Destroy(gameObject.GetComponent<Rigidbody>());
				Object.Destroy(gameObject.GetComponent<SphereCollider>());
				bool flag = ControllerInputPoller.instance.rightControllerIndexFloat > 0.5f;
				if (flag)
				{
					GorillaTagger.Instance.transform.position = gameObject.transform.position;
					GorillaTagger.Instance.GetComponent<Rigidbody>().velocity = gameObject.transform.position;
				}
			}
		}

		// Token: 0x06000094 RID: 148 RVA: 0x000043D4 File Offset: 0x000025D4
		public static void CarMonke()
		{
			bool flag = ControllerInputPoller.instance.rightControllerPrimaryButton || UnityInput.Current.GetKey(101);
			if (flag)
			{
				bool flag2 = TP.CurrentCarSpeed < 15f;
				if (flag2)
				{
					TP.CurrentCarSpeed += 0.1f;
				}
				else
				{
					bool flag3 = TP.CurrentCarSpeed != 15f;
					if (flag3)
					{
						TP.CurrentCarSpeed = 15f;
					}
				}
				Player.Instance.transform.position += Player.Instance.bodyCollider.transform.forward * Time.deltaTime * TP.CurrentCarSpeed;
			}
			else
			{
				bool flag4 = TP.CurrentCarSpeed > 0f;
				if (flag4)
				{
					TP.CurrentCarSpeed -= 0.5f;
					Player.Instance.transform.position += Player.Instance.bodyCollider.transform.forward * Time.deltaTime * TP.CurrentCarSpeed;
				}
				else
				{
					bool flag5 = TP.CurrentCarSpeed < 0f || TP.CurrentCarSpeed == 0f;
					if (flag5)
					{
						TP.CurrentCarSpeed = 0f;
					}
				}
			}
		}

		// Token: 0x0400002A RID: 42
		private static float CurrentCarSpeed;
	}
}
