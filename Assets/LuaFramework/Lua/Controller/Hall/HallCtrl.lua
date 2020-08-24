HallCtrl = {};
local this = HallCtrl;

local behaviour;
local transform;
local gameObject;

--构建函数--
function HallCtrl.New()
    logWarn("HallCtrl.New--->>");
    return this;
end

function HallCtrl.Awake()
    logWarn("HallCtrl.Awake--->>");
    logWarn("this is HallCtrl, im loaded.");
end

--启动事件--
function HallCtrl.OnCreate(obj)
    gameObject = obj;
    transform = obj.transform;

    UIEventEx.AddButtonClick(HallPanel.btnRanking, function ()
        log("you clicked ranking btn");

        HallPanel.rankingPanel.gameObject:SetActive(true);
    end);

    UIEventEx.AddButtonClick(HallPanel.btnShop, function ()
        log("you clicked shop btn");
        --实例化商店面板--
        local shopCtrl = CtrlManager.GetCtrl(CtrlNames.Shop);
        shopCtrl:Awake();
    end);
end

--单击事件--
function HallCtrl.OnClick(go)
    destroy(gameObject);
end

--关闭事件--
function HallCtrl.Close()
    panelMgr:ClosePanel(CtrlNames.Hall);
end