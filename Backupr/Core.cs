using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using System.Timers;
using Backupr.Analyze;

namespace Backupr
{
    
    class Core
    {
        private static Core _instance;
        private Timer _t;
        private const int Interval = 5000;
        private readonly Analyzer _analyzer;

        private Core()
        {
            _t = new Timer();
            _t.Elapsed += Check;
            _t.Interval = Interval;
            _analyzer = Analyzer.GetAnalyzer();
        }

        private void Check(object sender, ElapsedEventArgs elapsedEventArgs)
        {
            //analyzes the changes in directories
            _analyzer.AnalyzeChanges();

        }

        public static Core AccessCore()
        {
            if (_instance == null)
            {
                _instance = new Core();
            }
            return _instance;
        }

    
    }
}
