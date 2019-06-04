using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaveDiff.Model.Definition;
using WaveDiff.Model.Structure;

namespace WaveDiff.Model.File
{
    /// <summary>
    /// 各種音声ファイルのIO処理定義
    /// </summary>
    public interface IAudioFile
    {
        /// <summary>
        /// ファイル読込処理
        /// </summary>
        /// <param name="filePath">絶対パス</param>
        /// <param name="item">Waveファイル解析データ</param>
        /// <returns>処理結果</returns>
        ResultCode Read(in string filePath, out StructureWaveFileItem item);
        /// <summary>
        /// ファイル書き込み処理
        /// </summary>
        /// <param name="filePath">絶対パス</param>
        /// <param name="item">Waveファイル書き込みデータ</param>
        /// <returns></returns>
        ResultCode Write(in string filePath, in StructureWaveFileItem item);
    }
    /// <summary>
    /// 各種音声ファイルのIO処理の基底クラス
    /// 主にIOに関する状態情報を保持する。
    /// </summary>
    public abstract class AudioFileBase{
        bool IsAnalyzing { get; set; } = false;
    }
}
