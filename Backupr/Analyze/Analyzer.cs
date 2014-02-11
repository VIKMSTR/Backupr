using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backupr.Analyze
{
    class Analyzer
    {
        private static Analyzer _instance;

        private Analyzer()
        {
            LoadDirectories();
            AnalyzeChanges();
        }

        public void AnalyzeChanges()
        {
            throw new NotImplementedException();
        }

        private void LoadDirectories()
        {
            throw new NotImplementedException();
        }

        public static Analyzer GetAnalyzer()
        {
            return _instance ?? (_instance = new Analyzer());
        }
    }
}
