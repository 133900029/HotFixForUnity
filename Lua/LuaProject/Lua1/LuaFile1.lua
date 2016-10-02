--region *.lua
--Date
--此文件由[BabeLua]插件自动生成


---------------lua 安装


--使用官方源码编译
--使用lua for window
--使用第三方 babe和第三方exe




---------------lua 安装



---------------变量

--num=100--全局变量
--local text=101--局部变量
--print(num)
--print("Hello")

---------------变量

---------------函数

--function sayhello()
--    print("hello")
--end

--function max(a,b)
--        if(a>b) then
--        return a
--        else 
--        return b
--        end
--end

-- function repeatNum()
--    for var=1,100 do
--    print(var)
--    end
-- end

--repeatNum()
--print(max(2,3))

---------------函数



---------------表

-- Config={hello="Hello Lua",wo="Me"}
-- Config.words="Hello"
-- Config.num=100
-- Config["name"]="zhangsan"
---- print(Config.words)
---- print(Config["name"])
---- print(Config.hello)
---- print(Config.wo)

-- for key,value in pairs(Config) do
--    print(key,value)
-- end

---------------表

---------------数组


--索引从1开始 数组
--arr = {1,2,3,"Hello"}
--for arrKey,arrValue in pairs(arr) do
--    print(arrKey,arrValue)
--end

--arrNum={}
--for var=1,100 do
--    table.insert(arrNum,1,var)
--end

--for key,var in pairs(arrNum) do
--    print(key,var)
--end

--闪退
--print(table.maxn(arrNum))


---------------数组

---------------类的实现  表复制
--function clone(tab)
--   local ins={}
--   for key,value in pairs(tab) do
--        ins[key]=value
--   end
--   return ins
--end

--People={}

--function People.sayHi()
--    print("Hello")
--end

--People.sayHellow = function(self)
--    print("Hello"..self.name)
--end

--实现1
--local p=clone(People)
--p.sayHi()
--实现2
--People.new = function(name)
--    local self = clone(People)
--    self.name = name
--    return self
--end

--local p = People.new("zhang san")
--p.sayHellow(p)
--   ：  等价于  默认把 实例 作为第一个参数传入
--p:sayHellow()

--Man = {}
--新增方法
--Man.sayHelloMan = function(self)
--    print("Man say Hello" .. self.name)
--end
--重写方法
--Man.sayHellow = function(self)
--    print("Man"..self.name)
--end


--Man.new = function(name)
--    local self = People.new(name)
--    copy(self,Man)
--    return self
--end

--function copy(dist,tab)
--    for key,value in pairs(tab) do
--        dist[key] = value
--    end
--end


--local man = Man.new("List")
--man:sayHellow()
--man:sayHelloMan()

---------------类的实现  表复制 和继承


---------------类的实现  函数闭包 速度稍微慢


-- function People(name)
--    local self = {}

--    local function init()
--    self.name = name
--    end

--    self.sayHi = function()
--    print("say Hi" .. name)
--    end

--    init()

--    return self
-- end

-- function Man(name)
--    local self = People(name)

--    self.sayHellow = function()
--        print("Man " .. self.name)
--    end
--    return self
-- end

-- local p = People("zhangsan")
-- p.sayHi()

--local m = Man("zhangsan")
--m.sayHellow()
--m.sayHi()
 
---如何显示报错
---如何调试
---如何代码对齐
---如何使用sublinme



---------------类的实现  函数闭包 速度稍微慢



--------------lua的值与类型
 --[[
 a
 ]]--

-- str1 = "Hello"
-- str2 = 'Hello'

  --[===[
 a[[ ]]
 ]===]--

 --动态类型语言lua


--每个值都带自身的类型信息
-- print(type("Hello"))
-- print(type(1))
-- print(type(print))

--变量没有固定类型
-- a = 10
-- print(type(a))
-- a = "Hello"
-- print(type(a))

--nil 用来表示有意义但是不存在的值
--给值赋值 nil 等于删除这个值

--不需要boolean 声明
--只有false 和nil 被视为false

--number 整数和浮点数
--数字常量 3.0   3.1416


--string 不可变字符串
--   .. 连接

--a = "\097" --一般三位
--b = '\097'
--c = [[lua
--1]]
--d = [==[lua
--2]==]
--print(a)
--print(b)
--print(c)
--print(d)


--print("1+1")
--print(1+'1')--2
----print(1+'q')
--print(11 .. 11 + '1')--1112

--print(type(tostring(100)))--string
--str = "Hello world"
--print(#str)
--strNew = string.gsub(str,"world","lua")--字符串固定无法改。只能创建新
--print(strNew)

 --function
 --thread
 
 --userdata lua只能赋值 判断。不能改变
 --table 除了nil和NaN 之外所有值都可以做索引
 --table 表  lua唯一的数据结构

-- tableTest = {}
-- m = "n"
-- tableTest[m] = 1
-- tableTest[1] = "Hello"

-- a = {}
-- a['x'] = 1
-- b = a
-- print(a['x'])
-- print(a.x)
-- print(b['x'])
-- b['x'] = 10
-- print(a['x'])
-- print(b['x'])
-- b = nil

 --在lua中 表 函数 线程 用户数据 都是对象，变量不持有值，只有引用


--------------lua的值与类型


--------------lua的表达式


--整数 + 整数 = 整数
--字符串 + 整数 = 整数
-- ==先比较类型，再比较字符串
--print(1==1.0)--true
--and  or  not
--print(not nil)--true
----第一个为真就返回第二个
--print(4 and 5)--5
--print(nil and 5)--nil
----第一个为真就返回第一个
--print(4 or 5)--4
--print(nil or 5)--5

--x = x or y
--当x没值时，设置成y
--(a and b) or c
--a?b:c

--max = (2 > 3) and 2 or 3
--true and false

--^ 和 ..是从右到左
--数组类型的表
--week = {"Mon","Tue"}
--print(week[1])
----字典类型的表
--student = {Z = 1,H = "Hello"}
--print(student.Z)

--tableList = {
--    color = "Yellow",
--    {name = "H",age = "B"}
--}
--print(tableList[1].name)


--if exp then
--block
--elseif exp then
--block
--else
--block
--end

--while exp do
--block
--end

--repeat
--block
--until exp

--for var = exp1, exp2, exp3 do
--block
--end

--for k,v in explist do
--block
--end

--do return end
--end

--------------lua的表达式


--------------lua的面试题

--table  可以做数组。可以做key value
--#array  ==统计到空白值
--table.max(array)  ==统计所有值
--array[1] 和 array["1"] 可以同时存在

--local obj = {x = 10}
--function obj:call()
--    return self.x;
--end

--local a = obj.call(obj)
--local b = obj:call()
--print(a,b)

--------------lua的面试题



print("end")

os.execute("pause") 

--slua + new UI

--lua基础
--http://www.yiibai.com/lua/

--例子出处
--http://my.jikexueyuan.com/ime/record/
--http://my.jikexueyuan.com/suool/record/
--http://my.jikexueyuan.com/0mVUggqaV/record/

--参考网站
--http://www.lua.org/manual/5.3/
--http://www.lua.org/cgi-bin/demo


--http://blog.csdn.net/sgamerw/article/details/10024131
--userdata
--setmetadata
--http://www.jb51.net/article/55724.htm


--注释快捷键
--ctrl+K+C
--ctrl+K+U


--endregion
