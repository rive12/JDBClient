using System;
using HarmonyLib;
using UnityEngine;

namespace StupidTemplate.Patches
{
	// Token: 0x02000012 RID: 18
	[HarmonyPatch(typeof(GameObject))]
	[HarmonyPatch("CreatePrimitive", 0)]
	internal class ShaderFix : MonoBehaviour
	{
		// Token: 0x06000026 RID: 38 RVA: 0x000023BC File Offset: 0x000005BC
		private static void Postfix(GameObject __result)
		{
			__result.GetComponent<Renderer>().material.shader = Shader.Find("GorillaTag/UberShader");
			__result.GetComponent<Renderer>().material.color = new Color32(byte.MaxValue, 128, 0, 128);
		}
	}
}
