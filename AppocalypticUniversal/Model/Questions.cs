using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppocalypticUniversal.Model
{
    class Questions
    {
        private string[] _mindArr = new string[] { };
        private string[] _energyArr = new string[] { };
        private string[] _tacticsArr = new string[] { };
        private string[] _natureArr = new string[] { };
        private string[] _identifyArr = new string[] { };

        public string[] MindArr { get => _mindArr; }
        public string[] EnergyArr { get => _energyArr; }
        public string[] TacticsArr { get => _tacticsArr; }
        public string[] NatureArr { get => _natureArr; }
        public string[] IdentifyArr { get => _identifyArr; }

        public Questions()
        {
            LoadTheQuestions();
        }

        private void LoadTheQuestions()
        {
            _energyArr = System.IO.File.ReadAllLines(@"Debug\EnergyQuestions.txt");
            _tacticsArr = System.IO.File.ReadAllLines(@"Debug\TacticsQuestions.txt");
            _natureArr = System.IO.File.ReadAllLines(@"Debug\NatureQuestions.txt");
            _identifyArr = System.IO.File.ReadAllLines(@"Debug\IdentifyQuestions.txt");
            _mindArr = System.IO.File.ReadAllLines(@"Debug\MindQuestions.txt");
        }
    }
}
