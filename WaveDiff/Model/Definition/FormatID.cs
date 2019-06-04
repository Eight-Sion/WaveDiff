using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaveDiff.Model.Definition
{
    /// <summary>
    /// 音声ファイルの圧縮フォーマット
    /// </summary>
    public enum FormatID
    {
        LinearPCM = 0x0001,
        MS_ADPCM = 0x0002,
        IBM_CSVD = 0x0005,
        A_Law = 0x0006,
        u_Law = 0x0007
    }
}
