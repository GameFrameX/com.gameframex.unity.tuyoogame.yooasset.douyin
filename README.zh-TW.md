<div align="center">

<img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="Game Frame X Logo" width="160" />

# Game Frame X YooAsset DouYin

[![License](https://img.shields.io/badge/license-blue.svg)](LICENSE.md)
[![Version](https://img.shields.io/github/v/release/gameframex/com.gameframex.unity.tuyoogame.yooasset.douyin)](https://github.com/gameframex/com.gameframex.unity.tuyoogame.yooasset.douyin/releases)
[![Unity Version](https://img.shields.io/badge/Unity-2019.4-black?logo=unity)](https://unity.com/)
[![Documentation](https://img.shields.io/badge/Documentation-docs-blue)](https://gameframex.doc.alianblank.com)

[![Discord](https://img.shields.io/badge/-5865F2?logo=discord&logoColor=white)](https://discord.gg/VDWUjWMDw9)
[![GitHub](https://img.shields.io/badge/-181717?logo=github&logoColor=white)](https://github.com/GameFrameX/gameframex)
[![Bilibili](https://img.shields.io/badge/-00A1D6?logo=bilibili&logoColor=white)](https://www.bilibili.com/video/BV1yrpeepEn7)
[![Gitee](https://img.shields.io/badge/-C71D23?logo=gitee&logoColor=white)](https://gitee.com/GameFrameX/gameframex)

獨立遊戲前後端一體化解決方案 · 獨立遊戲開發者的圓夢大使

<br />

[文檔](https://gameframex.doc.alianblank.com) · [快速開始](#快速開始) · QQ群: 467608841 / 233840761

<br />

[English](README.md) | [简体中文](README.zh-CN.md) | **繁體中文** | [日本語](README.ja.md) | [한국어](README.ko.md)

</div>

## 項目簡介

Game Frame X YooAsset DouYin 是面向 Unity WebGL **抖音小遊戲（大陸版）** 運行時的 YooAsset `IFileSystem` 適配套件。它將 ByteGame 平台特有的檔案系統行為接入 YooAsset 資源管線，讓你的專案能夠透過抖音小遊戲平台分發 AssetBundle。

## 功能特性

- 為抖音小遊戲運行時提供專用的 `ByteGameFileSystem` 實作。
- 與抖音小遊戲 SDK 深度整合，涵蓋 AssetBundle 下載、暫存與裝置端讀取。
- 打通 YooAsset 的套件版本請求、清單載入與資源包下載/載入全流程。
- 支援可插拔的 `IRemoteServices` 接入點，方便自訂 CDN 與解密邏輯。

## 快速開始

### 安裝

選擇以下任一方式：

1. 編輯 Unity 專案的 `Packages/manifest.json`，添加 `scopedRegistries` 部分：

   ```json
   {
     "scopedRegistries": [
       {
         "name": "GameFrameX",
         "url": "https://gameframex.upm.alianblank.uk",
         "scopes": [
           "com.gameframex"
         ]
       }
     ],
     "dependencies": {
       "com.gameframex.unity.tuyoogame.yooasset.douyin": "1.0.0"
     }
   }
   ```

   `scopes` 控制哪些套件透過此註冊表解析。只有以 `com.gameframex` 開頭的套件才會從這個註冊表取得。

2. 直接在 `manifest.json` 的 `dependencies` 節點下添加以下內容：

   ```json
   {
     "com.gameframex.unity.tuyoogame.yooasset.douyin": "https://github.com/gameframex/com.gameframex.unity.tuyoogame.yooasset.douyin.git"
   }
   ```

3. 在 Unity 的 **Package Manager** 中使用 **Git URL** 的方式添加庫，地址為：`https://github.com/gameframex/com.gameframex.unity.tuyoogame.yooasset.douyin.git`
`
4. 直接下載倉庫放置到 Unity 專案的 `Packages` 目錄下，會自動載入識別。


### 使用範例

安裝完成後，將 ByteGame 檔案系統參數交給 YooAsset 的 Web 模式初始化器即可：

```csharp
using YooAsset;

var createParameters = new WebPlayModeParameters();
createParameters.WebFileSystemParameters = ByteGameFileSystemCreater.CreateByteGameFileSystemParameters(remoteServices);
```

## 依賴

| 包 | 說明 |
| --- | --- |
| `com.gameframex.unity.tuyoogame.yooasset` | 2.9.4 | YooAsset 核心執行時與 API。 |
| `com.gameframex.unity.asset` | 3.1.1 | GameFrameX 資源/執行時整合。 |

## 文檔與資源

- [官方文檔](https://gameframex.doc.alianblank.com)

## 社區與支援

![QQ](https://img.shields.io/badge/QQ-467608841%2F233840761-EB1923?style=for-the-badge&logo=qq&logoColor=white)
[![Bilibili](https://img.shields.io/badge/Bilibili-00A1D6?style=for-the-badge&logo=bilibili&logoColor=white)](https://www.bilibili.com/video/BV1yrpeepEn7)
[![Gitee](https://img.shields.io/badge/Gitee-C71D23?style=for-the-badge&logo=gitee&logoColor=white)](https://gitee.com/GameFrameX/gameframex)
[![Discord](https://img.shields.io/badge/Discord-5865F2?style=for-the-badge&logo=discord&logoColor=white)](https://discord.gg/VDWUjWMDw9)
[![GitHub](https://img.shields.io/badge/GitHub-181717?style=for-the-badge&logo=github&logoColor=white)](https://github.com/GameFrameX/gameframex)
[<img src="https://cdn.jsdelivr.net/npm/devicon@2/icons/linkedin/linkedin-original.svg" height="28" alt="LinkedIn" />](https://www.linkedin.com/in/alianblank)
[![Reddit](https://img.shields.io/badge/Reddit-FF4500?style=for-the-badge&logo=reddit&logoColor=white)](https://www.reddit.com/r/GameFrameX/)
[![X](https://img.shields.io/badge/X-000000?style=for-the-badge&logo=x&logoColor=white)](https://x.com/alian_blank)
[![YouTube](https://img.shields.io/badge/YouTube-FF0000?style=for-the-badge&logo=youtube&logoColor=white)](https://www.youtube.com/channel/UCD9QhSFJ5xZkn5NTSV-DVAw)
[![Bluesky](https://img.shields.io/badge/Bluesky-0285FF?style=for-the-badge&logo=bluesky&logoColor=white)](https://bsky.app/profile/alianblank.bsky.social)

## 更新日誌

查看 [Releases](https://github.com/gameframex/com.gameframex.unity.tuyoogame.yooasset.douyin/releases) 了解更新日誌。

## 開源協議

詳見 [LICENSE.md](LICENSE.md) 檔案。
