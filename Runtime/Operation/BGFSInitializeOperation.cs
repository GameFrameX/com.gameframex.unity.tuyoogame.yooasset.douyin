#if UNITY_WEBGL && ENABLE_DOUYIN_MINI_GAME && DOUYINMINIGAME

using YooAsset;

namespace YooAsset.DouYin
{
    [UnityEngine.Scripting.Preserve]
    internal partial class BGFSInitializeOperation : FSInitializeFileSystemOperation
    {
        private readonly ByteGameFileSystem _fileSystem;

        [UnityEngine.Scripting.Preserve]
        public BGFSInitializeOperation(ByteGameFileSystem fileSystem)
        {
            _fileSystem = fileSystem;
        }

        [UnityEngine.Scripting.Preserve]
        public override void InternalOnStart()
        {
            Status = EOperationStatus.Succeed;
        }

        [UnityEngine.Scripting.Preserve]
        public override void InternalOnUpdate()
        {
        }
    }
}
#endif