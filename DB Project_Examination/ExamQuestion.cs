using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB_Project_Examination.Model;

namespace DB_Project_Examination
{
    internal class ExamQuestion
    {
        public int ques_id { get; set; }
        public string ques_type { get; set; }
        public string ques_header { get; set; }
        public string ques_body { get; set; }
        public int ques_grade { get; set; }
        public int ans_id { get; set; }
        public string ques_text { get; set; }
        public List<Ques_Choice> choices { get; set; }
        public int Stud_Ans { get; set; }
        public bool ques_marked { get; set; } = false;
    }
}
