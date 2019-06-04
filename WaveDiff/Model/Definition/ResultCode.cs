using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaveDiff.Model.Definition
{
    /// <summary>
    /// 処理の戻り値
    /// </summary>
    public enum ResultCode {
        /// <summary>
        /// 正常
        /// </summary>
        Success = 0,
        /// <summary>
        /// ファイル書き込み失敗
        /// </summary>
        FailWriteFile = 1,
        /// <summary>
        /// ファイル読込失敗
        /// </summary>
        FailReadFile = 2,
        /// <summary>
        /// 引数以上
        /// </summary>
        InvalidArgument = 3,
        /// <summary>
        /// Windows例外発生
        /// </summary>
        ExceptionFromWindows = 4
    }
}
