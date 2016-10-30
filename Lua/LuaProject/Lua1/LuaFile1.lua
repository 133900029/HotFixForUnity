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
--    for i=1,100 do
--    print(i)
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

--a = true
--b = true

--if ( a and b )
--then
--   print("a and b - 条件为 true" )
--end

--if ( a or b )
--then
--   print("a or b - 条件为 true" )
--end

--print("---------分割线---------" )

---- 修改 a 和 b 的值
--a = false
--b = true

--if ( a and b )
--then
--   print("a and b - 条件为 true" )
--else
--   print("a and b - 条件为 false" )
--end

--if ( not( a and b) )
--then
--   print("not( a and b) - 条件为 true" )
--else
--   print("not( a and b) - 条件为 false" )
--end

--and 第一个为真就返回第二个，第一个为假就返回第一个
--or 第一个为真就返回第一个，第一个为假就返回第二个
--当变量为true和false 的时候和C#一样
--当变量是数字的时候就按and 和or的规则

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

--------------lua的类
 


--Base = {}
--function Base:New(o)
--	o = o or {}         --子类 o 创建 父类关系  o 相当于是 self（base）的子类
--	setmetatable(o,self)--self 指 Base 相当于 this
--	self.__index = self --o 不存在方法的时候，会寻找（元表self）中的Index的方法
--	o:Init()            -- __index 相当于 父类指针
--	return o
--end
--function Base:Init()
--	self.mX = 10
--	self.mY = {y = 20}
--	print("Base:Init()")
--end
--function Base:SetX(x)
--	self.mX = x
--end
--function Base:GetX()
--	return self.mX
--end
--function Base:SetY(y)
--	self.mY.y = y
--end
--function Base:GetY()
--	return self.mY.y
--end
----return Base




----new 的时候 生成 meta 和 初始化1次
--Child = Base:New()--Child --> metadata --> Base
--function Child:New(o)
--	o = o or {}
--	setmetatable(o,self)
--	self.__index = self
--	o:Init()
--	return o
--end
--function Child:Init()
--	local parent = getmetatable(Child)
--	parent.__index.Init(self)--个人认为没用，因为child 本身就 是init后的base
--	self.mW = 100
--	print("Child:Init()")
--end
--function Child:SetW(w)
--	self.mW = w
--end
--function Child:GetW()
--	return self.mW
--end

----new 的时候 生成 meta 和 初始化2次
----    o  = self     o
--local wu = Child:New()-- wu --> metadata --> Child
--wu:SetW(200)
--print(wu:GetW())-->200
----wu:SetX(44)
--print(wu:GetX())-->44
 



--------------lua的类

--------------标准库

--assert(string)--执行代码字符串
--dofile(xxx.lua)--执行代码


--------------标准库




 


--两种都可以
--local Vector3 = UnityEngine.Vector3
--import "UnityEngine"

--    local i = 0

--	print("main")

--	while(i < 5)
--	do
--		i = i + 1
--		print("while", i)
--	end

--	for i = 1 , 10 , 1
--	do
--		print("for:", i)
--	end

--变量 = 非变量
--key = value
--key不能为数字 1 不能为 "1"
--key可以为字母 a 但不能是 "a"
--value可以为数字 1 可以为 "1"
--value可以为字母 "a" 不可以为字母a
--key一定要字母且不带引号--不能对数字和字符串赋值
--value只要不是字母 a就可以--变量不能作为value

--非变量 = 非变量
--[key] = value
--key可以为1 或者"1"
--key可以为"a" 不能为a
--value可以为1 或者 "1"
--value可以为"a" 不能为a
--key不能为a--变量不能作为key
--value不能为a--变量不能作为value

--ipairs array
--pairs dictionary
 
--array = { key = "value", "2", "5", "3", "test"}--key = "value" 在使用table的时候不包括在内
--for k,v in ipairs(array)
--do
--	print("ipairs", k, ":", v)
--end

