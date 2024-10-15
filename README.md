## HOMEPAGE

GameFrameX 的 XLua 组件

** XLua 组件 (XLua Component)** - 提供了执行 Lua 代码、加载 Lua 脚本、管理 Lua 环境等操作的接口。

# 使用文档(文档编写于GPT4)

# XLuaComponent 说明文档

`XLuaComponent` 是一个用于集成 XLua 功能的组件，提供了执行 Lua 代码、加载 Lua 脚本、管理 Lua 环境等操作的接口。

## 功能概述

- 环境管理：初始化和清理 Lua 环境。
- 执行脚本：运行 Lua 代码字符串或字节码。
- 加载代码：加载 Lua 脚本并获取可执行的函数。
- 扩展功能：添加自定义函数和类型别名，增强 Lua 的能力。
- 自定义加载器：支持从不同来源加载 Lua 脚本。
- 数据操作：创建和操作 Lua 表。
- 内存管理：控制 Lua 的垃圾回收机制。

## 方法说明

### Awake

初始化组件，获取 Lua 管理器实例并初始化 Lua 环境。

**参数**：
无

**返回值**：
无

---

### DoString(string lua, string chunkName = "chunk", LuaTable env = null)

执行 Lua 代码字符串。

**参数**：

- `lua`: Lua 代码字符串。
- `chunkName`: 代码块名称，默认为 "chunk"。
- `env`: Lua 环境表，默认为 null。

**返回值**：
执行结果数组。

---

### DoString(byte[] luaBytes, string chunkName = "chunk", LuaTable env = null)

执行 Lua 字节数组。

**参数**：

- `luaBytes`: Lua 字节数组。
- `chunkName`: 代码块名称，默认为 "chunk"。
- `env`: Lua 环境表，默认为 null。

**返回值**：
执行结果数组。

---

### LoadString(string lua, string chunkName = "chunk", LuaTable env = null)

加载 Lua 代码字符串。

**参数**：

- `lua`: Lua 代码字符串。
- `chunkName`: 代码块名称，默认为 "chunk"。
- `env`: Lua 环境表，默认为 null。

**返回值**：
加载的 Lua 函数。

---

### LoadString<T>(string lua, string chunkName = "chunk", LuaTable env = null)

加载 Lua 代码字符串并返回指定类型。

**参数**：

- `lua`: Lua 代码字符串。
- `chunkName`: 代码块名称，默认为 "chunk"。
- `env`: Lua 环境表，默认为 null。

**返回值**：
加载的 Lua 函数，类型为 T。

---

### AddBuildIn(string buildInName, lua_CSFunction init)

添加内置函数。

**参数**：

- `buildInName`: 内置函数名称。
- `init`: 初始化函数。

**返回值**：
无

---

### AddLoader(LuaEnv.CustomLoader loader)

添加自定义加载器。

**参数**：

- `loader`: 自定义加载器。

**返回值**：
无

---

### NewTable()

创建新的 Lua 表。

**参数**：
无

**返回值**：
新的 Lua 表。

---

### Dispose()

释放 Lua 环境。

**参数**：
无

**返回值**：
无

---

### GetGlobal()

获取全局 Lua 表。

**参数**：
无

**返回值**：
全局 Lua 表。

---

### Tick()

进行一次 Lua 垃圾回收。

**参数**：
无

**返回值**：
无

---

### Alias(Type type, string alias)

为指定类型添加别名。

**参数**：

- `type`: 指定类型。
- `alias`: 类型别名。

**返回值**：
无

---

### GC()

执行一次 Lua 垃圾回收。

**参数**：
无

**返回值**：
无

---

### RestartGc()

重新启动 Lua 垃圾回收。

**参数**：
无

**返回值**：
无

---

### FullGc()

进行一次完整 Lua 垃圾回收。

**参数**：
无

**返回值**：
无

---

### GcStep(int data)

执行 Lua 垃圾回收一步。

**参数**：

- `data`: 回收数据。

**返回值**：
无

---

### StopGc()

停止 Lua 垃圾回收。

**参数**：
无

**返回值**：
无

# 使用方式(任选其一)

1. 直接在 `manifest.json` 的文件中的 `dependencies` 节点下添加以下内容
   ```json
      {"com.gameframex.unity.xlua": "https://github.com/AlianBlank/com.gameframex.unity.xlua.git"}
    ```
2. 在Unity 的`Packages Manager` 中使用`Git URL` 的方式添加库,地址为：https://github.com/AlianBlank/com.gameframex.unity.xlua.git

3. 直接下载仓库放置到Unity 项目的`Packages` 目录下。会自动加载识别