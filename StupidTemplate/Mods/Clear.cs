using System;

namespace StupidTemplate.Mods
{
	// Token: 0x02000019 RID: 25
	internal class Clear
	{
		// Token: 0x06000039 RID: 57 RVA: 0x00002D41 File Offset: 0x00000F41
		public static void ClearWeather()
		{
			BetterDayNightManager.instance.weatherCycle[BetterDayNightManager.instance.currentWeatherIndex] = 0;
			BetterDayNightManager.instance.CurrentWeather();
		}
	}
}
