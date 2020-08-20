﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using DG.Tweening;
using LuaInterface;

public class DG_Tweening_TweenWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(DG.Tweening.Tween), typeof(System.Object));
		L.RegFunction("PathLength", PathLength);
		L.RegFunction("PathGetDrawPoints", PathGetDrawPoints);
		L.RegFunction("PathGetPoint", PathGetPoint);
		L.RegFunction("Loops", Loops);
		L.RegFunction("IsPlaying", IsPlaying);
		L.RegFunction("IsInitialized", IsInitialized);
		L.RegFunction("IsComplete", IsComplete);
		L.RegFunction("IsBackwards", IsBackwards);
		L.RegFunction("IsActive", IsActive);
		L.RegFunction("ElapsedDirectionalPercentage", ElapsedDirectionalPercentage);
		L.RegFunction("ElapsedPercentage", ElapsedPercentage);
		L.RegFunction("Elapsed", Elapsed);
		L.RegFunction("Duration", Duration);
		L.RegFunction("Delay", Delay);
		L.RegFunction("CompletedLoops", CompletedLoops);
		L.RegFunction("WaitForStart", WaitForStart);
		L.RegFunction("WaitForPosition", WaitForPosition);
		L.RegFunction("WaitForElapsedLoops", WaitForElapsedLoops);
		L.RegFunction("WaitForKill", WaitForKill);
		L.RegFunction("WaitForRewind", WaitForRewind);
		L.RegFunction("WaitForCompletion", WaitForCompletion);
		L.RegFunction("GotoWaypoint", GotoWaypoint);
		L.RegFunction("TogglePause", TogglePause);
		L.RegFunction("SmoothRewind", SmoothRewind);
		L.RegFunction("Rewind", Rewind);
		L.RegFunction("Restart", Restart);
		L.RegFunction("PlayForward", PlayForward);
		L.RegFunction("PlayBackwards", PlayBackwards);
		L.RegFunction("Play", Play);
		L.RegFunction("Pause", Pause);
		L.RegFunction("Kill", Kill);
		L.RegFunction("Goto", Goto);
		L.RegFunction("ForceInit", ForceInit);
		L.RegFunction("Flip", Flip);
		L.RegFunction("Complete", Complete);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("timeScale", get_timeScale, set_timeScale);
		L.RegVar("isBackwards", get_isBackwards, set_isBackwards);
		L.RegVar("id", get_id, set_id);
		L.RegVar("target", get_target, set_target);
		L.RegVar("easeOvershootOrAmplitude", get_easeOvershootOrAmplitude, set_easeOvershootOrAmplitude);
		L.RegVar("easePeriod", get_easePeriod, set_easePeriod);
		L.RegVar("fullPosition", get_fullPosition, set_fullPosition);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int PathLength(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			DG.Tweening.Tween obj = (DG.Tweening.Tween)ToLua.CheckObject<DG.Tweening.Tween>(L, 1);
			float o = obj.PathLength();
			LuaDLL.lua_pushnumber(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int PathGetDrawPoints(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				DG.Tweening.Tween obj = (DG.Tweening.Tween)ToLua.CheckObject<DG.Tweening.Tween>(L, 1);
				UnityEngine.Vector3[] o = obj.PathGetDrawPoints();
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 2)
			{
				DG.Tweening.Tween obj = (DG.Tweening.Tween)ToLua.CheckObject<DG.Tweening.Tween>(L, 1);
				int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
				UnityEngine.Vector3[] o = obj.PathGetDrawPoints(arg0);
				ToLua.Push(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: DG.Tweening.Tween.PathGetDrawPoints");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int PathGetPoint(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			DG.Tweening.Tween obj = (DG.Tweening.Tween)ToLua.CheckObject<DG.Tweening.Tween>(L, 1);
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.Vector3 o = obj.PathGetPoint(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Loops(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			DG.Tweening.Tween obj = (DG.Tweening.Tween)ToLua.CheckObject<DG.Tweening.Tween>(L, 1);
			int o = obj.Loops();
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IsPlaying(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			DG.Tweening.Tween obj = (DG.Tweening.Tween)ToLua.CheckObject<DG.Tweening.Tween>(L, 1);
			bool o = obj.IsPlaying();
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IsInitialized(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			DG.Tweening.Tween obj = (DG.Tweening.Tween)ToLua.CheckObject<DG.Tweening.Tween>(L, 1);
			bool o = obj.IsInitialized();
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IsComplete(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			DG.Tweening.Tween obj = (DG.Tweening.Tween)ToLua.CheckObject<DG.Tweening.Tween>(L, 1);
			bool o = obj.IsComplete();
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IsBackwards(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			DG.Tweening.Tween obj = (DG.Tweening.Tween)ToLua.CheckObject<DG.Tweening.Tween>(L, 1);
			bool o = obj.IsBackwards();
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IsActive(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			DG.Tweening.Tween obj = (DG.Tweening.Tween)ToLua.CheckObject<DG.Tweening.Tween>(L, 1);
			bool o = obj.IsActive();
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ElapsedDirectionalPercentage(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			DG.Tweening.Tween obj = (DG.Tweening.Tween)ToLua.CheckObject<DG.Tweening.Tween>(L, 1);
			float o = obj.ElapsedDirectionalPercentage();
			LuaDLL.lua_pushnumber(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ElapsedPercentage(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				DG.Tweening.Tween obj = (DG.Tweening.Tween)ToLua.CheckObject<DG.Tweening.Tween>(L, 1);
				float o = obj.ElapsedPercentage();
				LuaDLL.lua_pushnumber(L, o);
				return 1;
			}
			else if (count == 2)
			{
				DG.Tweening.Tween obj = (DG.Tweening.Tween)ToLua.CheckObject<DG.Tweening.Tween>(L, 1);
				bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
				float o = obj.ElapsedPercentage(arg0);
				LuaDLL.lua_pushnumber(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: DG.Tweening.Tween.ElapsedPercentage");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Elapsed(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				DG.Tweening.Tween obj = (DG.Tweening.Tween)ToLua.CheckObject<DG.Tweening.Tween>(L, 1);
				float o = obj.Elapsed();
				LuaDLL.lua_pushnumber(L, o);
				return 1;
			}
			else if (count == 2)
			{
				DG.Tweening.Tween obj = (DG.Tweening.Tween)ToLua.CheckObject<DG.Tweening.Tween>(L, 1);
				bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
				float o = obj.Elapsed(arg0);
				LuaDLL.lua_pushnumber(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: DG.Tweening.Tween.Elapsed");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Duration(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				DG.Tweening.Tween obj = (DG.Tweening.Tween)ToLua.CheckObject<DG.Tweening.Tween>(L, 1);
				float o = obj.Duration();
				LuaDLL.lua_pushnumber(L, o);
				return 1;
			}
			else if (count == 2)
			{
				DG.Tweening.Tween obj = (DG.Tweening.Tween)ToLua.CheckObject<DG.Tweening.Tween>(L, 1);
				bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
				float o = obj.Duration(arg0);
				LuaDLL.lua_pushnumber(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: DG.Tweening.Tween.Duration");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Delay(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			DG.Tweening.Tween obj = (DG.Tweening.Tween)ToLua.CheckObject<DG.Tweening.Tween>(L, 1);
			float o = obj.Delay();
			LuaDLL.lua_pushnumber(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CompletedLoops(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			DG.Tweening.Tween obj = (DG.Tweening.Tween)ToLua.CheckObject<DG.Tweening.Tween>(L, 1);
			int o = obj.CompletedLoops();
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int WaitForStart(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			DG.Tweening.Tween obj = (DG.Tweening.Tween)ToLua.CheckObject<DG.Tweening.Tween>(L, 1);
			UnityEngine.Coroutine o = obj.WaitForStart();
			ToLua.PushSealed(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int WaitForPosition(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			DG.Tweening.Tween obj = (DG.Tweening.Tween)ToLua.CheckObject<DG.Tweening.Tween>(L, 1);
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.YieldInstruction o = obj.WaitForPosition(arg0);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int WaitForElapsedLoops(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			DG.Tweening.Tween obj = (DG.Tweening.Tween)ToLua.CheckObject<DG.Tweening.Tween>(L, 1);
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.YieldInstruction o = obj.WaitForElapsedLoops(arg0);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int WaitForKill(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			DG.Tweening.Tween obj = (DG.Tweening.Tween)ToLua.CheckObject<DG.Tweening.Tween>(L, 1);
			UnityEngine.YieldInstruction o = obj.WaitForKill();
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int WaitForRewind(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			DG.Tweening.Tween obj = (DG.Tweening.Tween)ToLua.CheckObject<DG.Tweening.Tween>(L, 1);
			UnityEngine.YieldInstruction o = obj.WaitForRewind();
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int WaitForCompletion(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			DG.Tweening.Tween obj = (DG.Tweening.Tween)ToLua.CheckObject<DG.Tweening.Tween>(L, 1);
			UnityEngine.YieldInstruction o = obj.WaitForCompletion();
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GotoWaypoint(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				DG.Tweening.Tween obj = (DG.Tweening.Tween)ToLua.CheckObject<DG.Tweening.Tween>(L, 1);
				int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
				obj.GotoWaypoint(arg0);
				return 0;
			}
			else if (count == 3)
			{
				DG.Tweening.Tween obj = (DG.Tweening.Tween)ToLua.CheckObject<DG.Tweening.Tween>(L, 1);
				int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
				bool arg1 = LuaDLL.luaL_checkboolean(L, 3);
				obj.GotoWaypoint(arg0, arg1);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: DG.Tweening.Tween.GotoWaypoint");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int TogglePause(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			DG.Tweening.Tween obj = (DG.Tweening.Tween)ToLua.CheckObject<DG.Tweening.Tween>(L, 1);
			obj.TogglePause();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SmoothRewind(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			DG.Tweening.Tween obj = (DG.Tweening.Tween)ToLua.CheckObject<DG.Tweening.Tween>(L, 1);
			obj.SmoothRewind();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Rewind(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				DG.Tweening.Tween obj = (DG.Tweening.Tween)ToLua.CheckObject<DG.Tweening.Tween>(L, 1);
				obj.Rewind();
				return 0;
			}
			else if (count == 2)
			{
				DG.Tweening.Tween obj = (DG.Tweening.Tween)ToLua.CheckObject<DG.Tweening.Tween>(L, 1);
				bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
				obj.Rewind(arg0);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: DG.Tweening.Tween.Rewind");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Restart(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				DG.Tweening.Tween obj = (DG.Tweening.Tween)ToLua.CheckObject<DG.Tweening.Tween>(L, 1);
				obj.Restart();
				return 0;
			}
			else if (count == 2)
			{
				DG.Tweening.Tween obj = (DG.Tweening.Tween)ToLua.CheckObject<DG.Tweening.Tween>(L, 1);
				bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
				obj.Restart(arg0);
				return 0;
			}
			else if (count == 3)
			{
				DG.Tweening.Tween obj = (DG.Tweening.Tween)ToLua.CheckObject<DG.Tweening.Tween>(L, 1);
				bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
				float arg1 = (float)LuaDLL.luaL_checknumber(L, 3);
				obj.Restart(arg0, arg1);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: DG.Tweening.Tween.Restart");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int PlayForward(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			DG.Tweening.Tween obj = (DG.Tweening.Tween)ToLua.CheckObject<DG.Tweening.Tween>(L, 1);
			obj.PlayForward();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int PlayBackwards(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			DG.Tweening.Tween obj = (DG.Tweening.Tween)ToLua.CheckObject<DG.Tweening.Tween>(L, 1);
			obj.PlayBackwards();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Play(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			DG.Tweening.Tween obj = (DG.Tweening.Tween)ToLua.CheckObject<DG.Tweening.Tween>(L, 1);
			DG.Tweening.Tween o = obj.Play();
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Pause(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			DG.Tweening.Tween obj = (DG.Tweening.Tween)ToLua.CheckObject<DG.Tweening.Tween>(L, 1);
			DG.Tweening.Tween o = obj.Pause();
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Kill(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				DG.Tweening.Tween obj = (DG.Tweening.Tween)ToLua.CheckObject<DG.Tweening.Tween>(L, 1);
				obj.Kill();
				return 0;
			}
			else if (count == 2)
			{
				DG.Tweening.Tween obj = (DG.Tweening.Tween)ToLua.CheckObject<DG.Tweening.Tween>(L, 1);
				bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
				obj.Kill(arg0);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: DG.Tweening.Tween.Kill");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Goto(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				DG.Tweening.Tween obj = (DG.Tweening.Tween)ToLua.CheckObject<DG.Tweening.Tween>(L, 1);
				float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
				obj.Goto(arg0);
				return 0;
			}
			else if (count == 3)
			{
				DG.Tweening.Tween obj = (DG.Tweening.Tween)ToLua.CheckObject<DG.Tweening.Tween>(L, 1);
				float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
				bool arg1 = LuaDLL.luaL_checkboolean(L, 3);
				obj.Goto(arg0, arg1);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: DG.Tweening.Tween.Goto");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ForceInit(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			DG.Tweening.Tween obj = (DG.Tweening.Tween)ToLua.CheckObject<DG.Tweening.Tween>(L, 1);
			obj.ForceInit();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Flip(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			DG.Tweening.Tween obj = (DG.Tweening.Tween)ToLua.CheckObject<DG.Tweening.Tween>(L, 1);
			obj.Flip();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Complete(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				DG.Tweening.Tween obj = (DG.Tweening.Tween)ToLua.CheckObject<DG.Tweening.Tween>(L, 1);
				obj.Complete();
				return 0;
			}
			else if (count == 2)
			{
				DG.Tweening.Tween obj = (DG.Tweening.Tween)ToLua.CheckObject<DG.Tweening.Tween>(L, 1);
				bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
				obj.Complete(arg0);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: DG.Tweening.Tween.Complete");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_timeScale(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DG.Tweening.Tween obj = (DG.Tweening.Tween)o;
			float ret = obj.timeScale;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index timeScale on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isBackwards(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DG.Tweening.Tween obj = (DG.Tweening.Tween)o;
			bool ret = obj.isBackwards;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index isBackwards on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_id(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DG.Tweening.Tween obj = (DG.Tweening.Tween)o;
			object ret = obj.id;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index id on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_target(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DG.Tweening.Tween obj = (DG.Tweening.Tween)o;
			object ret = obj.target;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index target on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_easeOvershootOrAmplitude(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DG.Tweening.Tween obj = (DG.Tweening.Tween)o;
			float ret = obj.easeOvershootOrAmplitude;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index easeOvershootOrAmplitude on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_easePeriod(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DG.Tweening.Tween obj = (DG.Tweening.Tween)o;
			float ret = obj.easePeriod;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index easePeriod on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_fullPosition(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DG.Tweening.Tween obj = (DG.Tweening.Tween)o;
			float ret = obj.fullPosition;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index fullPosition on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_timeScale(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DG.Tweening.Tween obj = (DG.Tweening.Tween)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.timeScale = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index timeScale on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_isBackwards(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DG.Tweening.Tween obj = (DG.Tweening.Tween)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.isBackwards = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index isBackwards on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_id(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DG.Tweening.Tween obj = (DG.Tweening.Tween)o;
			object arg0 = ToLua.ToVarObject(L, 2);
			obj.id = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index id on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_target(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DG.Tweening.Tween obj = (DG.Tweening.Tween)o;
			object arg0 = ToLua.ToVarObject(L, 2);
			obj.target = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index target on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_easeOvershootOrAmplitude(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DG.Tweening.Tween obj = (DG.Tweening.Tween)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.easeOvershootOrAmplitude = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index easeOvershootOrAmplitude on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_easePeriod(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DG.Tweening.Tween obj = (DG.Tweening.Tween)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.easePeriod = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index easePeriod on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_fullPosition(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DG.Tweening.Tween obj = (DG.Tweening.Tween)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.fullPosition = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index fullPosition on a nil value");
		}
	}
}

