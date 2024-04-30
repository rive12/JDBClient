using System;
using UnityEngine;

namespace StupidTemplate.Mods
{
	// Token: 0x0200002F RID: 47
	internal class inv
	{
		// Token: 0x06000066 RID: 102 RVA: 0x000037C4 File Offset: 0x000019C4
		public static void InvisMonkeMod()
		{
			bool flag = false;
			bool flag2 = ControllerInputPoller.instance.rightControllerIndexFloat > 0f;
			bool flag3 = flag2;
			if (flag3)
			{
				bool flag4 = flag;
				if (flag4)
				{
					flag = false;
				}
				else
				{
					bool flag5 = !flag;
					if (flag5)
					{
						flag = true;
					}
				}
				GameObject gameObject = GameObject.CreatePrimitive(0);
				Object.Destroy(gameObject.GetComponent<Rigidbody>());
				Object.Destroy(gameObject.GetComponent<SphereCollider>());
				gameObject.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
				gameObject.transform.position = GorillaTagger.Instance.rightHandTransform.position;
				gameObject.GetComponent<Renderer>().material.color = new Color32(56, byte.MaxValue, 244, 251);
				GameObject gameObject2 = GameObject.CreatePrimitive(0);
				Object.Destroy(gameObject2.GetComponent<Rigidbody>());
				Object.Destroy(gameObject2.GetComponent<SphereCollider>());
				gameObject2.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
				gameObject2.transform.position = GorillaTagger.Instance.leftHandTransform.position;
				gameObject2.GetComponent<Renderer>().material.color = new Color32(56, byte.MaxValue, 244, 251);
				Object.Destroy(gameObject, Time.deltaTime);
				Object.Destroy(gameObject2, Time.deltaTime);
			}
			bool flag6 = flag;
			if (flag6)
			{
				GorillaTagger.Instance.offlineVRRig.headBodyOffset.x = 180f;
			}
			else
			{
				bool flag7 = !flag;
				if (flag7)
				{
					GorillaTagger.Instance.offlineVRRig.headBodyOffset.x = 0f;
				}
			}
		}
	}
}
