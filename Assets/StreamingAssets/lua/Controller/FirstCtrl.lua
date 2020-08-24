FirstCtrl = {};
local this = FirstCtrl;

local behaviour;
local transform;
local gameObject;

--构建函数--
function FirstCtrl.New()
    logWarn("FirstCtrl.Awake--->>");
    --panelMgr:CreatePanel('First', this.OnCreate);
end

--启动事件--
function FirstCtrl.OnCreate(obj)
    gameObject = obj;
    transform = obj.transform;
    behaviour = gameObject:GetComponent('LuaBehaviour');
    behaviour:AddClick(FirstPanel.btnClose, function()
        log("你点击了关闭按钮");
    end);

    --加载prefab.unity3d资源包--
    resMgr:LoadPrefab("prefabs.unity3d", {"ImgOrc"}, function (prefabs)
        log(prefabs.Length);
        log(prefabs[0].name);
        local go = newObject(prefabs[0]);
        go.transform:SetParent(transform);
        go.transform.localPosition = Vector3.zero;
        go.transform.localScale = Vector3.one;
    end);
end

--单击事件--
function FirstCtrl.OnClick(go)
    destroy(gameObject);
end

--关闭事件--
function FirstCtrl.Close()
    panelMgr:ClosePanel(CtrlNames.First);
end