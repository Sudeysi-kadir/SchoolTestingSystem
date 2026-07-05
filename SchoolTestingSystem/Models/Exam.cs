namespace SchoolTestingSystem.Models
{
    class Exam
    {
        public List<string> Questions {get;set;}
        public int Score{get;set;}
        public ExamStatus Status{get;set;} = ExamStatus.NotTaken;
        public Exam()
        {
            Questions = new List<string>();
        }
    }
}