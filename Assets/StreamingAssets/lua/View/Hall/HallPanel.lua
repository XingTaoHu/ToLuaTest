local transform;
local gameObject;

HallPanel = {};
local this = HallPanel;

--启动事件--
function HallPanel.Awake(obj)
    gameObject = obj;
    transform = obj.transform;

    this.InitPanel();
    logWarn("Awake lua --->>"..gameObject.name);
end

--初始化面板--
function HallPanel.InitPanel()
    logWarn("this is HallPanel, im loaded.");
    --排行榜按钮--
    HallPanel.btnRanking = transform:FindChild("BtnRanking").gameObject;
    --商店按钮--
    HallPanel.btnShop = transform:FindChild("BtnShop").gameObject;

    --调用Ctrl中panel创建完成时的方法--
    HallCtrl.OnCreate(gameObject);
end

function HallPanel.OnDestroy()
    logWarn("OnDestroy---->>>");
end