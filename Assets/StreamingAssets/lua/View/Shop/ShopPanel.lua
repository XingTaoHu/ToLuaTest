local transform;
local gameObject;

ShopPanel = {};
local this = ShopPanel;

--启动事件--
function ShopPanel.Awake(obj)
    gameObject = obj;
    transform = obj.transform;

    this.InitPanel();
    logWarn("ShopPanel Awake lua --->>"..gameObject.name);
end

--初始化面板--
function ShopPanel.InitPanel()
    log("ShopPanel InitPanel");

    ShopPanel.btnClose = transform:Find("CloseButton").gameObject;
    ShopPanel.shopTitle = transform:Find("TitleText"):GetComponent("Text");

    ShopPanel.shopTitle.text = "热更商店";

end

function ShopPanel.OnDestroy()
    logWarn("OnDestroy---->>>");
end