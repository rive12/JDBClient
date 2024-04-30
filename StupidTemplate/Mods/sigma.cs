using System;
using BepInEx;
using GorillaLocomotion;
using UnityEngine;

namespace StupidTemplate.Mods
{
	// Token: 0x02000039 RID: 57
	internal class sigma
	{
		// Token: 0x06000085 RID: 133 RVA: 0x00003CE4 File Offset: 0x00001EE4
		public static void TpGun(Color backgroundColor)
		{
			bool rightGrab = ControllerInputPoller.instance.rightGrab;
			if (rightGrab)
			{
				RaycastHit raycastHit;
				Physics.Raycast(GorillaTagger.Instance.rightHandTransform.position, GorillaTagger.Instance.rightHandTransform.forward, ref raycastHit);
				GameObject gameObject = GameObject.CreatePrimitive(0);
				gameObject.transform.position = raycastHit.point;
				gameObject.transform.localScale = new Vector3(0.185f, 0.185f, 0.185f);
				gameObject.GetComponent<Renderer>().material.color = backgroundColor;
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

		// Token: 0x06000086 RID: 134 RVA: 0x00003DEC File Offset: 0x00001FEC
		public static void CarMonke()
		{
			bool flag = ControllerInputPoller.instance.rightControllerPrimaryButton || UnityInput.Current.GetKey(101);
			if (flag)
			{
				bool flag2 = sigma.CurrentCarSpeed < 15f;
				if (flag2)
				{
					sigma.CurrentCarSpeed += 0.1f;
				}
				else
				{
					bool flag3 = sigma.CurrentCarSpeed != 15f;
					if (flag3)
					{
						sigma.CurrentCarSpeed = 15f;
					}
				}
				Player.Instance.transform.position += Player.Instance.bodyCollider.transform.forward * Time.deltaTime * sigma.CurrentCarSpeed;
			}
			else
			{
				bool flag4 = sigma.CurrentCarSpeed > 0f;
				if (flag4)
				{
					sigma.CurrentCarSpeed -= 0.5f;
					Player.Instance.transform.position += Player.Instance.bodyCollider.transform.forward * Time.deltaTime * sigma.CurrentCarSpeed;
				}
				else
				{
					bool flag5 = sigma.CurrentCarSpeed < 0f || sigma.CurrentCarSpeed == 0f;
					if (flag5)
					{
						sigma.CurrentCarSpeed = 0f;
					}
				}
			}
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00003F43 File Offset: 0x00002143
		internal static void TpGun()
		{
			throw new NotImplementedException();
		}

		// Token: 0x04000028 RID: 40
		private static float CurrentCarSpeed;
	}
}
