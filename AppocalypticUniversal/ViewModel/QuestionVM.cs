using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppocalypticUniversal.Model;

namespace AppocalypticUniversal.ViewModel
{
    class QuestionVM
    {
        private Questions question;

        public QuestionVM()
        {
            question = new Questions();
        }

        public Questions Question { get => question; set => question = value; }
    }
}