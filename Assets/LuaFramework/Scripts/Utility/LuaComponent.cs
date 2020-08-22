using System.Collections;
using UnityEngine;
using LuaInterface;
using LuaFramework;

public class LuaComponent : MonoBehaviour 
{

	//Lua表
	public LuaTable table;

	/// <summary>
	/// 添加lua组件
	/// </summary>
	/// <param name="go"></param>
	/// <param name="tableClass"></param>
	/// <returns></returns>
	public static LuaTable Add(GameObject go, LuaTable tableClass)
	{
		LuaFunction fun = tableClass.GetLuaFunction("New");
		if (fun == null)
		{
			return null;
		}

		//object[] rets = fun.Call(tableClass);
		//      if (rets.Length != 1)
		//          return null;
		//      LuaComponent cmp = go.AddComponent();
		//      cmp.table = (LuaTable)rets[0];

		//lua升级后，Call方法不再返回对象，因此改为Invoke方法实现
		object rets = fun.Invoke<LuaTable, object>(tableClass);
		if (rets == null)
		{
			return null;
		}
		LuaComponent cmp = go.AddComponent<LuaComponent>();
		cmp.table = (LuaTable)rets;
		cmp.CallAwake();
		return cmp.table;
	}

	/// <summary>
	/// 添加Lua组件，允许携带一个额外参数
	/// </summary>
	/// <param name="go"></param>
	/// <param name="tableClass"></param>
	/// <param name="args"></param>
	/// <returns></returns>
	public static LuaTable Add(GameObject go, LuaTable tableClass, LuaTable args)
	{
		LuaFunction fun = tableClass.GetLuaFunction("New");
		if (fun == null)
			return null;
		object rets = fun.Invoke<LuaTable, object>(tableClass);
		if (rets == null)
		{
			return null;
		}
		LuaComponent cmp = go.AddComponent<LuaComponent>();
		cmp.table = (LuaTable)rets;
		cmp.CallAwake(args);
		return cmp.table;
	}

	/// <summary>
	/// 添加Lua组件，isAllow为true时，表示只添加一次组件，如果已经存在，就不再添加
	/// </summary>
	/// <param name="go"></param>
	/// <param name="tableClass"></param>
	/// <param name="isAllowOneComponent"></param>
	/// <returns></returns>
	public static LuaTable Add(GameObject go, LuaTable tableClass, bool isAllowOneComponent)
	{
		if (isAllowOneComponent)
		{
			LuaComponent luaComponent = go.GetComponent<LuaComponent>();
			if (luaComponent != null)
			{
				return luaComponent.table;
			}
		}
		return Add(go, tableClass);
	}

	/// <summary>
	/// 获取lua组件
	/// </summary>
	/// <param name="go"></param>
	/// <param name="table"></param>
	/// <returns></returns>
	public static LuaTable Get(GameObject go, LuaTable table)
	{
		LuaComponent cmp = go.GetComponent<LuaComponent>();
		string mat1 = table.ToString();
		string mat2 = cmp.table.GetMetaTable().ToString();
		if (mat1 == mat2)
		{
			return cmp.table;
		}
		return null;
	}

	/// <summary>
	/// 调用lua表的Awake方法
	/// </summary>
	void CallAwake()
	{
		LuaFunction fun = table.GetLuaFunction("Awake");
		if (fun != null)
		{
			fun.Call(table, gameObject);
		}
	}

	/// <summary>
	/// 调用lua表的Awake方法（携带一个参数）
	/// </summary>
	/// <param name="args"></param>
	void CallAwake(LuaTable args)
	{
		LuaFunction fun = table.GetLuaFunction("Awake");
		if (fun != null)
		{
			fun.Call(table, gameObject, args);
		}
	}

	private void OnEnable()
	{
		if (table == null)
			return;
		LuaFunction fun = table.GetLuaFunction("OnEnable");
		if (fun != null)
		{
			fun.Call(table, gameObject);
		}
	}

	private void Start()
	{
		LuaFunction fun = table.GetLuaFunction("Start");
		if (fun != null)
		{
			fun.Call(table, gameObject);
		}
	}

	void Update()
	{
		LuaFunction fun = table.GetLuaFunction("Update");
		if (fun != null)
		{
			fun.Call(table, gameObject);
		}
	}

	private void FixedUpdate()
	{
		LuaFunction fun = table.GetLuaFunction("FixedUpdate");
		if (fun != null)
		{
			fun.Call(table, gameObject);
		}
	}

	private void LateUpdate()
	{
		LuaFunction fun = table.GetLuaFunction("LateUpdate");
		if (fun != null)
		{
			fun.Call(table, gameObject);
		}
	}

	private void OnDisable()
	{
		if (table != null)
		{
			LuaFunction fun = table.GetLuaFunction("OnDisable");
			if (fun != null)
			{
				fun.Call(table, gameObject);
			}
		}
	}

	private void OnDestroy()
	{
		if (table != null)
		{
			LuaFunction fun = table.GetLuaFunction("OnDestroy");
			if (fun != null)
			{
				fun.Call(table, gameObject);
			}
		}
	}

}
