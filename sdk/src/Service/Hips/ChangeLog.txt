2018-06-12 version:1.0.1
1.queryServerNoAgent接口的osType为非必传参数
2.queryServerNoAgentCount接口regionId为无效参数，去掉
3.queryWarnsServerWebShells的interval参数是无效，去掉
4.queryWarnsCount接口接口regionId为无效参数，去掉

2018-06-07 version:1.0.0
1.safedog模块重新命名为hips

2018-05-24 version: 0.1.12
1.去掉请求参数regionId，对下边无效的接口：
queryLeaksRecentCountByOS
queryLeaksRecentCounts
queryLeaksTopCountServers
queryServerHandleLeaksAdvice
queryWarnsReport
queryWarnsAttackCount
queryNotices
queryWarnsCount
queryWarnsServerWeakPasswords
queryWarnsServerAttacks
queryWarnsServerRemoteLogins
queryWarnsServerWebShells

2018-05-24 version: 0.1.11
1.更新queryServerLeakInfos接口leakName，leakStatus参数为可选项。

2018-05-24 version: 0.1.10
1.更新NodifyService文件，修复url拼写错误nodifyRules为notifyRules。

2018-05-23 version: 0.1.9
1.queryServers接口更新参数regionId为必传项。

2018-05-23 version: 0.1.8
1.fixServerLeaks接口更新参数regionId为必传项。

2018-05-21 version: 0.1.7
1.queryServerLoginLocations接口新增参数regionId，必传项。

2018-05-04 version: 0.1.6
1.当初版本为long类型定义了number格式，调整number为int64

2018-05-04 version: 0.1.5
1.当初版本为long类型定义了number格式，调整number为integer
2.更新接口queryNotifyRuleContacts，queryNotifyRules，setNotifyRule报警通知规则url前缀为/nodifyRules，旧前缀为/nodify/rules

2018-05-04 version: 0.1.4
1.新增接口：
  queryNotifyRuleContacts(查询报警通知规则联系人)
  queryNotifyRules(查询报警通知规则列表)
  setNotifyRule(设置报警通知规则)
2.更新接口queryLocations（查询位置信息）请求参数country，province为非必填
3.更新接口queryNotice（查询通知詳情）返回result属性noticeInfos重命名为noticeInfo
4.更新接口setServerLoginLocations（设置常用登录地(只对安装Agent的主机生效)）描述，新增必要属性regionId，新增返回result(包含属性code)。

2018-04-23 version: 0.1.3
1.去掉regionId路径描述
2.pageNumber和pageSize为非必要参数

2018-04-23 version: 0.1.2
1.dataCenter改为regionId。
2.queryServerLeakInfos接口返回内容为LeakServerDetail。
3.pageSize和pageNumber参数为必填。
4.去掉多余的请求参数dataCenter。
5.queryServerNoAgent接口请求参数regionId调整为必要，参数serverName调整了string，非必要。
6.queryLeaks接口请求参数osType调整为string，非必要, 参数serverNameFilter整为string，非必要。

2018-04-18 version: 0.1.1
1.更新接口"/warns:queryReport"， 返回结果reports重命名为counts， 新增times字符串数组。
2.更新接口"/notices/{noticeId}"，请求参数type重命名为noticeType。
3.更新接口"/servers"，返回结果数组条目对象新增属性agentLost，表示是否未安装安全狗客户端(true:没安装;false:已安装)。

2018-03-27 version: 0.1.0
1. 初始版本.
.位置信息接口
.通知信息接口
.主机信息接口
.统计信息接口
.告警信息接口
.漏洞信息接口
