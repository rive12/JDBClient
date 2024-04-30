using System;
using StupidTemplate.Classes;
using StupidTemplate.Mods;

namespace StupidTemplate.Menu
{
	// Token: 0x02000043 RID: 67
	internal class Buttons
	{
		// Token: 0x0400002B RID: 43
		public static ButtonInfo[][] buttons = new ButtonInfo[][]
		{
			new ButtonInfo[]
			{
				new ButtonInfo
				{
					buttonText = "Disconnect",
					method = delegate()
					{
						disconnect.Disconnect();
					},
					toolTip = "Makes you leave. UND",
					isTogglable = true
				},
				new ButtonInfo
				{
					buttonText = "Settings",
					method = delegate()
					{
						SettingsMods.EnterSettings();
					},
					isTogglable = false,
					toolTip = "Opens the main settings page for the menu."
				},
				new ButtonInfo
				{
					buttonText = "SpeedBoost",
					method = delegate()
					{
						Speedboost.SpeedboostMod();
					},
					toolTip = "Gives a slight speed boost. UND",
					isTogglable = true
				},
				new ButtonInfo
				{
					buttonText = "Noclip",
					method = delegate()
					{
						Noclip.NoclipMod();
					},
					toolTip = "Makes you have no colliders. UND",
					isTogglable = true
				},
				new ButtonInfo
				{
					buttonText = "Platforms",
					method = delegate()
					{
						fart.Platforms2();
					},
					toolTip = "Platforms. UND",
					isTogglable = true
				},
				new ButtonInfo
				{
					buttonText = "Noclip Fly",
					method = delegate()
					{
						NoclipFly.FlyNoclip();
					},
					toolTip = "Noclip fly. UND",
					isTogglable = true
				},
				new ButtonInfo
				{
					buttonText = "Beacons",
					method = delegate()
					{
						Beacons.BeaconsMod();
					},
					toolTip = "Puts a beacon above everyone's head. UND",
					isTogglable = true
				},
				new ButtonInfo
				{
					buttonText = "Wallwalk",
					method = delegate()
					{
						WallWalk.GripMonkeWWRight();
					},
					toolTip = "W. UND",
					isTogglable = true
				},
				new ButtonInfo
				{
					buttonText = "HeadSpin",
					method = delegate()
					{
						SpinHead.SpinHeadX();
					},
					toolTip = "Spins ur head. UND",
					isTogglable = true
				},
				new ButtonInfo
				{
					buttonText = "Ghost Monk",
					method = delegate()
					{
						GhostMonke.GhostMonk();
					},
					toolTip = "Freezes ur rig. UND",
					isTogglable = true
				},
				new ButtonInfo
				{
					buttonText = "Join Random",
					method = delegate()
					{
						rizz.joinrandom();
					},
					toolTip = "joins random room. UND",
					isTogglable = true
				},
				new ButtonInfo
				{
					buttonText = "Enable Tag Freeze",
					method = delegate()
					{
						Helicopter.EnableTagFreeze();
					},
					toolTip = "Gives you tag freeze. UND",
					isTogglable = true
				},
				new ButtonInfo
				{
					buttonText = "Disable Tag Freeze",
					method = delegate()
					{
						Disable_tag.DisableTagFreeze();
					},
					toolTip = "Turns off tag freeze. UND",
					isTogglable = true
				},
				new ButtonInfo
				{
					buttonText = "Reverse Gravity",
					method = delegate()
					{
						FpsBoost.FPSBoostx();
					},
					toolTip = "Reverses Gravity. UND",
					isTogglable = true
				},
				new ButtonInfo
				{
					buttonText = "Low Grav",
					method = delegate()
					{
						Low_Grav.LowGravity();
					},
					toolTip = "Low Grav. UND",
					isTogglable = true
				},
				new ButtonInfo
				{
					buttonText = "Tagself",
					method = delegate()
					{
						dsdas.TagSelf();
					},
					toolTip = "Tag urself. Und",
					isTogglable = true
				},
				new ButtonInfo
				{
					buttonText = "Tracers",
					method = delegate()
					{
						x.Tracers();
					},
					toolTip = "Sigma. UND",
					isTogglable = true
				},
				new ButtonInfo
				{
					buttonText = "ForceRain CS",
					method = delegate()
					{
						Rain.ForceRain();
					},
					toolTip = "Makes it rain. UND",
					isTogglable = true
				},
				new ButtonInfo
				{
					buttonText = "Clear weather",
					method = delegate()
					{
						Clear.ClearWeather();
					},
					toolTip = "Clears weather. UND",
					isTogglable = true
				},
				new ButtonInfo
				{
					buttonText = "Grab ID Gun",
					method = delegate()
					{
						fard.idgrabgun();
					},
					toolTip = "Grabs there ID. UND",
					isTogglable = true
				},
				new ButtonInfo
				{
					buttonText = "Break neck",
					method = delegate()
					{
						sss.BrokenNeck();
					},
					toolTip = "Breaks your neck. UND",
					isTogglable = true
				},
				new ButtonInfo
				{
					buttonText = "Fix Head",
					method = delegate()
					{
						fix.FixHead();
					},
					toolTip = "Fixes your head. UND",
					isTogglable = true
				},
				new ButtonInfo
				{
					buttonText = "Upsidedown Head",
					method = delegate()
					{
						upsidedown.UpsideDownHead();
					},
					toolTip = "Makes your head upsidedown. UND",
					isTogglable = true
				},
				new ButtonInfo
				{
					buttonText = "TP Gun",
					method = delegate()
					{
						TP.TpGun();
					},
					toolTip = "teleports you. UND",
					isTogglable = true
				},
				new ButtonInfo
				{
					buttonText = "Steam Long Arms",
					method = delegate()
					{
						plattttys.LongArms();
					},
					toolTip = "Gives you long arms. UND",
					isTogglable = true
				},
				new ButtonInfo
				{
					buttonText = "AntiReport",
					method = delegate()
					{
						ant3.Disconnect();
					},
					toolTip = "kicks you when somone reports you. UND",
					isTogglable = true
				},
				new ButtonInfo
				{
					buttonText = "Solid Water",
					method = delegate()
					{
						Solid.SolidWater();
					},
					toolTip = "Makes water solid. UND",
					isTogglable = true
				},
				new ButtonInfo
				{
					buttonText = "Fix Water",
					method = delegate()
					{
						fixw.FixWater();
					},
					toolTip = "Fixes The Water. UND",
					isTogglable = true
				},
				new ButtonInfo
				{
					buttonText = "Fast Swim",
					method = delegate()
					{
						fast.FastSwim();
					},
					toolTip = "Makes you swim very fast. UND",
					isTogglable = true
				},
				new ButtonInfo
				{
					buttonText = "Random Sound Spam",
					method = delegate()
					{
						randomsound.RandomSoundSpam();
					},
					toolTip = "spamssounds. UND",
					isTogglable = true
				},
				new ButtonInfo
				{
					buttonText = "unlock comp",
					method = delegate()
					{
						unlock.UnlockCompetitive();
					},
					toolTip = "unlocks comp. UND",
					isTogglable = true
				},
				new ButtonInfo
				{
					buttonText = "Invis monk",
					method = delegate()
					{
						inv.InvisMonkeMod();
					},
					toolTip = "Turns You Invis. UND",
					isTogglable = true
				},
				new ButtonInfo
				{
					buttonText = "Antimoderator",
					method = delegate()
					{
						antimod.antimoderator();
					},
					toolTip = "kicks you if a mod joins. UND",
					isTogglable = true
				},
				new ButtonInfo
				{
					buttonText = "Bug Seizure",
					method = delegate()
					{
						dougses.SeizureBug();
					},
					toolTip = "Gives Doug A Seizure. UND",
					isTogglable = true
				},
				new ButtonInfo
				{
					buttonText = "Grab Bug",
					method = delegate()
					{
						grab.GrabBug();
					},
					toolTip = "Grabs doug. UND",
					isTogglable = true
				},
				new ButtonInfo
				{
					buttonText = "Grab Beachball",
					method = delegate()
					{
						ball.GrabBall();
					},
					toolTip = "Grabs BeachBall. UND",
					isTogglable = true
				},
				new ButtonInfo
				{
					buttonText = "Grab Bat",
					method = delegate()
					{
						bat.GrabBat();
					},
					toolTip = "Grabs Bat. UND",
					isTogglable = true
				},
				new ButtonInfo
				{
					buttonText = "Slide Control",
					method = delegate()
					{
						contrp.EnableSlideControl();
					},
					toolTip = "Slide Control. UND",
					isTogglable = true
				},
				new ButtonInfo
				{
					buttonText = "Tag All",
					method = delegate()
					{
						tag.All();
					},
					toolTip = "Tags Everyone. UND",
					isTogglable = true
				}
			},
			new ButtonInfo[]
			{
				new ButtonInfo
				{
					buttonText = "Return to Main",
					method = delegate()
					{
						Global.ReturnHome();
					},
					isTogglable = false,
					toolTip = "Returns to the main page of the menu."
				},
				new ButtonInfo
				{
					buttonText = "Menu",
					method = delegate()
					{
						SettingsMods.MenuSettings();
					},
					isTogglable = false,
					toolTip = "Opens the settings for the menu."
				},
				new ButtonInfo
				{
					buttonText = "Movement",
					method = delegate()
					{
						SettingsMods.MovementSettings();
					},
					isTogglable = false,
					toolTip = "Opens the movement settings for the menu."
				},
				new ButtonInfo
				{
					buttonText = "Projectile",
					method = delegate()
					{
						SettingsMods.ProjectileSettings();
					},
					isTogglable = false,
					toolTip = "Opens the projectile settings for the menu."
				}
			},
			new ButtonInfo[]
			{
				new ButtonInfo
				{
					buttonText = "Return to Settings",
					method = delegate()
					{
						SettingsMods.EnterSettings();
					},
					isTogglable = false,
					toolTip = "Returns to the main settings page for the menu."
				},
				new ButtonInfo
				{
					buttonText = "Right Hand",
					enableMethod = delegate()
					{
						SettingsMods.RightHand();
					},
					disableMethod = delegate()
					{
						SettingsMods.LeftHand();
					},
					toolTip = "Puts the menu on your right hand."
				},
				new ButtonInfo
				{
					buttonText = "Notifications",
					enableMethod = delegate()
					{
						SettingsMods.EnableNotifications();
					},
					disableMethod = delegate()
					{
						SettingsMods.DisableNotifications();
					},
					enabled = !Settings.disableNotifications,
					toolTip = "Toggles the notifications."
				},
				new ButtonInfo
				{
					buttonText = "FPS Counter",
					enableMethod = delegate()
					{
						SettingsMods.EnableFPSCounter();
					},
					disableMethod = delegate()
					{
						SettingsMods.DisableFPSCounter();
					},
					enabled = Settings.fpsCounter,
					toolTip = "Toggles the FPS counter."
				},
				new ButtonInfo
				{
					buttonText = "Disconnect Button",
					enableMethod = delegate()
					{
						SettingsMods.EnableDisconnectButton();
					},
					disableMethod = delegate()
					{
						SettingsMods.DisableDisconnectButton();
					},
					enabled = Settings.disconnectButton,
					toolTip = "Toggles the disconnect button."
				}
			},
			new ButtonInfo[]
			{
				new ButtonInfo
				{
					buttonText = "Return to Settings",
					method = delegate()
					{
						SettingsMods.EnterSettings();
					},
					isTogglable = false,
					toolTip = "Returns to the main settings page for the menu."
				}
			},
			new ButtonInfo[]
			{
				new ButtonInfo
				{
					buttonText = "Return to Settings",
					method = delegate()
					{
						SettingsMods.MenuSettings();
					},
					isTogglable = false,
					toolTip = "Opens the settings for the menu."
				}
			}
		};
	}
}
