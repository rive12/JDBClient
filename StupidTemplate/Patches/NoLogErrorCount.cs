using System;
using HarmonyLib;
using UnityEngine;

namespace StupidTemplate.Patches
{
	// Token: 0x02000008 RID: 8
	[HarmonyPatch(typeof(GorillaNot), "LogErrorCount")]
	public class NoLogErrorCount : MonoBehaviour
	{
		// Token: 0x06000011 RID: 17 RVA: 0x00002290 File Offset: 0x00000490
		private static bool Prefix(string logString, string stackTrace, LogType type)
		{
			return false;
		}
	}
}
