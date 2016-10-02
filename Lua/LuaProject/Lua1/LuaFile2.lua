--region *.lua
--Date
--此文件由[BabeLua]插件自动生成

  local _a1 = { key1 = "hello", key2 = "world", lang = "lua" ,txt = "txt"}
  print("the table _a1:")
  for _,v in pairs(_a1) do
      print(v)
  end
  
  local _a2 = { 
      key1 = "hello new",
      key2 = "world new"
  }
  
  print("\nthe old table _a2:")
  for _,v in pairs(_a2) do
      print(v)
  end
  
  print("\na2的metatable:",getmetatable(_a2))
  print("language:",_a2["key1"])
  
  -- 关注函数及__index
  local newKey = { newIndexKey = "Value"}
  --{__index = _a1}
  setmetatable(_a2, newKey)
  
  print("\nthe new table _a2:")
  for _,v in pairs(_a2) do
      print(v)
  end

--  print("lang:", _a2["txt"])
--  print("key1:", _a2["key1"])
--  print("key2:", _a2["key2"])

print(_a2["__index"])


  os.execute("pause")
--endregion
