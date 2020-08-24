local transform;
local gameObject;

HallPanel = {};
local this = HallPanel;

--启动事件--
function HallPanel.Awake(obj)
    gameObject = obj;
    transform = obj.transform;
    this.InitPanel();
    logWarn("HallPanelAwake lua --->>"..gameObject.name);
end

--初始化面板--
function HallPanel.InitPanel()
    logWarn("this is HallPanel, im loaded.");
    --排行榜按钮--
    HallPanel.btnRanking = transform:Find("BtnRanking").gameObject;
    --商店按钮--
    HallPanel.btnShop = transform:Find("BtnShop").gameObject;

    --排行榜面板--
    HallPanel.rankingPanel = transform.parent:Find("RankingPanel").gameObject;

    --调用Ctrl中panel创建完成时的方法--
    HallCtrl.OnCreate(gameObject);
end

function HallPanel.OnDestroy()
    logWarn("OnDestroy---->>>");
end