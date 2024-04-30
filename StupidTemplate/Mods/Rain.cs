using System;

namespace StupidTemplate.Mods
{
	// Token: 0x02000033 RID: 51
	internal class Rain
	{
		// Token: 0x0600006E RID: 110 RVA: 0x00003A79 File Offset: 0x00001C79
		public static void ForceRain()
		{
			BetterDayNightManager.instance.weatherCycle[BetterDayNightManager.instance.currentWeatherIndex] = 1;
			BetterDayNightManager.instance.CurrentWeather();
		}
	}
}
