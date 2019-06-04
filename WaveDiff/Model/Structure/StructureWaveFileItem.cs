using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaveDiff.Model.Definition;

namespace WaveDiff.Model.Structure
{
    /// <summary>
    /// [wav]形式音声ファイルのデータ構造クラス
    /// </summary>
    public class StructureWaveFileItem : StructureiAudioFileBaseItem, IDisposable, ICloneable
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        StructureWaveFileItem()
        {

        }
        /// <summary>
        /// コピー用コンストラクタ
        /// </summary>
        /// <param name="source"></param>
        StructureWaveFileItem(StructureWaveFileItem source) {
            this.RiffHeader = source.RiffHeader;
            this.FileSize = source.FileSize;
            this.FormatChunk = source.FormatChunk;
            this.FormatChunkSize = source.FormatChunkSize;
            this.Format = source.Format;
            this.Channel = source.Channel;
            this.BytePerSec = source.BytePerSec;
            this.BitPerSample = source.BitPerSample;
            this.DataChunkSize = source.DataChunkSize;
            this.SamplingData = source.SamplingData;
            this.SampleRate = source.SampleRate;
        }

        /// <summary>
        /// RIFFヘッダ	4バイト	RIFFファイル形式のファイルであることを表す文字列。
        /// 固定文字列「RIFF」
        /// </summary>
        public string RiffHeader { get; set; } = string.Empty;
        /// <summary>
        /// ファイルサイズ
        /// 4バイト	ファイルサイズ（バイト）。リトルエンディアン
        /// </summary>
        public int FileSize { get; set; } = default;
        /// <summary>
        /// フォーマットチャンクヘッダ	4バイト	以下が”fmt ”（フォーマット）チャンクの定義を表す
        /// </summary>
        public string FormatChunk { get; set; } = string.Empty;
        /// <summary>
        /// フォーマット定義サイズ	4バイト	フォーマットの定義関連のデータサイズ
        /// </summary>
        public int FormatChunkSize { get; set; } = default;
        /// <summary>
        /// フォーマットID	2バイト	圧縮のフォーマットID
　      /// 0x0001：リニアPCM
　      /// 0x0002：MS ADPCM
　      /// 0x0005：IBM CSVD
　      /// 0x0006：A-Law
　      /// 0x0007：μ-Law
        /// </summary>
        public FormatID Format { get; set; } = FormatID.LinearPCM;
        /// <summary>
        /// チャンネル数	2バイト	
        /// モノラルの場合：0x0001
        /// ステレオの場合：0x0002
        /// </summary>
        public short Channel { get; set; } = default;
        /// <summary>
        /// データ転送速度[byte/sec]	4バイト	44.1kHz　16bitステレオの場合：44100×2×2 =176400
        /// 44.1KHz　16bitモノラルの場合：44100×2×1=88200
        /// </summary>
        public int BytePerSec { get; set; } = default;
        /// <summary>
        /// バイト/サンプル	2バイト	サンプルあたりのバイト数
        /// 16bitステレオ：4
        /// 16bitモノラル：2
        /// 8bitモノラル：1
        /// </summary>
        public short BitPerSample { get; set; } = default;
        /// <summary>
        /// データチャンクヘッダ	4バイト	以下が”data”（データ）チャンクの定義を表す
        /// </summary>
        public short DataChunkSize { get; set; } = default;

        /// <summary>
        /// サンプリングデータ　nバイト	音楽サンプルデータ。リトルエンディアン
        /// </summary>
        public List<int> SamplingData { get; set; } = new List<int>();

        public int SampleRate { get; set; } = default;


        /// <summary>
        /// メンバーの正当性をチェック
        /// </summary>
        /// <returns></returns>
        public bool IsValid() {
            if (RiffHeader != "RIFF") return false;
            if (FileSize <= 0) return false;
            if (FormatChunk != string.Empty) return false;
            if (FormatChunkSize <= 0) return false;
            //if (Format != ) return false;
            if (Channel <= 0) return false;
            if (SampleRate <= 0) return false;
            if (DataChunkSize <= 0) return false;
            if (RiffHeader != "RIFF") return false;
            if (RiffHeader != "RIFF") return false;
            return true;//正常
        }



        #region 破棄処理
        /// <summary>
        /// 破棄処理済み
        /// </summary>
        internal bool _disposed = default;
        /// <summary>インスタンスの破棄</summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);    //  ファイナライザによるDispose()呼び出しの抑制。
        }
        /// <summary>インスタンスの破棄</summary>
        /// <param name="disposing">呼び出し元の判別
        ///     <list type="bullet" >
        ///         <item>true=Dispose()関数からの呼び出し。</item>
        ///         <item>false=ファイナライザによる呼び出し。</item>
        ///     </list>
        /// </param>
        protected void Dispose(bool disposing)
        {
            try
            {
                if (false == _disposed)
                {
                    if (true == disposing)
                    {
                        //  マネージリソースの解放
                    }
                    //  アンマネージリソースの解放
                }
                _disposed = true;
            }
            finally
            {
                //  基底クラスのDispose()を確実に呼び出す。
                //base.Dispose();
            }
        }
        #endregion
        /// <summary>
        /// クローン
        /// </summary>
        /// <returns></returns>
        public new object Clone() => new StructureWaveFileItem(this);


    }
}
