# Game Frame X YooAsset MiniGame DouYin

YooAsset 抖音小游戏（大陆版，ByteGame）适配包，提供抖音小游戏平台的资源文件系统（`ByteGameFileSystem`）。

> 抖音（大陆版）与 TikTok（国际版）是两套独立插件，本包为大陆版；国际版请使用 `com.gameframex.unity.tuyoogame.yooasset.minigame.tiktok`。

## 依赖

- `com.gameframex.unity.tuyoogame.yooasset` >= 2.9.4
- 抖音小游戏 Unity SDK（StarkSDK，`com.bytedance.starksdk`，提供 `StarkSDKSpace` / `StarkWebGL` 程序集）

## 激活条件

代码由 `UNITY_WEBGL && ENABLE_DOUYIN_MINI_GAME` 宏保护，与 GameFrameX 主框架 `MiniGameDefineSymbolHelper` 权威宏对齐。两条激活路径：

1. 菜单 `GameFrameX/Scripting Define Symbols/Domestic Mini Games(国内小游戏)/Enable DouYin Mini Game(开启[抖音小游戏]适配)`（同时注入 `DOUYINMINIGAME`、`TTSDK_MIX_ENGINE`）
2. 安装 StarkSDK 后由 asmdef `versionDefines` 自动定义 `ENABLE_DOUYIN_MINI_GAME`

## 使用

通过 `ByteGameFileSystemCreater` 创建文件系统参数，接入 YooAsset 初始化流程：

```csharp
using GameFrameX.Asset.YooAsset.Minigame.DouYin.Runtime;
using YooAsset;

var package = YooAssets.CreatePackage("DefaultPackage");
var createParameters = new WebPlayModeParameters();
createParameters.FileSystemParameters = ByteGameFileSystemCreater.CreateByteGameFileSystemParameters(remoteServices);
```

## License

本项目采用 MIT 许可证与 Apache License 2.0 双许可证分发，详见 [LICENSE.md](LICENSE.md)。
