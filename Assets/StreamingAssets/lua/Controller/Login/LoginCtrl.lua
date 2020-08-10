LoginCtrl = {};
local this = LoginCtrl;

local behaviour;
local transform;
local gameObject;

--构建函数--
function LoginCtrl.New()
    logWarn("LoginCtrl.New--->>");
    return this;
end

function LoginCtrl.Awake()
    logWarn("LoginCtrl.Awake--->>");
    panelMgr:CreatePanel('Login', this.OnCreate);
end

--启动事件--
function LoginCtrl.OnCreate(obj)
    gameObject = obj;
    transform = obj.transform;
    behaviour = gameObject:GetComponent('LuaBehaviour');

    --behaviour:AddClick(LoginPanel.loginBtn, function ()
    --    log("你点击了登录");
    --end);
    --behaviour.AddInputFieldEndEditHandler(LoginPanel.accountInput, function (account)
    --    log("账号输入结束，账号"..account);
    --end);
    --behaviour:AddToggle(LoginPanel.savePwdToggle, function (go, toggleVal)
    --    log("记住密码:"..tostring(toggleVal));
    --end);

    UIEventEx.AddButtonClick(LoginPanel.loginBtn, function ()
        log("你点击了登录");
    end);
    UIEventEx.AddInputFieldEndEditHandler(LoginPanel.accountInput, function (account)
        log("账号输入结束，账号"..account);
    end);
    UIEventEx.AddToggle(LoginPanel.savePwdToggle, function (go, toggleVal)
        log("记住密码:"..tostring(toggleVal));
    end);
end

--单击事件--
function LoginCtrl.OnClick(go)
    destroy(gameObject);
end

--关闭事件--
function LoginCtrl.Close()
    panelMgr:ClosePanel(CtrlNames.Login);
end