local transform;
local gameObject;

LoginPanel = {};
local this = LoginPanel;

--启动事件--
function LoginPanel.Awake(obj)
    gameObject = obj;
    transform = obj.transform;

    this.InitPanel();
    logWarn("Awake lua --->>"..gameObject.name);
end

--初始化面板--
function LoginPanel.InitPanel()
    --账号输入框
    LoginPanel.accountInput = transform:Find("AccountInput").gameObject;
    --密码输入框
    LoginPanel.passwordInput = transform:Find("PwdInput").gameObject;
    --登录按钮
    LoginPanel.loginBtn = transform:Find("LoginButton").gameObject;
    --记住密码
    LoginPanel.savePwdToggle = transform:Find("Toggle").gameObject;
end

--单击事件--
function LoginPanel.OnDestroy()
    logWarn("OnDestroy---->>>");
end