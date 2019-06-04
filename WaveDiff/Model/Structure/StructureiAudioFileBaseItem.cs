using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaveDiff.Model.Structure
{
    /// <summary>
    /// 音声ファイル構造基底クラス
    /// </summary>
    public abstract class StructureiAudioFileBaseItem
    {
        /// <summary>
        /// ファイル名（絶対パス）
        /// </summary>
        string FileName { get; set; } = null;
        bool IsDisposed { get; set; } = false;

    }
}
