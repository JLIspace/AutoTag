using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace autotag.Core {
    public interface IProcessor {
        Task<bool> process(
            string filePath,
            Action<string> setPath,
            Action<string, bool> setStatus,
            Func<List<Tuple<string, string>>, int> selectResult,
            AutoTagConfig config
        );
    }
}