ShopCtrl = {};
local this = ShopCtrl;

local behaviour;
local transform;
local gameObject;

--构建函数--
function ShopCtrl.New()
    logWarn("ShopCtrl.New--->>");
    return this;
end

function ShopCtrl.Awake()
    logWarn("this is ShopCtrl, im loaded.");
    panelMgr:CreatePanel('Shop', this.OnCreate);
end

function ShopCtrl.OnCreate(obj)
    gameObject = obj;
    transform = obj.transform;
    behaviour = gameObject:GetComponent('LuaBehaviour');

    UIEventEx.AddButtonClick(ShopPanel.btnClose, function ()
        log("close shop panel");
        destroy(gameObject);
    end);

end

function ShopCtrl.Close()
    panelMgr:ClosePanel(CtrlNames.Shop);
end