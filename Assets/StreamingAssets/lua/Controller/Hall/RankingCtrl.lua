RankingCtrl = {};
local this = RankingCtrl;

local behaviour;
local transform;
local gameObject;

--构建函数
function RankingCtrl.New()
    logWarn("RankingCtrl.New--->>");
    return this;
end

function RankingCtrl.Awake()
    logWarn("this is RankingCtrl, im loaded.");
end

--启动事件
function RankingCtrl.OnCreate(obj)
    gameObject = obj;
    transform = obj.transform;

    behaviour = gameObject:GetComponent('LuaBehaviour');
end

function RankingCtrl.OnClick(go)
    destroy(gameObject);
end

function RankingCtrl.Close()
    panelMgr:ClosePanel(CtrlNames.Ranking);
end