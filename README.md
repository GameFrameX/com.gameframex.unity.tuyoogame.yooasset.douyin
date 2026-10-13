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

All-in-One Solution for Indie Game Development · Empowering Indie Developers' Dreams

<br />

[Documentation](https://gameframex.doc.alianblank.com) · [Quick Start](#quick-start) · QQ Group: 467608841 / 233840761

<br />

**English** | [简体中文](README.zh-CN.md) | [繁體中文](README.zh-TW.md) | [日本語](README.ja.md) | [한국어](README.ko.md)

</div>

## Project Overview

Game Frame X YooAsset DouYin is a YooAsset `IFileSystem` adapter package targeting the **DouYin (Mainland China)** mini-game runtime on Unity WebGL. It plugs ByteGame-specific file system behavior into the YooAsset asset pipeline so your project can ship AssetBundles through the DouYin mini-game platform.

## Features

- Dedicated `ByteGameFileSystem` implementation for the DouYin mini-game runtime.
- Tight integration with the DouYin SDK for AssetBundle download, caching, and on-device access.
- Wires YooAsset package version request, manifest loading, and bundle download/load into one cohesive flow.
- Pluggable `IRemoteServices` hook for custom CDN endpoints and decryption routines.

## Quick Start

### Installation

Choose one of the following methods:

1. Edit your Unity project's `Packages/manifest.json` and add a `scopedRegistries` section:

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

   `scopes` controls which packages are resolved through this registry. Only packages whose names start with `com.gameframex` will be fetched from it.

2. Add the Git URL directly to `manifest.json` under `dependencies`:

   ```json
   {
     "com.gameframex.unity.tuyoogame.yooasset.douyin": "https://github.com/gameframex/com.gameframex.unity.tuyoogame.yooasset.douyin.git"
   }
   ```

3. In Unity's **Package Manager**, add via **Git URL**: `https://github.com/gameframex/com.gameframex.unity.tuyoogame.yooasset.douyin.git`.
4. Clone the repository into your Unity project's `Packages/` directory; it will be picked up automatically.


### Upgrade Notes (1.1.0)

This is a breaking change: the package no longer depends on `com.gameframex.unity.asset`. Upgrade `com.gameframex.unity.tuyoogame.yooasset` to ≥ 3.1.0 at the same time; if your project also installs `com.gameframex.unity.asset`, upgrade it to ≥ 4.1.0.

### Usage Examples

After installation, hand the ByteGame file system parameters to YooAsset's web play mode initializer:

```csharp
using YooAsset;

var createParameters = new WebPlayModeParameters();
createParameters.WebFileSystemParameters = ByteGameFileSystemCreater.CreateByteGameFileSystemParameters(remoteServices);
```

## Dependencies

| Package | Description |
| --- | --- |
| `com.gameframex.unity.tuyoogame.yooasset` | ≥ 3.1.0 | Core YooAsset runtime & API. |

## Register-and-Dispatch Mechanism

The package's Registrar self-registers its `IWebPlayModeFileSystemProvider` (Priority 0) into the main YooAsset package's `WebPlayModeFileSystemProviderRegistry`, so installation alone enables dispatch with no platform branching. The asset abstraction layer resolves providers by Priority during the first Web play mode initialization — the highest Priority wins (first registered wins on ties), so only one platform is selected per initialization. Registration runs at the `BeforeSceneLoad` stage, earlier than the first Web initialization, so the provider is always ready.

## Documentation & Resources

- [Official Documentation](https://gameframex.doc.alianblank.com)

## Community & Support

[![GitHub](https://img.shields.io/badge/GitHub-181717?style=for-the-badge&logo=github&logoColor=white)](https://github.com/GameFrameX/gameframex)
[![Discord](https://img.shields.io/badge/Discord-5865F2?style=for-the-badge&logo=discord&logoColor=white)](https://discord.gg/VDWUjWMDw9)
[<img src="https://cdn.jsdelivr.net/npm/devicon@2/icons/linkedin/linkedin-original.svg" height="28" alt="LinkedIn" />](https://www.linkedin.com/in/alianblank)
[![Reddit](https://img.shields.io/badge/Reddit-FF4500?style=for-the-badge&logo=reddit&logoColor=white)](https://www.reddit.com/r/GameFrameX/)
[![X](https://img.shields.io/badge/X-000000?style=for-the-badge&logo=x&logoColor=white)](https://x.com/alian_blank)
[![YouTube](https://img.shields.io/badge/YouTube-FF0000?style=for-the-badge&logo=youtube&logoColor=white)](https://www.youtube.com/channel/UCD9QhSFJ5xZkn5NTSV-DVAw)
[![Bluesky](https://img.shields.io/badge/Bluesky-0285FF?style=for-the-badge&logo=bluesky&logoColor=white)](https://bsky.app/profile/alianblank.bsky.social)
[![Bilibili](https://img.shields.io/badge/Bilibili-00A1D6?style=for-the-badge&logo=bilibili&logoColor=white)](https://www.bilibili.com/video/BV1yrpeepEn7)
[![Gitee](https://img.shields.io/badge/Gitee-C71D23?style=for-the-badge&logo=gitee&logoColor=white)](https://gitee.com/GameFrameX/gameframex)
![QQ](https://img.shields.io/badge/QQ-467608841%2F233840761-EB1923?style=for-the-badge&logo=qq&logoColor=white)

## Changelog

See [Releases](https://github.com/gameframex/com.gameframex.unity.tuyoogame.yooasset.douyin/releases) for the changelog.

## License

See [LICENSE.md](LICENSE.md) for license information.