--local x = 0
--repeat 
--	print("repeat:", x)
--	x = x + 1
--	if( x > 3) then
--	break
--	end
--until(x > 5)

--local v = 1
--if(v > 7) then 
--	print("v > 7")
--elseif(v > 10) then
--	print("v > 10")
--else
--	print("else")
--end


--print("concat:", table.concat(array,":"))
--print("concat:", table.concat(array, ":", 1, 2))
----数组开始的位置和结束的位置 且用：链接
--table.insert(array, "in")--没有返回
--print("insert:", table.concat(array, ":"))
--table.insert(array, 1, "first")--没有返回
--print("insert:", table.concat(array, ":"))

--print("count:", #array)
--print("count:", table.maxn(array))

--table.remove(array, "1")--没有返回
--print("remove:", table.concat(array, ":"))

--table.sort(array)
--print("sort", table.concat(array, ":"))

--sortFunc = function(a, b) return b < a end
--table.sort(array, sortFunc)
--print("sortFunc", table.concat(array, ":"))

--table.foreach(array, function(i, v) print("foreach", i, v) end)

----print(getn(array))--table 元素个数

--tbl = {[1] = "a", [2] = "b", [3] = "c", [26] = "z"}
--print("#:", #tbl)--3               -- 因为26和之前的数字不连续, 所以不算在数组部分内
--print("maxn:", table.maxn(tbl))--26   --table.maxn()函数返回指定table中所有正数key值中最大的key值


--链接用.. 多个参数用...
-- function average(...)
--   result = 0
--   local arg={...}
--   for i,v in ipairs(arg) do
--      result = result + v
--   end
--   print("总共传入 " .. #arg .. " 个数")
--   return result/#arg
--end

--print("平均值为",average(10,5,3,4,5,6))

--字符串 '' "" [[]]

--print("upper:", string.upper("aaa"))
--print("lower:", string.lower("AAA"))

--local gsub = string.gsub("abcdefc", "c", "x", 2)
--print("gsub:", gsub)

--local find = string.find("hello lua yes", "lua")
--print("find:", find)

--local reverse = string.reverse("abcd")
--print("reverse:", reverse)

--local format = string.format("hello %d %s", 10, "what")
--print("format:", format)

--local char = string.char(97, 98, 99)
--print("char:", char)

--local byte = string.byte("ABCD")--默认转换第一个
--print("byte:", byte)

--local len = string.len("ABCDE")
--print("len:", len)

--local rep = string.rep("ABC", 2)
--print("rep:", rep)

--local x = "xyz"
--local z = "abc"
--print("..:", x..z)

--require("x")
--x.a

--local m = require("module")
--m.a

--local path = "/usr/local/lua/lib/libluasocket.so"
-- 或者 path = "C:\\windows\\luasocket.dll"，这是 Window 平台下
--local f = assert(loadlib(path, "luaopen_socket"))--类名或者包名
--f()  -- 真正打开库


--coroutine.create()


--coroutine.create()	创建coroutine，返回coroutine， 参数是一个函数，当和resume配合使用的时候就唤醒函数调用
--coroutine.resume()	重启coroutine，和create配合使用
--coroutine.yield()	    挂起coroutine，将coroutine设置为挂起状态，这个和resume配合使用能有很多有用的效果
--coroutine.status()	查看coroutine的状态  注：coroutine的状态有三种：dead，suspend，running，具体什么时候有这样的状态请参考下面的程序
--coroutine.wrap（）	创建coroutine，返回一个函数，一旦你调用这个函数，就进入coroutine，和create功能重复
--coroutine.running()	返回正在跑的coroutine，一个coroutine就是一个线程，当使用running的时候，就是返回一个corouting的线程号

--co = coroutine.create(
--	function(varI, varJ)
--		print("coroutine.create:", varI)
--	end
--)

--coroutine.resume(co, 3, 4)
--print("coroutine.status:", coroutine.status(co))

--co1 = coroutine.wrap(
--	function(varI ,varJ)
--		print("coroutine.wrap:", varI)
--	end
--)
--co1(4)

--co2 = coroutine.create(
--	function()
--		for var = 1, 10, 1
--		do

--			if(var == 3)
--			then
--				print("coroutine.yield:", var)
--			end
--				print("coroutine:", var)
--			coroutine.yield()
--		end
--	end
--)

--coroutine.resume(co2)
--coroutine.resume(co2)
--coroutine.resume(co2)
--print("coroutine.running:", coroutine.running())



--function foo (a)
--    print("foo 函数输出", a)
--    return coroutine.yield(2 * a) -- 返回  2*2 的值
--end

--co = coroutine.create(function (a , b)
--    print("第一次协同程序执行输出", a, b) -- co-body 1 10
--    local r = foo(a + 1)--foo(2)
--    --r 为传入去的 "r"

--    print("第二次协同程序执行输出", r)--r
--    local r, s = coroutine.yield(a + b, a - b)  -- 1+10=11   1-10=-9
--	--r, s  == x, y

--    print("第三次协同程序执行输出", r, s)
--    return b, "结束协同程序"                   -- b的值为第二次调用协同程序时传入
--end)

--print("main", coroutine.resume(co, 1, 10)) -- true, 4
--print("main", coroutine.resume(co, "r")) -- true 11 -9
--print("main", coroutine.resume(co, "x", "y")) -- true 10 "结束协同程序"
--print("main", coroutine.resume(co, "x", "y")) -- cannot resume dead coroutine

--local y = coroutine.resume(co,4) 
--local r = coroutine.yield(x)--返回给resume x值，当下次进入，会从resume获取r值





--file = io.open("test.lua", "r")
--io.input(file)
--print(io.read())
--io.close(file)
--file = io.open("test.lua", "a")
--io.output(file)
--io.write("--  test.lua 文件末尾注释")
--io.close(file)


--file = io.open("C:\\Users\\Administrator\\Desktop\\x.lua", "r")
--io.input(file)
--print("io:", io.read())
--io.close(file)
--file = io.open("C:\\Users\\Administrator\\Desktop\\x.lua", "w")
--io.output(file)
--io.write("bbb")
--io.close(file)

--把错误打印
-- assert(type(b) == "number", "b 不是一个数字")

--sql开源数据库
--require "luasql.mysql"





os.execute("pause") 

--slua + new UI

--lua基础
--http://www.yiibai.com/lua/
--http://www.runoob.com/lua/lua-tutorial.html

--例子出处
--http://my.jikexueyuan.com/ime/record/
--http://my.jikexueyuan.com/suool/record/
--http://my.jikexueyuan.com/0mVUggqaV/record/

--参考网站
--http://www.lua.org/manual/5.3/
--http://www.lua.org/cgi-bin/demo

--类和继承
--http://blog.csdn.net/sgamerw/article/details/10024131
--http://www.jb51.net/article/55724.htm---没有什么代表性





--每个 table 和 userdata 拥有独立的 metatable

--table
--Lua 的一种数据结构用来帮助我们创建不同的数据类型，如：数字、字典等。

--userdata
--lua_newuserdata函数按照指定的大小分配一块内存，将对应的userdatum放到栈内，并返回内存块的地址
--可用来封装C语言的struct结构
--对两个 table 进行操作

--setmetadata(设置元表)
--你可以通过 setmetatable 函数来替换掉 table 的 metatable,你不能从 Lua 中改变其它任何类型的值的 metatable
--一个 metatable 可以控制一个对象做数学运算操作、比较操作、连接操作、取长度操作、取下标操作时的行为

--getmetadata(获取元表)
--你可以通过 getmetatable 函数来查询到任何一个值的 metatable

 


--注释快捷键
--ctrl+K+C
--ctrl+K+U


--endregion
